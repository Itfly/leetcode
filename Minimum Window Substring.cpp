class Solution {
public:
    string minWindow(string S, string T) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int ns = S.length();
        int nt = T.length();
        int num[256] = {0};
        int need[256] = {0};
        int count = 0;
        int minWin = INT_MAX, minBegin, minEnd;
        
        for (int i = 0; i < nt; i++) {
            num[T[i]]++;
        }
        
        for (int beg = 0, end = 0; end < ns; end++) {
            if (num[S[end]] == 0) continue;
            
            need[S[end]]++;
            if (need[S[end]] <= num[S[end]]) {
                count++;
            }
            
            if (count == nt) {
                while (num[S[beg]] == 0 || need[S[beg]] > num[S[beg]]) {
                    if (need[S[beg]] > num[S[beg]]) {
                        need[S[beg]]--;
                    }
                    beg++;
                    
                }
                
                if (minWin > end-beg+1) {
                    minWin = end-beg+1;
                    minBegin = beg;
                    minEnd = end;
                }
            }
        }
        
        if (count < nt) {
            return "";
        } else {
            return S.substr(minBegin, minWin);
        }
        
    }
};