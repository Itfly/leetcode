public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var n = nums.Length;
        if (n < 3) {
            return n;
        }
        
        int i = 0, j = 1, cnt = 1;
        while (j < n) {
            if (nums[i] == nums[j]) {
                cnt++;
                if (cnt > 2) {
                    while (j < n && nums[i] == nums[j]) {
                        j++;
                    }
                    cnt = 1;
                } else {
                    nums[++i] = nums[j++];
                }
            } else {
                nums[++i] = nums[j++];
                cnt = 1;
            }
        }
        
        return i + 1;
    }
}

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var n = nums.Length;
        if (n < 3) {
            return n;
        }
        
        int i = 1;
        var isTwice = false;
        for (var j = 1; j < n; j++) {
            if (nums[j] == nums[j - 1] && !isTwice) {
                isTwice = true;
                nums[i++] = nums[j];
            } else if (nums[j] != nums[j - 1]) {
                isTwice = false;
                nums[i++] = nums[j];
            }
        }
        
        return i;
    }
}
