public class Solution {
    // Analysis: http://bangbingsyb.blogspot.com/2014/11/leetcode-container-with-most-water.html
    public int MaxArea(int[] height) {
        var i = 0; 
        var j = height.Length - 1;
        var result = 0;
        while (i < j) {
            var temp = (j - i) * Math.Min(height[i], height[j]);
            if (temp > result) {
                result = temp;
            }
            
            if (height[i] > height[j]) {
                j--;
            } else if (height[i] < height[j]) {
                i++;
            } else {
                i++;
                j--;
            }
        }
        
        return result;
    }
}
