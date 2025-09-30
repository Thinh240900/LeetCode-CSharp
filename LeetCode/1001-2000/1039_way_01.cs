namespace LeetCode._1039;

public class Solution {
    public int MinScoreTriangulation(int[] values)
    {
        int n = values.Length;
        int[,] dp = new int[n,n];

        for (int i = n - 3; i >= 0; i--){
            for (int j = i + 2; j < n; j++){
                for (int k = i + 1; k < j; k++){
                    dp[i,j] = Math.Min(dp[i,j] != 0 ? dp[i,j] : int.MaxValue, dp[i,k] + dp[k,j] + values[i] * values[k] * values[j]);
                }
            }
        }

        return dp[0,n-1];
    }
}
