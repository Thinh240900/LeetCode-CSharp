namespace LeetCode._2221_1;

public class Solution {
    public int TriangularSum(int[] nums) {
        int n = nums.Length;

        for (int i = 0; i < n; i++){
            for (int j = 0; j < n - i - 1; j++){
                nums[j] = (nums[j] + nums[j + 1]) % 10;
            }
        }
        
        return nums[0];
    }
}