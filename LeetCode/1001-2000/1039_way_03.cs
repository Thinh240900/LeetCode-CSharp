namespace LeetCode._1039_3;

public class Solution {
    public int MinScoreTriangulation(int[] values)
    {
        int n =  values.Length;
        int[,] dp = new int[n, n];

        for (int end = 2; end < n; end++){
            for (int start = end - 2; start >= 0; start--){
                dp[start,end] = int.MaxValue;
                int temp = values[start] * values[end];
                for (int k = end - 1; k > start; k--){
                    dp[start, end] = int.Min(
                        dp[start, end],
                        dp[start, k] + dp[k, end] + 
                        temp * values[k] 
                    );
                }
            }
        }

        return dp[0,n - 1];
    }

}
