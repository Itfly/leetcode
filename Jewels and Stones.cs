public class Solution {
    public int NumJewelsInStones(string J, string S) {
        var set = new HashSet<char>();
        foreach (var ch in J) {
            set.Add(ch);
        }
        
        var sum = 0;
        foreach (var ch in S) {
            if (set.Contains(ch)) {
                ++sum;
            }
        }
        
        return sum;
    }
}
