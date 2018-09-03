public class Solution {
    public bool Makesquare(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return false;
        }
        var sum = 0;
        foreach (var num in nums) {
            sum += num;
        }
        if (sum % 4 != 0) {
            return false;
        }
        var side = sum / 4;
        foreach (var num in nums) {
            if (num > side) {
                return false;
            }
        }
        
        nums = nums.OrderByDescending(d => d).ToArray();
        
        return DFS(nums, (1 << nums.Length) - 1, 0, 0, 0, side);
        
    }
    
    private bool DFS(int[] nums, int used, int acc, int start, int count, int target) {
        if (count == 3) {
            return true;
        } else if (acc == target) {
            return DFS(nums, used, 0, 0, count + 1, target);
        }
        
        for (var i = start; i < nums.Length; i++) {
            if ((used & (1 << i)) != 0 && acc + nums[i] <= target) {
                used ^= 1 << i;
                if (DFS(nums, used, acc + nums[i], i + 1, count, target)) {
                    return true;
                }
                used |= 1 << i;
            }
        }
        
        return false;
    }
}
