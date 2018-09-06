public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var result = new List<string>();
        if (nums == null || nums.Length == 0) {
            return result;
        } 
        
        for (var i = 0; i < nums.Length; i++) {
            var start = nums[i];
            while (i < nums.Length - 1 && nums[i + 1] - nums[i] == 1) {
                i++;
            }
            
            if (start == nums[i]) {
                result.Add(nums[i].ToString());
            } else {
                result.Add(start + "->" + nums[i]);
            }
        }
        
        return result;
    }
}
