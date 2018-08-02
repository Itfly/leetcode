public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        var operators = new List<string>() {"+", "-", "*", "/"};
        foreach (var token in tokens) {
            if (operators.Contains(token)) {
                var right = stack.Pop();
                var left = stack.Pop();
                stack.Push(Operate(left, right, token));
            } else {
                stack.Push(Convert.ToInt32(token));
            }
        }
        
        return stack.Pop();
    }
    
    private int Operate(int left, int right, string token) {
        switch (token) {
            case "+": return left + right;
            case "-": return left - right;
            case "*": return left * right;
            case "/": return left / right;
            default: return -1;
        }
    }
}
