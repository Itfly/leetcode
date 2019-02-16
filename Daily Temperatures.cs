public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        var waits = new int[temperatures.Length];
        
        for (var i = 0; i < temperatures.Length; i++) {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i]) {
                var peek = stack.Pop();
                waits[peek] = i - peek;
            }
            stack.Push(i);
        }

        return waits;
    }
}
