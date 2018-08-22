public class NumArray {
    private int[] sums;
    
    public NumArray(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return;
        }
        
        sums = new int[nums.Length + 1];
        sums[0] = 0;
        for (var i = 0; i < nums.Length; i++) {
            sums[i + 1] = sums[i] + nums[i];
        }
    }
    
    public int SumRange(int i, int j) {
        return sums[j + 1] - sums[i];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */
