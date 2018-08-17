public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        var counts = new int[nums.Length];
        var indices = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++) {
            indices[i] = i;
        }
        
        MergeSort(nums, indices, counts, 0, nums.Length - 1);
        return counts.ToList();
    }
    
    private void MergeSort(int[] nums, int[] indices, int[] counts, int start, int end) {
        if (start >= end) {
            return;
        }
        
        var mid = start + (end - start) / 2;
        MergeSort(nums, indices, counts, start, mid);
        MergeSort(nums, indices, counts, mid + 1, end);
        Merge(nums, indices, counts, start, end);
    }
    
    private void Merge(int[] nums, int[] indices, int[] counts, int start, int end) {
        var mid = start + (end - start) / 2;
        var p1 = start;
        var p2 = mid + 1;
        var newIndices = new int[end - start + 1];
        
        var p3 = 0;
        while (p1 <= mid && p2 <= end) {
            if (nums[indices[p1]] > nums[indices[p2]]) {
                newIndices[p3] = indices[p2++];
            } else {
                newIndices[p3] = indices[p1];
                counts[indices[p1++]] += p2 - mid - 1;
            }
            p3++;
        }
        
        while (p1 <= mid) {
            newIndices[p3++] = indices[p1];
            counts[indices[p1++]] += end - mid;
            
        }
        while (p2 <= end) {
            newIndices[p3++] = indices[p2++];
        }
        
        for (var i = start; i <= end; i++) {
            indices[i] = newIndices[i - start];
        }
    }
}

// Other solutions (BST,BS): https://kennyzhuang.gitbooks.io/algorithms-collection/content/count_of_smaller_numbers_after_self.html
