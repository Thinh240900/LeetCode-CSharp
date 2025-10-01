namespace LeetCode._1518_1;

public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int drinked = numBottles;
        int empty = numBottles;
        numBottles = empty / numExchange;
        empty -= numBottles * numExchange;

        while (numBottles > 0){
            drinked += numBottles;
            empty += numBottles;
            numBottles = empty / numExchange;
            empty -= numBottles * numExchange;  
        }
        
        
        return drinked;
    }
}