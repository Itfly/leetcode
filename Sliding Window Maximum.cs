public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums == null || nums.Length == 0) {
            return new int[0];
        }
        
        var result = new int[nums.Length - k + 1];
        var queue = new LinkedList<int>();
        for (var i = 0; i < nums.Length; i++) {
            // Remove the first (old) value in the queue if it's out of the current window
            if (queue.Count > 0 && queue.First.Value == i - k) {
                queue.RemoveFirst();
            }
            
            // The queue is sorted and the last one is minimum value's index of the current window.
            // And the new one is in the tail side.
            while (queue.Count > 0 && nums[queue.Last.Value] < nums[i]) {
                queue.RemoveLast();
            }
            
            queue.AddLast(i);
            
            if (i + 1 >= k) {
                result[i + 1 - k] = nums[queue.First.Value];
            }
        }
        
        return result;
    }
}
