public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        if (nums == null || nums.Length < 3) {
            return result;
        }
        
        Array.Sort(nums);
        
        for (var i = 0; i < nums.Length - 2; i++) {
            if (i != 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            
            var j = i + 1;
            var k = nums.Length - 1;
            while (j < k) {
                var sum = nums[i] + nums[j] + nums[k];
                if (sum == 0) {
                    if (k == nums.Length - 1 || nums[k] != nums[k + 1]) {
                        result.Add(new List<int>{nums[i], nums[j], nums[k]});
                    }
                    j++;
                    k--;
                } else if (sum < 0) {
                    j++;
                } else {
                    k--;
                }
            }
        }
        
        return result;
    }
}
