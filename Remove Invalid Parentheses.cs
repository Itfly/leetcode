// https://github.com/tongzhang1994/Facebook-Interview-Coding/blob/master/301.%20Remove%20Invalid%20Parentheses.java

public class Solution {
    private static readonly char[] positiveChars = new char[] {'(', ')'};
    private static readonly char[] negativeChars = new char[] {')', '('};
    
    public IList<string> RemoveInvalidParentheses(string s) {
        var result = new List<string>();
        DFS(result, s, positiveChars, 0, 0);
        return result;
    }
    
    private void DFS(IList<string> result, string s, char[] parentheses, int current, int lastRemoved) {
        var count = 0;
        for (var i = current; i < s.Length; i++) {
            if (s[i] == parentheses[0]) {
                count++;
            } else if (s[i] == parentheses[1]) {
                count--;
            }
            
            // invalid parenthese, each (not consecutive) p[1] from lastRemoved to i to make valid
            if (count < 0) {
                for (var j = lastRemoved; j <= i; j++) {
                    if (s[j] == parentheses[1] && (j == lastRemoved || s[j - 1] != s[j])) {
                        var temp = s.Remove(j, 1);
                        DFS(result, temp, parentheses, i, j);
                    }
                }
                return; // important
            }
        }
        
        var reversed = Reverse(s);
        if (parentheses[0] == '(') {
            DFS(result, reversed, negativeChars, 0, 0);
        } else {
            result.Add(reversed);
        }
    }
    
    private static string Reverse(string s)
    {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
