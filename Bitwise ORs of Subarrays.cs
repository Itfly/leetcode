public class Solution {
    public int SubarrayBitwiseORs(int[] A) {
        var set = new HashSet<int>();
        var contiguousSub = new HashSet<int>();
        foreach (var num in A) {
            var temp = new HashSet<int>();
            temp.Add(num);
            foreach (var val in contiguousSub) {
                temp.Add(val | num);
            }
            contiguousSub = temp;
            set.UnionWith(temp);
        }
        
        return set.Count;
    }
}
