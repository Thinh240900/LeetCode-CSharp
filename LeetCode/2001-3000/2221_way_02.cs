namespace LeetCode._2221_2;

public class Solution {
    public int TriangularSum(int[] nums) {

        int[] dp(int[] process)
        {
            if (process.Length == 1) return process;
            int[] temp = new int[process.Length - 1];
            for (int i = 0; i < process.Length - 1; i++){
                temp[i] = (process[i] + process[i + 1]) % 10;
            }
            return dp(temp);
        }
        
        return dp(nums)[0];
    }
}