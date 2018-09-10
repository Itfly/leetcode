public class Solution {
    // https://leetcode.com/problems/minimum-moves-to-equal-array-elements/discuss/93817/It-is-a-math-question
    public int MinMoves(int[] nums) {
        var min = int.MaxValue;
        var sum = 0;
        foreach (var num in nums) {
            sum += num;
            min = Math.Min(min, num);
        }
        
        return sum - min * nums.Length;
    }
}
