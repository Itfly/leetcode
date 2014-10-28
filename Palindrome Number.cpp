class Solution {
public:
    int length(int x, long long &divide) {
        int n = 0;
        divide = 1;
        do {
            x /= 10;
            n++;
            divide *= 10;
        } while (x > 0);
        divide /= 10;
        return n;
    }
    bool isPalindrome(int x) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (x < 0) return false;
        long long divide;
        int n = length(x, divide);
        int msr, lsr;
        while (n > 1) {
            msr = (x / divide) % 10;
            lsr = x % 10;
            if (msr != lsr) return false;
            divide /= 100;
            x /= 10;
            n -= 2;
        }
        
        return true;
    }
};