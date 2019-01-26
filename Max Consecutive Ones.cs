public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int cnt = 0;
        int max = 0;
        foreach (var num in nums) {
            if (num == 1) {
                cnt++;
                max = Math.Max(max, cnt);
            } else {
                cnt = 0;
            }
        }
        
        return max;
    }
}