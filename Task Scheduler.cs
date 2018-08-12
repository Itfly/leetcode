public class Solution {
    // analysis: https://leetcode.com/explore/interview/card/top-interview-questions-medium/114/others/826/discuss/104500/Java-O(n)-time-O(1)-space-1-pass-no-sorting-solution-with-detailed-explanation
    public int LeastInterval(char[] tasks, int n) {
        var counter = new int[26];
        var max = 0;
        var cnt = 0;
        foreach (var task in tasks) {
            var index = task - 'A';
            counter[index]++;
            if (max == counter[index]) {
                cnt++;
            } else if (max < counter[index]) {
                max = counter[index];
                cnt = 1;
            }
        }
        
        return Math.Max(tasks.Length, (max - 1) * (n + 1) + cnt);
    }
}
        
