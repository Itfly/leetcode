class Solution {
public:
    int threeSumClosest(vector<int> &num, int target) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int closet = 10000;
        int i, j, k;
        int n = num.size();
        sort(num.begin(), num.end());
        for (i = 0; i < n-2; i++) {
            if (i != 0 && num[i] == num[i-1]) continue;
            
            j = i + 1;
            k = n - 1;
            while (j < k) {
                
                int sum = num[j] + num[k] + num[i];
                if (abs(sum - target) < abs(closet - target)) {
                    	closet = sum;
                }
                if (sum == target) {
                		return target;
                } else if (sum < target) {
                    j++;
                } else {
                    k--;
                }
            }
        }
        return closet;
    }
};