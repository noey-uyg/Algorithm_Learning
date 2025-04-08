public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0) return "";

        StringBuilder sb = new StringBuilder();
        string firstStr = strs[0];
        bool bTemp = true;

        for(int i=0;i<firstStr.Length;i++){
            char c = firstStr[i];

            for(int j=1;j<strs.Length;j++){
                if(strs[j].Length <= i || strs[j][i] != c){
                    bTemp = false;
                    break;
                }
            }

            if(!bTemp){
                break;
            }
            sb.Append(c);
        }

        return sb.ToString();
    }
}