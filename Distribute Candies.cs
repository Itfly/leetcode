public class Solution {
    public int DistributeCandies(int[] candies) {
        var set = new HashSet<int>();
        foreach (var candy in candies) {
            set.Add(candy);
        }
        
        return Math.Min(set.Count, candies.Length / 2);
    }
}
