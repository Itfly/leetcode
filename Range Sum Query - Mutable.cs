public class NumArray {
    
    private int[] btree;
    private int[] nums;

    public NumArray(int[] nums) {
        this.nums = nums;
        btree = new int[nums.Length + 1];
        
        for (var i = 0; i < nums.Length; i++) {
            Add(i + 1, nums[i]);
        }
    }
    
    public void Update(int i, int val) {
        Add(i + 1, val - nums[i]);
        nums[i] = val;
    }
    
    public int SumRange(int i, int j) {
        return PreSum(j + 1) - PreSum(i);
    }
    
    private void Add(int i, int val) {
        for (var j = i; j < btree.Length; j = j + (j & (-j))) {
            btree[j] += val;
        }
    }
    
    private int PreSum(int i) {
        var sum = 0;
        for (var j = i; j >= 1; j = j - (j & (-j))) {
            sum += btree[j];
        }
        return sum;
    }
}

// https://www.programcreek.com/2014/04/leetcode-range-sum-query-mutable-java/
// Binary indexed tree: https://www.youtube.com/watch?v=v_wj_mOAlig&index=2&list=PLZ_pfgKiIBrTdUKevYPsS0c7jAhgkPb6e

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(i,val);
 * int param_2 = obj.SumRange(i,j);
 */
