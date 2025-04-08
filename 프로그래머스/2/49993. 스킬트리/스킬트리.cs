using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string skill, string[] skill_trees) {
        int answer = 0;
        for(int i=0;i<skill_trees.Length;i++){
            string skillTree = skill_trees[i];

            var q = new Queue<char>();
            for(int j=0;j<skillTree.Length;j++){
                char temp = skillTree[j];
                
                if(skill.Contains(temp)){
                    q.Enqueue(temp);
                }
            }
            
            int tempIndex = q.Count;
            for(int j=0;j<tempIndex;j++){
                if(q.Peek().Equals(skill[j]))
                    q.Dequeue();
            }
            
            if(q.Count==0)
                answer++;
        }
        return answer;
    }
}