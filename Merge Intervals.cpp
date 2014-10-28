/**
 * Definition for an interval.
 * struct Interval {
 *     int start;
 *     int end;
 *     Interval() : start(0), end(0) {}
 *     Interval(int s, int e) : start(s), end(e) {}
 * };
 */
bool cmp(const Interval &a, const Interval &b) {
        return a.start < b.start;
    }
class Solution {
public:
    
    vector<Interval> merge(vector<Interval> &intervals) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (intervals.size() < 2) return intervals;
        
        vector<Interval> result;
        sort(intervals.begin(), intervals.end(), cmp);
        Interval cur = intervals[0];
        for (int i = 1; i < intervals.size(); i++) {
            Interval next = intervals[i];
            if (next.end > cur.end) {
                if (next.start <= cur.end) {
                    cur.end = next.end;
                } else {
                    result.push_back(cur);
                    cur = next;
                }
            }
        }
        result.push_back(cur);
        return result;
    }
};