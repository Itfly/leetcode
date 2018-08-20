public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        var closet = int.MaxValue;
        for (var i = 0; i < nums.Length - 2; i++) {
            if (i != 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            
            var j = i + 1;
            var k = nums.Length - 1;
            while (j < k) {
                var sum = nums[i] + nums[j] + nums[k];
                if (sum == target) {
                    return target;
                } else if (sum < target) {
                    j++;
                } else {
                    k--;
                }
                
                if (closet == int.MaxValue || Math.Abs(sum - target) < Math.Abs(closet - target)) {
                    closet = sum;
                }
            }
        }
        
        return closet;
    }
}
