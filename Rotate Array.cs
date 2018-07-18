public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums == null || nums.Length == 0) {
            return;
        }
        
        k = k % nums.Length;
        if (k == 0) {
            return;
        }
        
        var count = 0;
        for (var i = 0; count < nums.Length; i++) {
            var current = i;
            var num = nums[i];
            do {
                var next = (current + k) % nums.Length;
                
                var temp = nums[next];
                nums[next] = num;
                num = temp;
                
                current = next;
                count++;
            } while (current != i);
        }
    }
}

// Also can reverse the array, then reverse left and right.
