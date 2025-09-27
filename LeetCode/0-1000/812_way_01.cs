// namespace LeetCode._0_1000;
//
// using System.Text;
//
//
// public class Solution {
//     public float LargestTriangleArea(int[][] nums)
//     {
//         int n = nums.Length;
//         float result = 0;
//         for (int i = 0; i < n-2; i++){
//             for (int j = i + 1; j < n-1; j++){
//                 for (int k = j + 1; k < n; k++){
//                     int[] P = nums[i];
//                     int[] Q = nums[j];
//                     int[] R = nums[k];
//                     float area = 0.5f * (float)Math.Abs(P[0]*Q[1] + Q[0]*R[1] + R[0]*P[1]-P[1]*Q[0] - Q[1]*R[0] - R[1]*P[0]);
//                     if (area > result) result = area;
//                 }
//             }
//         }
//         return result;
//     }
// }