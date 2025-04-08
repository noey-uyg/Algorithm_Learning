using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] fees, string[] records) {     
        var result = new List<int>();
        var inCar = new Dictionary<string,int>();
        var outCar = new Dictionary<string,int>();
        string maxTime = "23:59";
        int maxOutTime = ConvertTime(maxTime.Split(":"));
        
        for(int i=0;i<records.Length;i++){
            string[] str = records[i].Split(' ');
            string time = str[0];
            string number = str[1];
            string inOut = str[2];
            
            if(inOut == "IN")
                inCar[number] = ConvertTime(time.Split(":"));
            else if(inOut=="OUT"){
                int outTime = ConvertTime(time.Split(":"));
                
                if(outCar.ContainsKey(number)){
                    outCar[number] += (outTime - inCar[number]);
                    inCar.Remove(number);
                }
                else{
                    outCar[number] = outTime - inCar[number];
                    inCar.Remove(number);
                }
            }
        }
        
        foreach(var v in inCar){
            if(outCar.ContainsKey(v.Key))
                outCar[v.Key] += (maxOutTime - v.Value);
            else
                outCar[v.Key] = maxOutTime - v.Value;
        }
        outCar = outCar.OrderBy(item => item.Key).ToDictionary(x => x.Key, x => x.Value);
        
        foreach(var v in outCar){
            if(v.Value < fees[0])
                result.Add(fees[1]);
            else{
                int temp = (int)(Math.Ceiling((double)(v.Value - fees[0])/fees[2]) * fees[3]);
                result.Add(fees[1] + temp);
            }      
        }
        
        return result.ToArray();
    }
    
    public int ConvertTime(string[] time){
        return Int32.Parse(time[0]) * 60 + Int32.Parse(time[1]);
    }
}