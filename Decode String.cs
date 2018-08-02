public class Solution {
    public string DecodeString(string s) {
        var nums = new Stack<int>();
        var strs = new Stack<StringBuilder>();
        var cnt = 0;
        var sb = new StringBuilder();
        foreach (var ch in s.ToCharArray()) {
            if (ch >= '0' && ch <= '9') {
                cnt = 10 * cnt + ch - '0';
            } else if (ch == '[') {
                nums.Push(cnt);
                strs.Push(sb);
                cnt = 0;
                sb = new StringBuilder();
            } else if (ch == ']') {
                var k = nums.Pop();
                var cur = strs.Pop();
                for (var i = 0; i < k; i++) {
                    cur.Append(sb);
                }
                sb = cur;
            } else {
                sb.Append(ch);
            }
        }
        
        return strs.Count == 0 ? sb.ToString() : strs.Peek().ToString();
    }
}
