public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        var n = nums.Length;
        var len = new int[n];
        var cnt = new int[n];
        var max = 0;
        var result = 0;
        
        for (var i = 0; i < n; i++) {
            len[i] = cnt[i] = 1;
            for (var j = 0; j < i; j++) {
                if (nums[i] > nums[j]) {
                    if (len[i] == len[j] + 1) {
                        cnt[i] += cnt[j];
                    } else if (len[i] < len[j] + 1) {
                        len[i] = len[j] + 1;
                        cnt[i] = cnt[j];
                    }
                    
                }
            }
            
            if (max == len[i]) {
                result += cnt[i];
            } else if (max < len[i]) {
                max = len[i];
                result = cnt[i];
            }
        }
        
        return result;
    }
}
