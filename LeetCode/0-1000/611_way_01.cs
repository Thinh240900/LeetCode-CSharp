// namespace LeetCode._0_1000;
//
// using System.Text;
//
//
// public class Solution {
//     public int TriangleNumber(int[] nums) {
//         int[] sortedNums = nums.OrderBy(x => x).ToArray();
//
//         int result = 0;
//         int n = sortedNums.Length;
//
//         for (int i = 0; i < n - 2; i++){
//             if (sortedNums[i] == 0) continue;
//             int k = i + 2;
//             for (int j = i + 1; j < n - 1; j++){
//                 int target = sortedNums[i] + sortedNums[j];
//                 while (k < n && sortedNums[k] < target){
//                     k++;
//                 }
//                 result += k - j - 1;
//             }
//         }
//         return result;
//     }
//
//     private int FindLeft(int[] nums, int target)
//     {
//         int left = 0;
//         int right = nums.Length;
//         while (left < right){
//             int mid = (left + right) / 2;
//             if (nums[mid] < target){
//                 left = mid + 1;
//             }
//             else{
//                 right = mid;
//             }
//         }
//         return left;
//     }
//
//     private int FindRight(int[] nums, int target)
//     {
//         int left = 0;
//         int right = nums.Length;
//         while (left < right){
//             int mid = (left + right) / 2;
//             if (nums[mid] <= target){
//                 left = mid + 1;
//             }
//             else{
//                 right = mid;
//             }
//         }
//         return left;
//     }
// }