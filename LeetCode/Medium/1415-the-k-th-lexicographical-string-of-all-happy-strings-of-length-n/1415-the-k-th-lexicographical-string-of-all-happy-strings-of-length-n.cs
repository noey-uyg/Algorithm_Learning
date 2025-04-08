public class Solution {
    public static SortedSet<string> sortset = new SortedSet<string>();
    public static List<char> list = new List<char>(['a','b','c']);

    public string GetHappyString(int n, int k) {
        sortset.Clear();
        for(int i=0;i<list.Count;i++){
            Make(n, 1, list[i], list[i].ToString());
        }

        return k > sortset.Count ? "" : sortset.ElementAt(k-1);
    }

    public void Make(int n, int length, char c, string str){
        if(str.Length > n) return;

        if(n == str.Length){
            sortset.Add(str);
        }

        if(n == length) return;

        for(int i=0;i<list.Count;i++){
            if(c == list[i]) continue;

            Make(n, length+1, list[i], str + list[i]);
        }
    }
}