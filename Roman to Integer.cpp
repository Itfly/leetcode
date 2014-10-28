class Solution {
public:
    int romanToInt(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (s.length() == 0) return 0;
        map<char, int> Roman_Integer;
        int sum = 0;
        Roman_Integer['I'] = 1;
        Roman_Integer['V'] = 5;
        Roman_Integer['X'] = 10;
        Roman_Integer['L'] = 50;
        Roman_Integer['C'] = 100;
        Roman_Integer['D'] = 500;
        Roman_Integer['M'] = 1000;
        
        sum = Roman_Integer[s[0]];
        for (int i = 1; i < s.length(); i++) {
            if (Roman_Integer[s[i]] <= Roman_Integer[s[i-1]]) {
                sum += Roman_Integer[s[i]];
            } else {
                sum += (Roman_Integer[s[i]] - 2 * Roman_Integer[s[i-1]]);
            }
        }
        
        return sum;
    }
};