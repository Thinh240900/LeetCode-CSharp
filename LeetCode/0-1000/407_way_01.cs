namespace LeetCode._407_1;

public class Point() {
    public readonly int X;
    public readonly int Y;
    public readonly int Value;
    public Point(int x, int y, int value) : this()
    {
        this.X = x;
        this.Y = y;
        this.Value = value;
    }
}

public class Solution {
    public int TrapRainWater(int[][] heightMap)
    {
        int rows = heightMap.Length;
        int cols = heightMap[0].Length;
        int[,] visited = new int[rows, cols];
        PriorityQueue<Point, int> arrHeap = new PriorityQueue<Point, int>();

        for (int i = 0; i < cols; i++){
            visited[0, i] = 1;
            visited[rows - 1, i] = 1;
            arrHeap.Enqueue(new Point(0, i, heightMap[0][i]), heightMap[0][i]);
            arrHeap.Enqueue(new Point(rows - 1, i, heightMap[rows - 1][i]), heightMap[rows - 1][i]);
        }

        for (int i = 1; i < rows - 1; i++){
            visited[i, 0] = 1;
            visited[i, cols - 1] = 1;
            arrHeap.Enqueue(new Point(i, 0, heightMap[i][0]), heightMap[i][0]);
            arrHeap.Enqueue(new Point(i, cols - 1, heightMap[i][cols - 1]), heightMap[i][cols - 1]);
        }

        int[] directionsRow = [0, 0, -1, 1];
        int[] directionsCol = [-1, 1, 0, 0];

        int result = 0;
        while (arrHeap.Count > 0){
            Point currentPoint = arrHeap.Dequeue();
            int currentHeight = currentPoint.Value;
            int currentRow = currentPoint.X;
            int currentCol = currentPoint.Y;

            for (int i = 0; i < 4; i++){
                int newRow = currentRow + directionsRow[i];
                int newCol = currentCol + directionsCol[i];

                if (0 > newRow || newRow >= rows || 0 > newCol || cols <= newCol || visited[newRow, newCol] == 1)
                    continue;

                visited[newRow, newCol] = 1;
                if (currentHeight > heightMap[newRow][newCol]){
                    result += currentHeight - heightMap[newRow][newCol];
                    heightMap[newRow][newCol] = currentHeight; // Update the height of the current cell
                }
                arrHeap.Enqueue(new Point(newRow, newCol, heightMap[newRow][newCol]), heightMap[newRow][newCol]); // Add the new point to heap

            }
        }
        return result;
    }
}

