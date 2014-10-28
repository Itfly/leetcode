class Solution {
public:
    int jump(int A[], int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
      /*  int *dp = new int[n];
        dp[0] = 0;
        
        for (int i = 1; i < n; i++) {
            dp[i] = i;
            for (int k = 0; k < i; k++) {
                if (A[k] >= i-k) {
                    if (dp[i] > dp[k]+1) {
                        dp[i] = dp[k] + 1;
                    }
                }
            }
        }
        return dp[n-1];
    */
        int last = 0, cur = 0, steps = 0;
        for (int i = 0; i < n; i++) {
            if (i > last) {
                last = cur;
                steps++;
            }
            cur = max(cur, i + A[i]);
        }
        return steps;
    }
};

[][][][][][][][]
 ->>>
 	 >>>>>>>>>
 	 	 >>>>
 	 	 	>>>>>>>>	
 	 	 	  >>>>>
 	 	 	 	 >>>>>>>>
 	 	 	 	  >>>>>
 	 	 	 	 	 >>
 	 	 	 	 	   >>
 	 	 	 	 	 	