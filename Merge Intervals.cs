/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public IList<Interval> Merge(IList<Interval> intervals) {
        if (intervals == null || intervals.Count <= 1) {
            return intervals;
        }
        
        var result = new List<Interval>();
        intervals = intervals.OrderBy(i => i.start).ToList();
        var cur = intervals[0];
        for (var i = 1; i < intervals.Count; i++) {
            var next = intervals[i];
            if (next.end > cur.end) {
                if (next.start <= cur.end) {
                    cur.end = next.end;
                } else {
                    result.Add(cur);
                    cur = next;
                }
            }
        }
        result.Add(cur);
        
        return result;
    }
}
