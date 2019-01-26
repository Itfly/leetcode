public class Solution {
    // DFS
    public int FindTargetSumWays(int[] nums, int S) {
        int sum = 0;
        foreach (var num in nums) {
            sum += num;
        }
        if (sum < Math.Abs(S)) {
            return 0;
        }
        
        return DFS(nums, 0, S);
    }
    
    private int DFS(int[] nums, int i, int S) {
        if (i == nums.Length) {
            return S == 0 ? 1 : 0;
        }
        
        return DFS(nums, i + 1, S - nums[i]) + DFS(nums, i + 1, S + nums[i]);
    }
}

// TODO: use this opt:
/*
class Solution {
public:
    int findTargetSumWays(vector<int>& nums, int S) {
        unordered_map<int, int> dp;
        dp[0] = 1;
        for (int num : nums) {
            unordered_map<int, int> t;
            for (auto a : dp) {
                int sum = a.first, cnt = a.second;
                t[sum + num] += cnt;
                t[sum - num] += cnt;
            }
            dp = t;
        }
        return dp[S];
    }
};

 */