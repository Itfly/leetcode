public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        var wordSet = new HashSet<string>(wordDict);
        var dp = new IList<string>[s.Length + 1];
        dp[0] = new List<string>();
        for (var i = 0; i < s.Length; i++) {
            if (dp[i] == null) {
                continue;
            }
            
            for (var j = i + 1; j <= s.Length; j++) {
                var sub = s.Substring(i, j - i);
                if (wordSet.Contains(sub)) {
                    if (dp[j] == null) {
                        dp[j] = new List<string>();
                    }
                    dp[j].Add(sub);
                }
            }
        }
        
        var result = new List<string>();
        if (dp[s.Length] != null) {
            DFS(dp, result, "", s.Length);
        }
        return result;
    }
    
    private void DFS(IList<string>[] strs, IList<string> result, string sentence, int i) {
        if (i == 0) {
            result.Add(sentence);
            return;
        }
        if (strs[i] == null) {
            return;
        }
        
        foreach (var word in strs[i]) {
            var str = sentence == "" ? word : word + " " + sentence;
            DFS(strs, result, str, i - word.Length);
        }
    }
}
