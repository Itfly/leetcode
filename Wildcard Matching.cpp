class Solution {
public:
    bool isMatch(const char *s, const char *p) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (!s && !p) return true;
        const char *starP = NULL, *starS = NULL;
        
        while (*s != '\0') {
            if (*p == '?' || *s == *p) {
                s++;
                p++;
            } else if (*p == '*') {
                while (*p == '*') p++;
                if (*p == '\0') return true;
                starP = p;
                starS = s;
                
            } else if ((*p == '\0' || *p != *s) && starP) {
                p = starP;
                s = ++starS;
            } else {
                return false;
            }
            
        }
        
        while (*p != '\0') {
            if (*p++ != '*') return false;
        }
        return true;
    }
};