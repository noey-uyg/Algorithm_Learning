public class Solution {
    public int CountTriples(int n) {
        int result = 0;

        for(int i=1;i<=n;i++){
            for(int j=1;j<=n;j++){
                int temp = i*i + j*j;
                int c = (int)Math.Sqrt(temp);

                if(c>n) break;
                if(c<=n && c*c == temp){
                    result++;
                }
            }
        }

        return result;
    }
}