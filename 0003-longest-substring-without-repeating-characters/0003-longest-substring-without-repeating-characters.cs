public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int strLength = s.Length;
        int maxLength = 0;
        List<char> cList = new List<char>();

        for(int i=0;i<strLength;i++){
            cList.Clear();
            cList.Add(s[i]);
            int curLength = 1;
            maxLength = maxLength < curLength ? curLength : maxLength;
            for(int j=i+1;j<strLength;j++){
                char c = s[j];

                if(cList.Contains(c)){                    
                    break;
                }

                cList.Add(c);
                curLength++;
            }
            maxLength = maxLength < curLength ? curLength : maxLength;
        }

        return maxLength;
    }
}