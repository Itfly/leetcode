class Solution {
public:
    int maxProfit(vector<int> &prices) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (prices.size() == 0) return 0;
        int buy, sell, profit = 0;
        buy = prices[0];
        sell = buy;
        for (int i = 1; i < prices.size(); i++) {
            if (prices[i] > prices[i-1]) {
                sell = prices[i];
            } else {
                profit += sell - buy;
                buy = prices[i];
                sell = buy;
            }
        }
        
        return profit + (sell - buy);
    }
};