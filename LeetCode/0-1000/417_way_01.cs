namespace LeetCode._417_1;

public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        int rows = heights.Length;
        int cols = heights[0].Length;
        bool[,] pacific = new bool[rows, cols];
        bool[,] atlantic = new bool[rows, cols];
        int[] directions = [-1, 0, 1, 0, -1];


        void dfs(int x, int y, bool[,] visited)
        {
            visited[x, y] = true;
            for (int i = 0; i < 4; i++){
                int nx = x + directions[i];
                int ny = y + directions[i + 1];
                if (nx < 0 || nx >= rows || ny < 0 || ny >= cols || visited[nx,ny] || heights[nx][ny] < heights[x][y]) continue;
                dfs(nx, ny, visited);
            }
        }
        
        for (int i = 0; i < rows; i++){
            dfs(i, 0, pacific);
            dfs(i, cols - 1, atlantic);
        }
        
        for (int j = 0; j < cols; j++){
            dfs(0, j, pacific);
            dfs(rows - 1, j, atlantic);
        }
        
        List<IList<int>> result = new List<IList<int>>();
        
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                if (pacific[i, j] && atlantic[i, j]) result.Add(new List<int>{i, j});
            }
        }
        
        return result;
    }
}