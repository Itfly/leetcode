public class Solution {
    public int CompareVersion(string version1, string version2) {
        var level1 = version1.Split('.');
        var level2 = version2.Split('.');
        
        for (var i = 0; i < Math.Max(level1.Length, level2.Length); i++) {
            var v1 = i < level1.Length ? Convert.ToInt32(level1[i]) : 0;
            var v2 = i < level2.Length ? Convert.ToInt32(level2[i]) : 0;
            if (v1 < v2) {
                return -1;
            } else if (v1 > v2) {
                return 1;
            }
        }
        
        return 0;
    }
}
