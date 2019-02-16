public class Solution {
  // Time Limit Exceeded
    public int MaxSumSubmatrix(int[,] matrix, int k) {
        var m = matrix.GetLength(0);
        var n = matrix.GetLength(1);
        var areas = new int[m, n];
        
        for (var i = 0; i < m; i++) {
            var temp = 0;
            for (var j = 0; j < n; j++) {
                temp += matrix[i, j];
                areas[i, j] += temp;
                if (i > 0) {
                    areas[i, j] += areas[i - 1, j];
                }
            }
        }
        
        var result = int.MinValue;
        for (var i = 0; i < m; i++) {
            for (var j = 0; j < n; j++) {
                for (var p = i; p < m; p++) {
                    for (var q = j; q < n; q++) {
                        var area = areas[p, q];
                        if (i >= 1) {
                            area -= areas[i - 1, q];
                        }
                        if (j >= 1) {
                            area -= areas[p, j - 1];
                        }
                        if (i >= 1 && j >= 1) {
                            area += areas[i - 1, j - 1];
                        }
                        
                        if (area == k) {
                            return k;
                        }
                        if (area < k) {
                            result = Math.Max(area, result);
                        }
                    }
                }
            }
        }
        
        return result;
    }
}

// Another better csharp solution: https://leetcode.com/problems/max-sum-of-rectangle-no-larger-than-k/discuss/83607/C-solution-both-row-and-col-use-Kadane's-algo

// Since csharp do not have treeset or set like java and c++, here's a c++ version:
class Solution {
public:
int maxSumSubmatrix(vector<vector<int>>& matrix, int k) {
    if (matrix.empty()) return 0;
    int row = matrix.size(), col = matrix[0].size(), res = INT_MIN;
    for (int l = 0; l < col; ++l) {
        vector<int> sums(row, 0);
        for (int r = l; r < col; ++r) {
            for (int i = 0; i < row; ++i) {
                sums[i] += matrix[i][r];
            }
            
            // Find the max subarray no more than K 
            set<int> accuSet;
            accuSet.insert(0);
            int curSum = 0, curMax = INT_MIN;
            for (int sum : sums) {
                curSum += sum;
                set<int>::iterator it = accuSet.lower_bound(curSum - k);
                if (it != accuSet.end()) curMax = std::max(curMax, curSum - *it);
                accuSet.insert(curSum);
            }
            res = std::max(res, curMax);
        }
    }
    return res;
}
};

// Or:



