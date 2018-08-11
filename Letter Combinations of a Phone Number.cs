public class Solution {
    private static readonly string[] map
        = new string[] {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
    
    public IList<string> LetterCombinations(string digits) {
        var result = new List<string>(); 
        if (string.IsNullOrEmpty(digits)) {
            return result;
        }
        
        result.Add("");
        foreach (var ch in digits) {
            var list = new List<string>();
            var letters = map[ch - '0'];
            foreach (var ans in result) {
                foreach (var letter in letters) {
                    list.Add(ans + letter);
                }
            }
            result = list;
        }
        return result;
    }
}
