public class Solution {
    public bool solution(int x) {
        bool answer = true;
        
        int sum =0;
        string xx = x.ToString();
        
        for(int i=0;i<xx.Length;i++){
            sum+=xx[i]-'0';
        }
        return Hashad(sum,x);
    }
    
    public bool Hashad(int num, int x){
        return x%num == 0;
    }
}