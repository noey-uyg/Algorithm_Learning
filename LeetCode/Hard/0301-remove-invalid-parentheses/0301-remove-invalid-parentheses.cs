public class Solution {
    public IList<string> RemoveInvalidParentheses(string s) {
        int left = 0;
        int right = 0;

        // 제거해야할 개수
        foreach(char c in s){
            if(c=='(') left++;
            else if(c==')'){
                if(left>0) left--;
                else right++;
            }
        }
        
        HashSet<string> result = new HashSet<string>();
        StringBuilder sb = new();

        DFS(s, 0, left, right, 0, sb, result);

        return result.ToList();
    }

    private void DFS(string s, int index, int left, int right, int openCount, StringBuilder sb, HashSet<string> result){
        if(index == s.Length){
            if(left ==0 && right == 0 && openCount == 0) result.Add(sb.ToString());
            return;
        }

        char cur = s[index];
        // 제거
        if(cur == '(' && left > 0) DFS(s, index+1, left-1, right, openCount, sb, result);        
        else if(cur == ')' && right > 0) DFS(s, index+1, left, right-1, openCount, sb, result);

        // 포함
        sb.Append(cur);

        if(cur != '(' && cur != ')') DFS(s, index+1, left, right, openCount, sb, result);
        else if(cur == '(') DFS(s, index+1, left, right, openCount+1, sb, result);
        else if(cur == ')' && openCount > 0) DFS(s, index+1, left, right, openCount-1, sb, result);

        sb.Length--;
    }
}