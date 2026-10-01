public class Solution {
    public int MaxDepth(string s) {
        int depth = 0;
        int max = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ')') 
            {
                max--;
                continue;
            }

            if(s[i] == '(')
            {
                if(++max > depth) depth = max;
            }
        }

        return depth;
    }
}