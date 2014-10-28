class Solution {
public:
    
    vector<vector<int> > subsetsWithDup(vector<int> &S) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
    
       sort(S.begin(), S.end());
       vector<vector<int> > v(1);
       int start = 0;
       for(int i = 0; i < S.size(); ++i) {
            //if (i != 0 && S[i] == S[i-1]) continue;
            int n = v.size();
            
           for (int j = start; j < n; j++){
                v.push_back(v[j]);
                v.back().push_back(S[i]);
            }
            if (i < S.size() -1 && S[i+1] == S[i]) {
                start = n;
            } else {
                start = 0;
            }
            
        }
        return v;      
    }
};