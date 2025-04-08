public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>()
        {
        {'I',1},
        {'V',5},
        {'X',10},
        {'L',50},
        {'C',100},
        {'D',500},
        {'M',1000}
        };

        int result = 0;

        for(int i=0;i<s.Length;i++){
            if(i>0 && dict[s[i]] > dict[s[i-1]]){
                result += dict[s[i]] - dict[s[i-1]] * 2;
            }
            else{
                result += dict[s[i]];
            }
        }

        return result;
    }
}