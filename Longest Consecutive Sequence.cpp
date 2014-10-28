class Solution {
public:
    int helper(unordered_set<int> &h, int x) {
        int cnt = 1;
        int t = x;
        while (h.find(t-1) != h.end()) {
            h.erase(--t);
            cnt++;
        }
        while (h.find(x+1) != h.end()) {
            h.erase(++x);
            cnt++;
        }
        return cnt;
    }

    int longestConsecutive(vector<int> &num) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int ret = 0;
        unordered_set<int> h(num.begin(), num.end());
        
        for (int i = 0; i < num.size(); i++) {
            if (h.find(num[i]) != h.end()) {
                ret = max(ret, helper(h, num[i]));
            }
        }
        return ret;
    }
};