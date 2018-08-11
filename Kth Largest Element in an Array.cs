public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        return GetKth(nums, nums.Length - k + 1, 0, nums.Length - 1);
    }
    
    private int GetKth(int[] nums, int k, int start, int end) {
        var pivot = nums[end];
        var i = start;
        var j = end;
        while (i < j) {
            if (nums[i++] > pivot) {
                swap(nums, --i, --j);
            }
        }
        swap(nums, i, end);
        
        var cnt = i - start + 1;
        if (k == cnt) {
            return pivot;
        } else if (k < cnt) {
            return GetKth(nums, k , start, i - 1);
        } else {
            return GetKth(nums, k - cnt, i + 1, end);
        }
    }
    
    private void swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
