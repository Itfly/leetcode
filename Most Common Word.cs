public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        var map = new Dictionary<string, int>();
        var bannedSet = new HashSet<string>(banned);
        var nonLetters = new HashSet<char> {' ', '!', '?', '\'', ',', ';', '.'}; 
        
        var sb = new StringBuilder();
        var i = 0;
        var max = 0;
        while (i <= paragraph.Length) {
            if (i == paragraph.Length || nonLetters.Contains(paragraph[i])) {
                if (sb.Length > 0) {
                    var word = sb.ToString().ToLower();
                    if (!bannedSet.Contains(word)) {
                        if (map.ContainsKey(word)) {
                            map[word]++;
                        } else {
                            map[word] = 1;
                        }
                        max = Math.Max(max, map[word]);
                    }
                    sb = new StringBuilder();  // or sb.Clear()
                }
            } else {
                sb.Append(paragraph[i]);
            }
            i++;
        }
        
        return map.FirstOrDefault(x => x.Value == max).Key;
    }
}
