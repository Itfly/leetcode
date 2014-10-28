class Solution {
public:
    int largestRectangleArea(vector<int> &height) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        stack<int> s;
        int i = 0, ret = 0;
        height.push_back(0);
        
        while (i < height.size()) {
            if (s.empty() || height[s.top()] <= height[i]) {
                s.push(i++);       
            } else {
                int k = s.top();
                s.pop();
                ret = max(ret, height[k] * (s.empty() ? i : i - 1 - s.top()));
                
            }
        }
        return ret;
    }
};