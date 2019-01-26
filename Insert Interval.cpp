/**
 * Definition for an interval.
 * struct Interval {
 *     int start;
 *     int end;
 *     Interval() : start(0), end(0) {}
 *     Interval(int s, int e) : start(s), end(e) {}
 * };
 */
class Solution {
public:
    vector<Interval> insert(vector<Interval> &intervals, Interval newInterval) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<Interval> res;
        if (intervals.size() == 0) {
            res.push_back(newInterval);
            return res;
        }
        
        auto iter = intervals.begin();
        while (iter < intervals.end() && iter->end < newInterval.start) {
            res.push_back(*iter++);
        }
        if (iter < intervals.end()) {
            newInterval.start = min(iter->start, newInterval.start);
            //iter++;
        }
        
        while (iter < intervals.end() && iter->start <= newInterval.end) {
            newInterval.end = max(iter->end, newInterval.end);
            iter++;
        }
        res.push_back(newInterval);
        
        while (iter < intervals.end()) {
            res.push_back(*iter++);
        }
        
        
    }
};

// TODO: implement java/csharp version