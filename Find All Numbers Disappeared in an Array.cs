public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var i = 0;
        while (i < nums.Length) {
            if (nums[i] != nums[nums[i] - 1]) {
                var temp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = temp;
            } else {
                i++;
            }
        }
        
        var result = new List<int>();
        for (i = 0; i < nums.Length; i++) {
            if (nums[i] != i + 1) {
                result.Add(i + 1);
            }
        }
        
        return result;
    }
}
