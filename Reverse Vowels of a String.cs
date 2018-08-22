public class Solution {
    private static readonly char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
    
    public string ReverseVowels(string s) {
        if (s == null || s.Length <= 1) {
            return s;
        }    
        
        var i = 0;
        var j = s.Length - 1;
        var chs = s.ToCharArray();
        while (i < j) {
            while (i < j && !vowels.Contains(chs[i])) {
                i++;
            }
            while (i < j && !vowels.Contains(chs[j])) {
                j--;
            }
            
            var ch = chs[i];
            chs[i++] = chs[j];
            chs[j--] = ch;
        }
        
        return new string(chs);
    }
}
