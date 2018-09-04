public class Solution {
    public int ArrayNesting(int[] nums) {
        var result = 0;
        var count = 0;
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] < 0) {
                continue;
            }
            
            var j = i;
            var cnt = 0;
            while (nums[j] != -1) {
                cnt++;
                var temp = nums[j];
                nums[j] = -1; // or swap(j, nums[j]) to sort the cycle. 
                j = temp;
            }
            result = Math.Max(result, cnt);
            count += cnt;
            if (count == nums.Length) {
                break;
            }
        }
        
        return result;
    }
}
