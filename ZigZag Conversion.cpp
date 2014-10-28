class Solution {
public:
    string convert(string s, int nRows) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function    
        if (nRows == 1) return s;
        
        int block = 2 * nRows - 2;
        int n = s.length();
        string buf;
        for (int i = 0; i < nRows; i++) {
            int index = i;
            while (index < n) {
                buf += s[index];
                index += block;
                if (i != 0 && i != nRows - 1 && index - 2 * i < n) {
                    buf += s[index-2*i];
                }
            }
        }
        return buf;
    }
};