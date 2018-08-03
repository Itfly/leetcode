public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        var map = new Dictionary<string, int>();
        for (var i = 0; i < list1.Length; i++) {
            map[list1[i]] = i;
        }
        
        var min = int.MaxValue;
        List<string> result = null;
        for (var i = 0; i < list2.Length; i++) {
            if (map.ContainsKey(list2[i])) {
                var sum = map[list2[i]] + i;
                if (min > sum) {
                    min = sum;
                    result = new List<string>() {list2[i]};
                } else if (min == sum) {
                    result.Add(list2[i]);
                }
            }
        }
        
        return result.ToArray();
    }
}
