class Solution {
public:
    vector<vector<int> > fourSum(vector<int> &num, int target) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> >  result;
        int n = num.size();
        int i, j, k, t;
        sort(num.begin(), num.end());
        
        for (i = 0; i < n-3; i++) {
            if (i != 0 && num[i] == num[i-1]) continue;
            
            for (j = i+1; j < n-2; j++) {
                if (j != i+1 && num[j] == num[j-1]) continue;
                int tmp = num[i] + num[j];
                k = j + 1;
                t = n - 1;
                while (k < t) {
                    int sum = tmp + num[k] + num[t] - target;
                    if (sum == 0) {
                        if (t == n-1 || num[t] != num[t+1]) {
                            int sub[] = {num[i], num[j], num[k], num[t]};
                            result.push_back(vector<int>(sub, sub+4));
                        }
                        k++, t--;
                    } else if (sum < 0) {
                        k++;
                    } else {
                        t--;
                    }
                }
            }
        }
        return result;
    }
};