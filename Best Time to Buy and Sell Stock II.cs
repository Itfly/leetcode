public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 0) {
            return 0;
        }
        
        var buy = prices[0];
        var sell = buy;
        var profit = 0;
        for (var i = 1; i < prices.Length; i++) {
            if (prices[i] > prices[i - 1]) {
                sell = prices[i];
            } else {
                profit += sell - buy;
                buy = prices[i];
                sell = buy;
            }
        }
        
        return profit + sell - buy;
    }
}
