public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int>(); // store index
        int result = 0;
        
        var i = 0;
        while (i < heights.Length || stack.Count > 0) {
            if (stack.Count == 0 || i < heights.Length && heights[stack.Peek()] <= heights[i]) {
                // the value of bottom index is minimum when scanning the heights.
                stack.Push(i++);
            } else {
                var j = stack.Pop();  // the minimum value's index is poped  at last.
                result = Math.Max(result, heights[j] * (stack.Count == 0 ? i : i - 1 - stack.Peek()));
            }
        }
        
        return result;
    }
}
