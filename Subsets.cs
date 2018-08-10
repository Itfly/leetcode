public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var results = new List<IList<int>>();
        results.Add(new List<int>());
        
        foreach (var num in nums) {
            var i = results.Count;
            while (i-- > 0) {
                var list = new List<int>(results[i]);
                list.Add(num);
                results.Add(list);       
            }
        }
        
        return results;
    }
}
