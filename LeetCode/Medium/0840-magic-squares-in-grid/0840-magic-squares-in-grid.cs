public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        int row = grid.Length;
        int col = grid[0].Length;

        int result = 0;

        for(int r=0;r<row-2;r++){
            for(int c=0;c<col-2;c++){
                if(IsMagicSquare(grid,r,c)) result++;
            }
        }

        return result;
    }

    public bool IsMagicSquare(int[][] grid, int r, int c){
        bool[] b = new bool[10];

        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                int cur = grid[r+i][c+j];

                if(cur<1||cur>9||b[cur]){
                    return false;
                }
                b[cur] = true;
            }
        }

        int sum = grid[r][c] + grid[r][c+1] + grid[r][c+2];

        for(int x=0;x<3;x++){
            if(grid[r+x][c] + grid[r+x][c+1] + grid[r+x][c+2] != sum) return false;
        }

        for(int y=0;y<3;y++){
            if(grid[r][c+y] + grid[r+1][c+y] + grid[r+2][c+y] != sum) return false;
        }

        if(grid[r][c] + grid[r+1][c+1] + grid[r+2][c+2] != sum) return false;
        if(grid[r+2][c] + grid[r+1][c+1] + grid[r][c+2] != sum) return false;

        return true;
    }
}