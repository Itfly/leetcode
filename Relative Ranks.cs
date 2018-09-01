public class Solution {
    public string[] FindRelativeRanks(int[] nums) {
        var index = nums.Select((x, i) => new KeyValuePair<int, int>(x, i))
                .OrderByDescending(x => x.Key)
                .Select(x => x.Value).ToList();
        
        var result = new string[index.Count];
        for (var i = 0; i < index.Count; i++) {
            if (i == 0) {
                result[index[i]] = "Gold Medal";
            } else if (i == 1) {
                result[index[i]] = "Silver Medal";
            } else if (i == 2) {
                result[index[i]] = "Bronze Medal";
            } else {
                result[index[i]] = (i + 1).ToString();
            }
        }
        
        return result;
    }
}
