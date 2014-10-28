class Solution {
public:
    int maxProfit(vector<int> &prices) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int len = prices.size();
        if (len == 0) return 0;
        
        vector<int> preprofit(len);
        vector<int> postprofit(len);
        int maxprofit;
        
        int buy = prices[0];
        preprofit[0] = 0;
        for (int i = 1; i < len; i++) {
            if (prices[i] < buy) {
                buy = prices[i];
            }
            preprofit[i] = max(preprofit[i-1], prices[i] - buy);
        }
        
        int sell = prices[len-1];
        maxprofit = preprofit[len-1];
        for (int i = len-2; i >= 0; i--) {
            if (prices[i] > sell) {
                sell = prices[i];
            }
            postprofit[i] = max(postprofit[i+1], sell - prices[i]);

            maxprofit = max(maxprofit, preprofit[i] + postprofit[i+1]);
        }
        
        return maxprofit;
    }
};