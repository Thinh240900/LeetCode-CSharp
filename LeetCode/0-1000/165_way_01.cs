// namespace LeetCode._0_1000;
//
// public class Solution(){
//     public int CompareVersion(string version1, string version2)
//     {
//         string[] arr1 = version1.Split('.');
//         string[] arr2 = version2.Split('.');
//         for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++){
//             int num1 = int.Parse(arr1[i]);
//             int num2 = int.Parse(arr2[i]);
//             if (num1 > num2) return 1;
//             if (num1 < num2) return -1;
//         }
//         if (arr1.Length > arr2.Length){
//             for (int i = arr2.Length; i < arr1.Length; i++){
//                 if (int.Parse(arr1[i]) > 0) return 1;
//             }
//         }
//         else if (arr1.Length < arr2.Length){
//             for (int i = arr1.Length; i < arr2.Length; i++){
//                 if (int.Parse(arr2[i]) > 0) return -1;
//             }
//         }
//         return 0;
//     }
// }
//
//
