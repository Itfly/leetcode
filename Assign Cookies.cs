public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        
        var i = 0;
        for (var j = 0; i < g.Length && j < s.Length; j++) {
            if (g[i] <= s[j]) {
                i++;
            }
        }
        
        return i;
    }
}
