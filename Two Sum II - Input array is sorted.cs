public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers == null || numbers.Length < 2) {
            return new int[2];
        }
        
        var low = 0;
        var high = numbers.Length - 1;
        while (low < high) {
            var sum = numbers[low] + numbers[high];
            if (sum < target) {
                low++;
            } else if (sum > target) {
                high--;
            } else {
                return new int[2] {low + 1, high + 1};
            }
        }
        
        return new int[2];
    }
}
