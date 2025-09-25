// namespace LeetCode._0_1000;
//
// public class Solution(){
//     public int MinimumTotal(IList<IList<int>> triangle)
//     {
//         int n = triangle.Count;
//         Span<int> dp = stackalloc int[n + 1];
//
//         for (int i = 0; i <= n; i++){
//             dp[i] = int.MaxValue;
//         }
//         dp[1] = triangle[0][0];
//         for (int i = 1; i < n; i++){
//             for (int j = i + 1; j >= 1; j--){
//                 dp[j] = triangle[i][j - 1] + Math.Min(dp[j - 1], dp[j]);
//             }
//         }
//         int min = int.MaxValue;
//         for (int i = 1; i <= n; i++){
//             min = Math.Min(min, dp[i]);
//         }
//         return min;
//     }
// }
//
//
