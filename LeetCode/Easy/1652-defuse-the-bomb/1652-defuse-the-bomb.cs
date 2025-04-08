public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int maxLeng = code.Length;
        int[] result = new int[code.Length];
        for(int i=0;i<code.Length;i++){
            if(k==0){
                result[i] = 0;
            }
            else if(k>0){
                for(int j=1;j<=k;j++){
                    result[i]+=code[(j+i)%maxLeng];
                }
            }
            else{
                for(int j=-1;j>=k;j--){
                    if(j+i < 0){
                        result[i]+=code[(j+i)+maxLeng];
                    }
                    else{
                        result[i]+=code[j+i];
                    }
                }
            }
        }

        return result;
    }
}