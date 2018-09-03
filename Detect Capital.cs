public class Solution {
    public bool DetectCapitalUse(string word) {
        if (word.Length <= 1) {
            return true;
        }
        
        var cnt = 0;
        foreach (var ch in word) {
            if (IsCapital(ch)) {
                cnt++;
            }
        }
        
        if (cnt == 0) {
            return true;
        }
        if (cnt == 1) {
            return IsCapital(word[0]);
        }
        return cnt == word.Length;
    }
    
    private bool IsCapital(char ch) {
        return ch >= 'A' && ch <= 'Z';
    }
}
