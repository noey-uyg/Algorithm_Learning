using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        int answer = 0;
        Queue<Truck> q = new Queue<Truck>();
        int index = 0;
        
        while(truck_weights.Length > index){ 
            answer++;

            if(truck_weights[index] <= weight){
                Truck t = new Truck(truck_weights[index], answer);
                weight -= t.weight;
                q.Enqueue(t);
                index++;
            }
            else{
                bool possible = false;
                while(q.Count > 0 && answer - q.Peek().time >= bridge_length){
                    possible = true;
                    Truck temp = q.Dequeue();
                    weight+=temp.weight;
                }
                if(possible)
                    answer--;
            }
        }
        
        answer += bridge_length;
        
        return answer;
    }
    
    public class Truck{
        public int weight;
        public int time;
        
        public Truck(int weight, int time){
            this.weight = weight;
            this.time = time;
        }
    }
}