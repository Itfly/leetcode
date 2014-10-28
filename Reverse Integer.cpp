class Solution {
public:
    int reverse(int x) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int sign = 1;
        int result = 0;
        int least = 0;
        
        if (x < 0) {
            sign = -1;
            x = -x;
        }
        
        while (x > 0) {
            least = x % 10;
            x /= 10;
            result = result * 10 + least;
        }
        
        return result * sign;
        
    }
};