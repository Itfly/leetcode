class Solution {
public:
    bool isMatch(const char *s, const char *p) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function   
        if (p[0] == '\0') return s[0] == '\0';
        
        if (p[1] != '*') {
            return (s[0] == p[0] || p[0] == '.' && s[0] != '\0') && isMatch(s+1, p+1);
        } else {
            return (s[0] == p[0] || p[0] == '.' && s[0] != '\0') && isMatch(s+1, p) || isMatch(s, p+2);
        }
    
    }
};


class Solution {
public:
    bool isMatch(const char *s, const char *p) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function    
        if (*p == '\0') return *s == '\0';
        
        if (*(p+1) != '*') {
            return (*p == *s || (*p == '.' && *s != '\0')) && isMatch(s+1, p+1);
        }
        
        while (*p == *s || (*p == '.' && *s != '\0')) {
            if (isMatch(s, p+2)) return true;
            s++;
        }
        return isMatch(s, p+2);
    }
};