public class Solution {
    private int[] nums;
    private static readonly Random random = new Random();

    public Solution(int[] nums) {
        this.nums = new int[nums.Length];
        nums.CopyTo(this.nums, 0);
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        var nums = new int[this.nums.Length];
        this.nums.CopyTo(nums, 0);
        return nums;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        var nums = Reset();
        var cnt = nums.Length;
        while (cnt > 0) {
            var randomIndex = random.Next(cnt--);
            var temp = nums[cnt];
            nums[cnt] = nums[randomIndex];
            nums[randomIndex] = temp;
        }
        
        return nums;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
