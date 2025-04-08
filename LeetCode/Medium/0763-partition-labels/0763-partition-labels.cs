public class Solution {
    public IList<int> PartitionLabels(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        List<int> result = new List<int>();

        for(int i=0;i<s.Length;i++){
            dict[s[i]] = i;
        }

        int lastIdx = 0;
        int startIdx = 0;
        
        for(int i=0;i<s.Length;i++){
            lastIdx = Math.Max(lastIdx,dict[s[i]]);

            if(i==lastIdx){
                result.Add(i-startIdx+1);
                startIdx = lastIdx + 1;
            }
        }

        return result;
    }
}