public class Solution {
    // Anaysis: https://leetcode.com/explore/interview/card/top-interview-questions-hard/121/dynamic-programming/862/discuss/75927/Share-my-thinking-process
    public int MaxProfit(int[] prices) {
        int sell = 0, prev_sell = 0, buy = int.MinValue, prev_buy;
        foreach (var price in prices) {
            prev_buy = buy;
            buy = Math.Max(prev_sell - price, prev_buy);
            prev_sell = sell;
            sell = Math.Max(prev_buy + price, prev_sell);
        }
        return sell;
    }
}
