public class Solution {
    public string[] UncommonFromSentences(string A, string B) {
        var map = new Dictionary<string, int>();
        var words = (A + " " + B).Split();
        foreach (var word in words) {
            map.TryGetValue(word, out var cnt);
            map[word] = cnt + 1;
        }
        
        var result = new List<string>();
        foreach (var key in map.Keys) {
            if (map[key] == 1) {
                result.Add(key);
            }
        }
        
        return result.ToArray();
    }
}
