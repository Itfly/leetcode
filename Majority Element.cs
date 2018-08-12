public class Solution {
    public int MajorityElement(int[] nums) {
        var majority = 0;
        var count = 0;
        foreach (var num in nums) {
            if (count == 0) {
                majority = num;
                count++;
            } else {
                count += majority == num ? 1 : -1;
            }
        }
        return majority;
    }
    
    // other solutions: https://leetcode.com/explore/interview/card/top-interview-questions-medium/114/others/824/discuss/51612/6-Suggested-Solutions-in-C++-with-Explanations
}
