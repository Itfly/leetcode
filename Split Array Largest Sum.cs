public class Solution {
    // Binary search
    public int SplitArray(int[] nums, int m) {
        long left = 0;
        long right = 0;
        foreach (var num in nums) {
            left = Math.Max(left, num);
            right += num;
        }
        
        while (left < right) {
            var mid = left + (right - left) / 2;
            if (MinGroups(nums, mid) > m) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        return (int) right;
    }
    
    private int MinGroups(int[] nums, long limit) {
        long sum = 0;
        int n = 1;
        foreach (var num in nums) {
            if (sum + num > limit) {
                sum = num;
                ++n;
            } else {
                sum += num;
            }
        }
        
        return n;
    }
}

// http://zxi.mytechroad.com/blog/dynamic-programming/leetcode-410-split-array-largest-sum/
