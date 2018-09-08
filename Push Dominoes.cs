public class Solution {
    public string PushDominoes(string dominoes) {
        if (string.IsNullOrEmpty(dominoes)) {
            return dominoes;
        }
        
        var chs = dominoes.ToCharArray();
        var l = -1;
        var r = -1;
        for (var i = 0; i <= chs.Length; i++) {
            if (i == chs.Length || chs[i] == 'R') {
                if (r > l) {
                    while (++r < i) {
                        chs[r] = 'R';
                    }
                }
                r = i;
            } else if (chs[i] == 'L') {
                if (l >= r) {  // l > r or l==r(l=-1&&r=-1)
                    while (++l < i) {
                        chs[l] = 'L';
                    }
                } else {
                    l = i;
                    var low = r + 1; 
                    var high = l - 1;
                    while (low < high) {
                        chs[low++] = 'R';
                        chs[high--] = 'L';
                    }
                }
            }
        }
        
        return new string(chs);
    }
}
