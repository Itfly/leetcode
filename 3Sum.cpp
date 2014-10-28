class Solution {
public:
    vector<vector<int> > threeSum(vector<int> &num) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > result;
        int n = num.size();
        int i, j, k;
        sort(num.begin(), num.end());
        
        for (i = 0; i < n-2; i++) {
            if (i != 0 && num[i] == num[i-1]) continue;
            
            j = i + 1;
            k = n - 1;
            while (j < k) {
                
                int sum = num[j] + num[k] + num[i];
                if (sum == 0) {
                    if (k == n-1 || num[k] != num[k+1]) {
                        vector<int> tmp(3);
                        tmp[0] = num[i];
                        tmp[1] = num[j];
                        tmp[2] = num[k];
                        result.push_back(tmp);    
                    }
                    j++;
                    k--;
                } else if (sum < 0) {
                    j++;
                } else {
                    k--;
                }
            }
        }
        
        return result;
    }
};