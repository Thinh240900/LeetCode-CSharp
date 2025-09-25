// namespace LeetCode._0_1000;
//
// public class Solution(){
//     public int MinimumTotal(IList<IList<int>> triangle)
//     {
//         int n = triangle.Count;
//         IList<int> dp = new List<int>();
//         dp = triangle[n - 1];
//         for (int i = n - 2; i >= 0; i--){
//             for (int j = 0; j <= i; j++){
//                 dp[j] = Math.Min(dp[j], dp[j + 1]) + triangle[i][j];
//             }
//         }
//         return dp[0];
//     }
// }
//
//
