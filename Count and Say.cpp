class Solution {
public:
    string getNextCount(string str) {
        if (str == "") return "1";
        
        string result;
        for (int i = 0; i < str.length(); i++) {
            char ch = str[i];
            int cnt = 1;
            while (i < str.length() && ch == str[i+1]) {
                cnt++;
                i++;
            }
            result += (cnt + '0');
            result += ch;
        }
        return result;
    }
    string countAndSay(int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        string s = "";
        for (int i = 0; i < n; i++) {
            s = getNextCount(s);
        }
        
        return s;
    }
};