public class Solution {
    public int FindLUSlength(string[] strs) {
        Array.Sort(strs, (x, y) => y.Length.CompareTo(x.Length));
        var dups = GetDuplicates(strs);
        for (var i = 0; i < strs.Length; i++) {
            if (!dups.Contains(strs[i])) {
                var j = 0;
                while (j < i) {
                   if(IsSubsequence(strs[j], strs[i])) {
                        break;
                    }
                    j++;
                }
                if (j == i) {
                    return strs[i].Length;
                }
            }
        } 
        
        return -1;
    }
    
    private bool IsSubsequence(string a, string b) {
        var i = 0;
        var j = 0;
        while (i < a.Length && j < b.Length) {
            if (a[i] == b[j]) {
                j++;
            }
            i++;
        }
        
        return j == b.Length;
    }
    
    private HashSet<string> GetDuplicates(string[] strs) {
        var set = new HashSet<string>();
        var dups = new HashSet<string>();
        foreach (var str in strs) {
            if (set.Contains(str)) {
                dups.Add(str);
            } else {
                set.Add(str);
            }
        }
        
        return dups;
    }
}
