public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int len = grid.Length;
        int max = len*len;
        HashSet<int> hashset = new HashSet<int>();
        int[] result = new int[2];

        for(int i=0;i<len;i++){
            for(int j=0;j<len;j++){
                int num = grid[i][j];
                if(hashset.Contains(num)){
                    result[0] = num;
                }
                hashset.Add(num);
            }
        }

        for(int i=1;i<=max;i++){
            if(!hashset.Contains(i)){
                result[1] = i;
                break;
            }
        }

        return result;
    }
}