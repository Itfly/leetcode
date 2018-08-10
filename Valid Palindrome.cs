public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) {
            return true;
        }
        
        var i = 0;
        var j = s.Length - 1;
        while (i < j) {
            while (i < j && !Char.IsLetterOrDigit(s[i])) {
                ++i;
                
            }
            while (i < j && !Char.IsLetterOrDigit(s[j])) {
                --j;
            }
            if (s[i] == s[j] || (Math.Abs(s[i] - s[j]) == ('a' - 'A') && Char.IsLetter(s[i]) && Char.IsLetter(s[j]))) {
                ++i;
                --j;
            } else {
                return false;
            }
            
        }
        return true;
    }
}
