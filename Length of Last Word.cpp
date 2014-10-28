class Solution {
public:
    int lengthOfLastWord(const char *s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        string str = s;
        size_t found = str.find_last_not_of(" ");
        if (found != string::npos) {
            str.erase(found+1);
            found = str.find_last_of(" ");
            return str.substr(found+1).length();
        } else {
            return 0;
        }
    }
};