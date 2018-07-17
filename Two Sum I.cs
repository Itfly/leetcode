public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var map = new Dictionary<int, int>();
        for(var i = 0; i < numbers.Length; i++) {
            var num = target - numbers[i];
            if (map.ContainsKey(num)) {
                return new int[2] {map[num], i + 1};
            } else {
                map[numbers[i]] = i + 1;
            }
        }

        return new int[2];
    }
}
