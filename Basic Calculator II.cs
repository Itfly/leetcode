public class Solution {
    public int Calculate(string s) {
        var result = 0;
        var curRes = 0;
        var num = 0;
        char op = '+';
        
        for (var i = 0; i < s.Length; ++i) {
            var c = s[i];
            if (c >= '0' && c <= '9') {
                num = num * 10 + c - '0';
            }
            if (c == '+' || c == '-' || c == '*' || c == '/' || i == s.Length - 1) {
                switch (op) {
                    case '+': curRes += num; break;
                    case '-': curRes -= num; break;
                    case '*': curRes *= num; break;
                    case '/': curRes /= num; break;
                }
                if (c == '+' || c == '-' || i == s.Length - 1) {
                    result += curRes;
                    curRes = 0;
                }
                op = c;
                num = 0;
            } 
        }
        return result;

    }
}

// Use stack
public class Solution {
    private static readonly HashSet<char> ops = new HashSet<char>() {'+', '-', '*', '/'};
    public int Calculate(string s) {
        var stack = new Stack<int>();
        var num = 0;
        var op = '+';
        for (var i = 0; i < s.Length; i++) {
            var ch = s[i];
            if (ch >= '0' && ch <= '9') {
                num = num * 10 + ch - '0';
            }
            
            if (ops.Contains(ch) || i == s.Length - 1) {
                switch (op) {
                    case '+':
                        stack.Push(num);
                        break;
                    case '-':
                        stack.Push(-num);
                        break;
                    case '*':
                        var operand1 = stack.Pop();
                        stack.Push(operand1 * num);
                        break;
                    case '/':
                        var operand2 = stack.Pop();
                        stack.Push(operand2 / num);
                        break;
                }
                op = ch;
                num = 0;
            }
        }
        
        var result = 0;
        while (stack.Count > 0) {
            result += stack.Pop();    
        }
        
        return result;
    }
}
