public class Solution {
    // Binary Search
    public int[] Intersection(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        
        var result = new List<int>();
        for (var i = 0; i < nums1.Length; i++) {
            if (i == 0 || nums1[i] != nums1[i - 1]) {
                if (Array.BinarySearch(nums2, nums1[i]) >= 0) {
                    result.Add(nums1[i]);
                }
            }
        }
        
        return result.ToArray();
    }
    
    // HashSet
    public int[] Intersection(int[] nums1, int[] nums2) {
        var set1 = new HashSet<int>();
        foreach (var num in nums1) {
            set1.Add(num);
        }
        
        var set2 = new HashSet<int>();
        foreach (var num in nums2) {
            if (set1.Contains(num)) {
                set2.Add(num);
            }   
        }
        
        return set2.ToArray();
    }
}
