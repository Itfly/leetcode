class Solution {
public:
    int longestValidParentheses(string s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        stack<int> st;
        int last = -1;
        int longest = 0;
        for (int i = 0; i < s.length(); i++) {
            if (s[i] == '(') {
                st.push(i);
            } else {
                if (st.empty()) {
                    last = i;
                } else {
                    st.pop();
                    if (st.empty()) {
                       longest = max(longest, i - last); 
                    } else {
                       longest = max(longest, i - st.top());
                    }
                }
            }
        }
        
        return longest;
    }
};