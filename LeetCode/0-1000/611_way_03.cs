// namespace LeetCode._0_1000;
//
// using System.Text;
//
//
// public class Solution {
//     public int TriangleNumber(int[] nums) {
//         Array.Sort(nums);
//
//         int result = 0;
//         int n = nums.Length;
//
//         for (int i = n-1; i >= 0; i--){
//             if (nums[i] == 0) continue;
//             int right = i - 1;
//             int left = 0;
//             while (left < right){
//                 if (nums[right] + nums[left] > nums[i]){
//                     result += right - left;
//                     right--;
//                 }
//                 else{
//                     left++;
//                 }
//             }
//         }
//         return result;
//     }
//
//     private int FindRight(int[] nums, int target)
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
// }