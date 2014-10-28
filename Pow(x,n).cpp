class Solution {
public:
    double power(double x, int n) {
        if (n == 0) return 1;
        else if (n == 1) return x;
        
        double res = power(x, n/2);
        res *= res;
        if (n & 0x1) {
            res *= x;
        }
        return res;
    }
    double pow(double x, int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        
        bool sign = n >= 0;
        n = abs(n);
        
        double res = power(x, n);
        return sign ? res : 1/res;
    }
};


class Solution {
public:
    double power(double x, unsigned n) {
        double res = 1;
        while (n > 0) {
            if ((n&0x1) == 1) {
                res *= x;
            }
            x *= x;
            n >>= 1;
        }
        return res;
    }
    double pow(double x, int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (n == 0) {
            return 1;
        }
        
        bool sign = n > 0;
        n = abs(n);
        double res = power(x, n);
        return sign ? res : 1/res;
    }
};