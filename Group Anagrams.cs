public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, IList<string>>();
        
        foreach (var str in strs) {
            var chs = str.ToCharArray();
            Array.Sort(chs);
            var sortedStr = new String(chs);
            if (map.ContainsKey(sortedStr)) {
                map[sortedStr].Add(str);
            } else {
                map[sortedStr] = new List<string>() {str};
            }
        }
        
        var result = new List<IList<string>>();
        foreach (var value in map.Values) {
            result.Add(value);
        }
        return result;
    }
}
