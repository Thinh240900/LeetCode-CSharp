namespace LeetCode._11_01;

public class Solution {
    public int MaxArea(int[] height) {
        int left = 0, right = height.Length - 1;
        int maxArea = 0;
        while (left < right){
            if (height[left] < height[right]){
                if ((right - left) * height[left] > maxArea)
                    maxArea = (right - left) * height[left];
                left++;
            }else if (height[left] > height[right]){
                if ((right - left) * height[right] > maxArea)
                    maxArea = (right - left) * height[right];
                right--;
            }
            else{
                if ((right - left) * height[left] > maxArea)
                    maxArea = (right - left) * height[left];
                left++;
            }
        }
        return maxArea;
    }
}