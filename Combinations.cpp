class Solution {
public:
    void combine(vector<vector<int> > & result, vector<int> ans, int n, int k, int t) {
        if (k == 0) {
            result.push_back(ans);
            return;
        } else if (n - t < k) {
            return;
        }
        
        combine(result, ans, n, k, t+1);
        ans.push_back(t+1);
        combine(result, ans, n, k-1, t+1);
    }
    vector<vector<int> > combine(int n, int k) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > result;
        if (n == 0 || k == 0) return result;
        vector<int> ans;
        combine(result, ans, n, k, 0);
    }
};