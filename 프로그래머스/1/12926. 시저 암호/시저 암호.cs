using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        for(int i=0;i<s.Length;i++){
            char chr = s[i];
            int inte = Convert.ToInt32(chr);
            
            if(chr != ' '){
                inte+=n;
                if(char.IsUpper(chr) && inte > 90){
                    inte -= 26;
                }
                else if(char.IsLower(chr) && inte>122){
                    inte -= 26;
                }
            }

            answer += Convert.ToChar(inte);
        }
        return answer;
    }
}