namespace LeetCode._3100_1;

public class Solution {
    public int MaxBottlesDrunk(int numBottles, int numExchange) {
        int ans = numBottles;
        int empty = numBottles;
        while (empty >= numExchange){
            ans++;
            empty -= numExchange - 1;
            numExchange++;
        }
        return ans;
    }
}