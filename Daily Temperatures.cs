public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        var waits = new int[temperatures.Length];
        
        for (var i = 0; i < temperatures.Length; i++) {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i]) {
                waits[stack.Peek()] = i - stack.Peek();
                stack.Pop();
            }
            
            stack.Push(i);
        }
        return waits;
    }
}
