// namespace LeetCode._0_1000;
//
// using System.Text;
//
// public class Solution(){
//     public string FractionToDecimal(int numerator, int denominator)
//     { 
//         //Deal if numerator == 0 
//         if (numerator == 0) 
//             return "0";
//
//         StringBuilder result = new StringBuilder();
//         
//         // Check if negative
//         if (numerator < 0 ^ denominator < 0){
//             result.Append('-');
//         }
//         long num = Math.Abs((long)numerator);
//         long den = Math.Abs((long)denominator);
//         
//         // Upper part 
//         result.Append(num/den);
//
//         num %= den;
//         if (num == 0)
//             return result.ToString();
//
//
//         
//         result.Append('.');
//         Dictionary<long, int> map = new Dictionary<long, int>();
//         
//         // Lower part
//         while (num != 0){
//             if (map.ContainsKey(num)){
//                 int index = map[num];
//                 result.Insert(index, '(');
//                 result.Append(')');
//                 break;
//                 
//             }
//             
//             map.Add(num, result.Length);
//             num *= 10;
//             result.Append(num / den);
//             num %= den;
//         }
//         
//         return result.ToString();  // Return the final result.
//     }
// }
//
//
