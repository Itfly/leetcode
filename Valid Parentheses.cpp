class Solution {
public:
    bool isValid(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        stack<char> st;
        map<char,char> parenths;
    		parenths['('] = ')';
				parenths['['] = ']';
				parenths['{'] = '}';
        for (string::iterator iter = s.begin(); iter != s.end(); iter++) {
           if (*iter == '(' || *iter == '[' || *iter == '{') {
               st.push(*iter);
           } else {
               if (st.empty() || parenths[st.top()] != *iter) {
                   return false;
               }
               st.pop();
           }
           
        }
        return st.empty() ? true : false;
    }
};