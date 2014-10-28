class Solution {
public:
    void permute(vector<vector<int> > &result, vector<int> &num, int k) {
        if (k == num.size()) {
            result.push_back(num);
            return;
        }
        
        for (int i = k; i < num.size(); i++) {
            swap(num[i], num[k]);
            permute(result, num, k+1);
            swap(num[i], num[k]);
        }
    }
    vector<vector<int> > permute(vector<int> &num) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > result;
        permute(result, num, 0);
        return result;
    }
};