public class Solution {
    public int StrStr(string haystack, string needle) {
        if (haystack == null || string.IsNullOrEmpty(needle)) {
            return 0;
        }
        
        if (needle.Length > haystack.Length) {
            return -1;
        }
        
        for (var i = 0; i <= haystack.Length - needle.Length; i++) {
            var j = 0;
            for (j = 0; j < needle.Length; j++) {
                if (haystack[i + j] != needle[j]) {
                    break;
                }
            }
            if (j == needle.Length) {
                return i;
            }
        }
        return -1;
    }
    
    // TODO: add KMP
}
