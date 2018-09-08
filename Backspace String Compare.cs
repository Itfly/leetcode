public class Solution {
    public bool BackspaceCompare(string S, string T) {
        var i = S.Length - 1;
        var j = T.Length - 1;
        while (i >= 0 || j >= 0) {
            if (GetValidChar(S, ref i) != GetValidChar(T, ref j)) {
                return false;
            }
        }
        
        return true;
    }
    
    private char GetValidChar(string str, ref int index) {
        var cnt = 0;
        while (index >= 0) {
            var ch = str[index--];
            if (ch == '#') {
                cnt++;
            } else {
                if (cnt > 0) {
                    cnt--;
                } else {
                    return ch;
                }
            }
        }
        
        return '#';
    }
}
