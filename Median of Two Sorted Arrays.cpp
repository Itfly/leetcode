class Solution {
public:
    double MedianofThree(int a, int b, int c) {
        if (a < b) return b;
        else if (a > c) return c;
        else return a;
    }
    
    double MedianofFour(int a, int b, int c, int d) {
        if (a < c) {
            if (b < d) return (b+c) / 2.0;
            else return (c+d) / 2.0;
        } else {
            if (b < d) return (a+b) / 2.0;
            else return (a+d) / 2.0;
        }
    }
    double MedianSortedArrays(int A[], int m, int B[], int n) {
        if (m == 0) {
            if ((n & 0x1) == 1) 
                return B[n/2];
            else 
                return (B[n/2] + B[n/2-1]) / 2.0;
        }
        
        if (m == 1) {
            if (n == 1) 
                return (*A + *B) / 2.0;
            if ((n & 0x1) == 1) 
                return ( B[n/2] + MedianofThree(A[0], B[n/2-1], B[n/2+1])) / 2.0;
            else 
                return MedianofThree(A[0], B[n/2-1], B[n/2]);
        }
        
        if (m == 2) {
            if (n == 2) 
                return MedianofFour(A[0], A[1], B[0], B[1]);
            if ((n & 0x1) == 1) 
                return MedianofThree(B[n/2], min(A[0], B[n/2+1]), max(A[1], B[n/2-1]));
            else
                return MedianofFour(B[n/2-1], B[n/2], min(B[n/2+1], A[0]), max(B[n/2-2], A[1]));
        }
        
        int minRemoved, midA = m/2, midB = n/2;
        if (A[midA] < B[midB]) {
            if ((m & 0x1) == 0) midA--;
            minRemoved = min(midA, n-midB-1);
            return MedianSortedArrays(A+minRemoved, m-minRemoved, B, n-minRemoved);
        } else {
            if ((n & 0x1) == 0) midB--;
            minRemoved = min(m-midA-1, midB);
            return MedianSortedArrays(A, m-minRemoved, B+minRemoved, n-minRemoved);
        }
    }
    double findMedianSortedArrays(int A[], int m, int B[], int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (m <= n) {
            return MedianSortedArrays(A, m, B, n);
        } else {
            return MedianSortedArrays(B, n, A, m);
        }
    }
};