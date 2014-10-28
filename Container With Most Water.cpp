class Solution {
public:
    int maxArea(vector<int> &height) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int i = 0, j = height.size() - 1;
        int res = 0, tmp;
        while (i < j) {
            tmp = (j - i) * min(height[i], height[j]);
            if (tmp > res) {
                res = tmp;
            }
            if (height[i] > height[j]) {
                j--;
            } else {
                i++;
            }
        }
        
        return res;
    }
};


Proved by contradiction:

Suppose the returned result is not the optimal solution. Then there must exist an optimal solution, say a container with a_ol and a_or (left and right respectively), such that it has a greater volume than the one we got. Since our algorithm stops only if the two pointers meet. So, we must have visited one of them but not the other. WLOG, let's say we visited a_ol but not a_or. When a pointer stops at a_ol, it won't move until

The other pointer also points to a_ol.
In this case, iteration ends. But the other pointer must have visited a_or on its way from right end to a_ol. Contradiction to our assumption that we didn't visit a_or.
The other pointer arrives at a value, say a_rr, that is greater than a_ol before it reaches a_or.
In this case, we does move a_ol. But notice that the volume of a_ol and a_rr is already greater than a_ol and a_or (as it is wider and heigher), which means that a_ol and a_or is not the optimal solution -- Contradiction!
Both cases arrive at a contradiction.

