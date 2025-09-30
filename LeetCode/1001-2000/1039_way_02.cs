namespace LeetCode._1039_2;

public class Solution {
    private int n;
    private int[] values;
    private IDictionary<int, int> memo = new Dictionary<int, int>();
    private int count = 0;
    public int MinScoreTriangulation(int[] values)
    {
        this.n = values.Length;
        this.values = values;
        int result = DP(0, n - 1); 
        Console.WriteLine("Number of calls: " + count);
        return result;
    }

    private int DP(int start, int end)
    {
        this.count = this.count + 1 ;
        if (start + 2 > end) return 0;
        if (start + 2 == end)
            return values[start] * values[start + 1] * values[end];

        int key = start * n + end;
        if (!memo.ContainsKey(key)){
            int minScore = int.MaxValue;
            for (int k = start + 1; k < end; k++){
                minScore = Math.Min(
                minScore, 
                DP(start, k) + DP(k, end)
                             + 
                values[start] * values[k] * values[end]);
            }
            memo[key] = minScore;
        }
        
        return memo[key];

    }

}
