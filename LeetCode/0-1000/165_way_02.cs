// namespace LeetCode._0_1000;
//
// public class Solution(){
//     public int CompareVersion(string version1, string version2)
//     {
//       string[] arr1 = version1.Split(new char[] { '.' });
//       var arr2 = version2.Split(new char[] { '.' });
//       
//       int n = arr1.Length;
//       int m = arr2.Length;
//       
//       for (int i = 0; i < Math.Max(n, m); i++){ 
//           int num1 =  i < n ? int.Parse(arr1[i]) : 0 ;
//           int num2 =  i < m ? int.Parse(arr2[i]) : 0 ;
//           if (num1 > num2) return 1;
//           if (num1 < num2) return -1;
//           
//       }
//       return 0;
//     }
// }
//
//
//
