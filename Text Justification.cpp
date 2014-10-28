class Solution {
    string getLine(vector<string> &words, int begin, int end, int spaces, int L, bool isLastLine) {
        string s;
        int n = end - begin;
        for (int i = 0; i < n; ++i) {
            s += words[begin + i];
            if (n == 1 || i == n-1) break;
            int space = isLastLine ? 1 : (spaces / (n-1) + (i < (spaces % (n-1)) ? 1 : 0));
            s.append(space, ' ');
        }

        if (s.size() < L) s.append(L - s.size(), ' ');
        return s;
    }

public:
    vector<string> fullJustify(vector<string> &words, int L) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<string> ret;
        int start = 0, len = 0;
        for (int i = 0; i < words.size(); ++i) {
            if (len + words[i].length() + (i - start) > L) {
                ret.push_back(getLine(words, start, i, L - len, L, false));
                start = i;
                len = 0;
            } 
            len += words[i].size();
        }
        ret.push_back(getLine(words, start, words.size(), L - len, L, true));
        return ret;
    }

    
};