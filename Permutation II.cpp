class Solution {
public:
    void permute(vector<int> &num, int k, int n, vector<vector<int> > &result) {
        if (k == n) {
            result.push_back(num);
            return;
        }
        
        unordered_set<int> unique;
        for (int i = k; i < n; i++) {
            if (unique.find(num[i]) == unique.end()) {
                swap(num[i], num[k]);
                permute(num, k+1, n, result);
                swap(num[i], num[k]);
                unique.insert(num[i]);
            }
        }
    }
    vector<vector<int> > permuteUnique(vector<int> &num) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > result;
        permute(num, 0, num.size(), result);
        return result;
    }
};


class Solution {
public:
    bool nextPermutation(vector<int> &num) {
        vector<int>::iterator i, j, k;
        i = num.end() - 2;
        j = num.end() - 1;
        k = num.end() - 1;
        while (i >= num.begin() && *i >= *j) {
            i--;
            j--;
        }
        
        if (i < num.begin()) {
            return false;
        }
        
        while (*i >= *k) {
            k--;
        }
        swap(*i, *k);
        reverse(j, num.end());
        
        return true;
    }
    vector<vector<int> > permuteUnique(vector<int> &num) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        sort(num.begin(), num.end());
        vector<vector<int> > result;
        do {
            result.push_back(num);
        } while (nextPermutation(num));
        
        return result;
    }
};