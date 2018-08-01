public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var m = nums1.Length;
        var n = nums2.Length;
        
        if ((m + n) % 2 != 0) {
            return (double) findKth(nums1, nums2, 0, m - 1, 0, n - 1, (m + n) / 2);
        } else {
            return (findKth(nums1, nums2, 0, m - 1, 0, n - 1, (m + n) / 2 - 1) + findKth(nums1, nums2, 0, m - 1, 0, n - 1, (m + n) / 2)) * 0.5;
        }
    }
    
    private int findKth(int[] nums1, int[] nums2, int start1, int end1, int start2, int end2, int k) {
        var len1 = end1 - start1 + 1;
        var len2 = end2 - start2 + 1;
        
        if (len1 == 0) {
            return nums2[start2 + k];
        }  
        if (len2 == 0) {
            return nums1[start1 + k];
        }
        if (k == 0) {
            return nums1[start1] > nums2[start2] ? nums2[start2] : nums1[start1];
        }
        
        var mid1 = len1 * k / (len1 + len2);
        var mid2 = k - mid1 - 1;  
        mid1 += start1;
        mid2 += start2;
        if (nums1[mid1] > nums2[mid2]) {
            k -= (mid2 - start2 + 1);
            end1 = mid1;
            start2 = mid2 + 1;
        } else {
            k -= (mid1 - start1 + 1);
            end2 = mid2;
            start1 = mid1 + 1;
        }
        
        return findKth(nums1, nums2, start1, end1, start2, end2, k);
    }
}
