public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        var n = 0;
        while (Math.Pow(minutesToTest / minutesToDie + 1, n) < buckets) {
            n++;
        }
        
        return n;
    }
}

// https://leetcode.com/problems/poor-pigs/discuss/166070/explaination
