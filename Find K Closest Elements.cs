public class Solution {
    // binary-search for where the resulting elements start in the array. It's the first index i so that arr[i] is better than arr[i+k] (with "better" meaning closer to or equally close to x).
    // https://leetcode.com/problems/find-k-closest-elements/discuss/106419/olog-n-java-1-line-ologn-k-ruby
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        var left = 0;
        var right = arr.Length - k;
        while (left < right) {
            var mid = left + (right - left) / 2;
            if (x - arr[mid] > arr[mid + k] - x) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        
        var elements = new List<int>();
        for (var i = left; i < left + k; i++) {
            elements.Add(arr[i]);
        }
        return elements;
    }
}
