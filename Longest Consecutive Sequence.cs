public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        var set = new HashSet<int>(nums);
        var result = 1;
        foreach (var num in nums) {
            if (set.Contains(num)) {
                var cnt = 1;
                var x = num - 1;
                while (set.Contains(x)) {
                    set.Remove(x--);
                    cnt++;
                }
                x = num + 1;
                while (set.Contains(x)) {
                    set.Remove(x++);
                    cnt++;
                }
                
                result = Math.Max(result, cnt);
            }
        }
        
        return result;
    }
}
