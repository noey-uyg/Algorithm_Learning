public class Solution {
    private string result = "";
    public string FindDifferentBinaryString(string[] nums) {
        HashSet<string> hashset = new HashSet<string>(nums);

        back("",nums.Length,hashset);

        return result;
    }

    public void back(string cur, int n, HashSet<string> hashset){
        if(cur.Length > n) return;

        if(cur.Length == n){
            if(!hashset.Contains(cur)){
                result = cur;
                return;
            }
        }

        back(cur+"0", n, hashset);
        back(cur+"1", n, hashset);
    }
}