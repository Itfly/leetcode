public class Solution {
// binary search + dp
    public int SmallestDistancePair(int[] nums, int k) {
        Array.Sort(nums);
        var n = nums.Length;
        var left = 0;
        var right = nums[n - 1] - nums[0];
        while (left < right) {
            var mid = left + (right - left) / 2;
            var cnt = 0;
            var start = 0;
            for (var i = 0; i < n; i++) {
                while (start < n && nums[i] - nums[start] > mid) {
                    start++;
                }
                cnt += i - start;
            }
            
            if (cnt < k) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        
        return right;
    }
}

// http://zxi.mytechroad.com/blog/divide-and-conquer/leetcode-719-find-k-th-smallest-pair-distance/
