public class Solution {
    public IList<string> FizzBuzz(int n) {
        var result = new List<string>();
        for (var i = 1; i <= n; i++) {
            var sb = new StringBuilder();
            var multipled = false;
            if (i % 3 == 0) {
                sb.Append("Fizz");
                multipled = true;
            }
            if (i % 5 == 0) {
                sb.Append("Buzz");
                multipled = true;
            }
            if (!multipled) {
                sb.Append(i);
            }
            result.Add(sb.ToString());
        }
        
        return result;
    }
}

