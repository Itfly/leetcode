class Solution {
public:
    vector<int> getNext(char *needle) {
        int i = 0, j = -1;
        vector<int> next(strlen(needle));
        next[0] = -1;
        
        while (i < strlen(needle)) {
            if (j == -1 || needle[i] == needle[j]) {
                i++;
                j++;
                next[i] = j;
            } else {
                j = next[j];
            }
        }
        return next;
    }
    char *strStr(char *haystack, char *needle) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int i = 0, j = 0;
        if (strlen(needle) == 0) return haystack;
        vector<int> next = getNext(needle);
        
        while (i < strlen(haystack) && j < strlen(needle)) {
            if (j == -1 || haystack[i] == needle[j]) {
                i++;
                j++;
            } else {
                j = next[j];
            }
        }
        
        if (j == strlen(needle)) {
            return haystack + i - j;
        } else {
            return NULL;
        }
        
    }
};