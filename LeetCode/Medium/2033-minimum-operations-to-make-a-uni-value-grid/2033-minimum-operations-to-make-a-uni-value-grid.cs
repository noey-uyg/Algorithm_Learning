public class Solution {
    public int MinOperations(int[][] grid, int x) {
        List<int> list = new List<int>();
        int remain = grid[0][0] % x;
        
        for(int i=0;i<grid.GetLength(0);i++){
            var a = grid[i];
            for(int j=0;j<a.Length;j++){
                if(grid[i][j] % x != remain){
                    return -1;
                }
                list.Add(grid[i][j]);
            }
        }
        
        list.Sort();

        int mid = list[list.Count/2];
        int result = 0;

        for(int i=0;i<list.Count;i++){
            int diff = Math.Abs(list[i] - mid);
            result += diff/x;
        }

        return result;
    }
}