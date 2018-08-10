public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var permutes = new List<IList<int>>();
        Permute(permutes, nums, 0);
        return permutes;
    }
    
    private void Permute(IList<IList<int>> permutes, int[] nums, int k) {
        if (k == nums.Length) {
            permutes.Add(new List<int>(nums));
            return;
        }
        
        for (var i = k; i < nums.Length; i++) {
            var temp = nums[i];
            nums[i] = nums[k];
            nums[k] = temp;
            
            Permute(permutes, nums, k + 1);
            
            nums[k] = nums[i];
            nums[i] = temp;
        }
    }
}
