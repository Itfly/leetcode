class Solution {
private:
    int target, n;
    vector<int> candidates;
public:
    void combinationSum(vector<vector<int> > &result, vector<int> path, int k, int sum) {
        if (sum > target) return;
        if (sum == target) {
            result.push_back(path);
            return;
        }
        
        for (int i = k; i < n; i++) {
            path.push_back(candidates[i]);
            combinationSum(result, path, i, sum+candidates[i]);
            path.pop_back();
            
        }
    }
    vector<vector<int> > combinationSum(vector<int> &candidates, int target) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > result;
        sort(candidates.begin(), candidates.end());
        this->target = target;
        this->candidates = candidates;
        this->n = candidates.size();
        
        vector<int> path;
        
        combinationSum(result, path, 0, 0);
        
        return result;
    }
};