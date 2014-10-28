class Solution {
public:
    void subsets(vector<int> &S, int k, vector<int> &sub, vector<vector<int> > &result) {
        int n = S.size();
        if (k == n) {
            result.push_back(sub);
            return;
        }
       
        sub.push_back(S[k]);
        subsets(S, k+1, sub, result);
        sub.pop_back();
        subsets(S, k+1, sub, result);
    }
    vector<vector<int> > subsets(vector<int> &S) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        sort(S.begin(), S.end());
        vector<vector<int> > result;
        if (S.size() == 0) {
            result.push_back(vector<int>());
            return result;
        }
        
        vector<int > sub;
        subsets(S, 0, sub, result);
        
        return result;
    }
};

//great idea
/*
vector<vector<int> > subsets(vector<int> &S) {
    sort(S.begin(), S.end());
    vector<vector<int> > v(1);
    for(int i = 0; i < S.size(); ++i) {
        int j = v.size();
        while(j-- > 0) {
            v.push_back(v[j]);
            v.back().push_back(S[i]);
        }
    }
    return v;
}
*/