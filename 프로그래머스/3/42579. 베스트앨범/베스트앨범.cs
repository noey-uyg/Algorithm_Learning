using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] genres, int[] plays) {
        int[] answer = new int[] {};
        var genreTotalPlay = new Dictionary<string,int>();
        var uniqueNumForGenre = new List<UniquePlay>();
        var result = new List<int>();
        
        for(int i=0;i<genres.Length;i++){
            if(genreTotalPlay.ContainsKey(genres[i])){
                genreTotalPlay[genres[i]] += plays[i];
            }
            else{
                genreTotalPlay[genres[i]] = plays[i];
            }
            
            uniqueNumForGenre.Add(new UniquePlay(i,genres[i],plays[i]));
        }
        
        genreTotalPlay = genreTotalPlay.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key,x=>x.Value);
        
        foreach(var v in genreTotalPlay){
            var unique = uniqueNumForGenre.Where(x=> x.genre == v.Key).OrderByDescending(x=>x.playCount).Select(x=> x.uniqueNumber).Take(2).ToList();
            
            for(int i=0;i<unique.Count;i++){
                result.Add(unique[i]);
            }
        }
        return result.ToArray();
    }
    
    public class UniquePlay{
        public int uniqueNumber;
        public string genre;
        public int playCount;
        
        public UniquePlay(int uniqueNumber, string genre, int playCount){
            this.uniqueNumber = uniqueNumber;
            this.genre = genre;
            this.playCount = playCount;
        }
    }
}