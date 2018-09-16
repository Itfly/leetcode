public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        var n = nums.Length;
        var min = nums[n - 1];
        var max = nums[0];
        var end = -1;
        var beg = 0;
        for (var i = 1; i < n; i++) {
            max = Math.Max(max, nums[i]);
            min = Math.Min(min, nums[n - 1 - i]);
            if (nums[i] < max) {
                end = i;
            }
            if (nums[n - 1 - i] > min) {
                beg = n - 1 - i;
            }
        }
        
        return end - beg + 1;
    }
}
https://leetcode.com/problems/shortest-unsorted-continuous-subarray/discuss/103062/C++-Clean-Code-2-Solution-Sort-O(NlgN)-and-max-min-vectors-O(N)
