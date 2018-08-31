public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        var result = new List<string>();
        foreach (var word in words) {
            if (IsPermutation(word, pattern)) {
                result.Add(word);
            }
        }
        return result;
    }
    
    private bool IsPermutation(string word, string pattern) {
        if (word.Length != pattern.Length) {
            return false;
        }
        
        var map1 = new Dictionary<char, char>();
        var map2 = new Dictionary<char, char>();
        for (var i = 0; i < pattern.Length; i++) {
            if (map1.ContainsKey(pattern[i])) {
                if (map1[pattern[i]] != word[i]) {
                    return false;
                }
            } else {
                map1[pattern[i]] = word[i];
            }
            if (map2.ContainsKey(word[i])) {
                if (map2[word[i]] != pattern[i]) {
                    return false;
                }
            } else {
                map2[word[i]] = pattern[i];
            }
        }
        
        return true;
    }
}
