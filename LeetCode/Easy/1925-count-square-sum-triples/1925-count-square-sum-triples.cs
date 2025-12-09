public class Solution {
    public int CountTriples(int n) {
        int result = 0;

        for(int i=1;i<=n;i++){
            for(int j=1;j<=n;j++){
                int c = (int)Math.Sqrt(i*i + j*j);

                if(c<=n && c*c == i*i + j*j){
                    result++;
                }
            }
        }

        return result;
    }
}