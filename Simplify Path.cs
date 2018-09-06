public class Solution {
    public string SimplifyPath(string path) {
        var strs = path.Split('/');
        var stack = new Stack<string>();
        foreach (var str in strs) {
            if (str == "" || str == ".") {
                continue;
            }
            if (str == "..") {
                if (stack.Count > 0) {
                    stack.Pop();
                }
            } else {
                stack.Push("/" + str);
            }
        }
        
        if (stack.Count == 0) {
            return "/";
        }
        
        var sb = new StringBuilder();
        while (stack.Count > 0) {
            sb.Insert(0, stack.Pop());
        }
        
        return sb.ToString();
    }
}
