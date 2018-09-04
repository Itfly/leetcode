public class Solution {
    public int ThirdMax(int[] nums) {
        var max = new long[3] {long.MinValue, long.MinValue, long.MinValue};
        foreach (var num in nums) {
            if (max.Contains(num)) {
                continue;
            }
            
            if (num > max[0]) {
                max[2] = max[1];
                max[1] = max[0];
                max[0] = num;
            } else if (num > max[1]) {
                max[2] = max[1];
                max[1] = num;
            } else if (num > max[2]) {
                max[2] = num;
            }
        }
        
        return (int) (max[2] == long.MinValue ? max[0] : max[2]);
    }
}
