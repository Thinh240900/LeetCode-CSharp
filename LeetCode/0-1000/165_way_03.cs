// namespace LeetCode._0_1000;
//
// public class Solution(){
//     public int CompareVersion(string version1, string version2)
//     {
//       int value1 = 0;
//       int value2 = 0;
//
//       for (int i = 0, j = 0; i < version1.Length || j < version2.Length;){
//           while (i < version1.Length && version1[i] != '.'){
//               value1 = value1 * 10 + (version1[i] - '0');
//               i++;
//           }
//           
//           while (j < version2.Length && version2[j] != '.'){
//               value2 = value2 * 10 + (version2[j] - '0');
//               j++;
//           }
//           
//           if (value1 > value2) return 1;
//           if (value1 < value2) return -1;
//           i++;
//           j++;
//           value1 = 0;
//           value2 = 0;
//       }
//       return 0;
//     }
// }
//
//
//
