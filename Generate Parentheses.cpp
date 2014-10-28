class Solution {
public:
  //  void generagetParenthesis(int l, int r, int n, string &path, vector<string> & result) {
    void generateParenthesis(string path, vector<string> & result, int l, int r, int n) {
        if (l == n) {
            path.append(n-r, ')');    //如果path 改成string &path, 那就需要pop这些')'
            result.push_back(path);
            return;
        }
        
        generateParenthesis(path+'(', result, l+1, r, n);
        
        if (r < l) {
            generateParenthesis(path+')', result, l, r+1, n);
        }
        
    }
    vector<string> generateParenthesis(int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<string> result;
        string path;
        generateParenthesis(path, result, 0, 0, n);
        
        return result;
    }
};