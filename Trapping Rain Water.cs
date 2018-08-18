public class Solution {
    public int Trap(int[] height) {
        var result = 0;        
        var leftMax = 0;
        var rightMax = 0;
        var i = 0;
        var j = height.Length - 1;
        
        // The water trapped at any element = min( max_left, max_right) – arr[i]
        while (i <= j) {
            if (height[i] < height[j]) {
                if (height[i] > leftMax) {
                    leftMax = height[i];
                } else {
                    result += leftMax - height[i];
                }
                i++;
            } else {
                if (height[j] > rightMax) {
                    rightMax = height[j];
                } else {
                    result += rightMax - height[j];
                }
                j--;
            }
        }
        
        return result;
    }
}
