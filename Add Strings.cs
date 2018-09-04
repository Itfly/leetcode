public class Solution {
    public string AddStrings(string num1, string num2) {
        if (num1 == null || num1.Length == 0) {
            return num2;
        }
        if (num2 == null || num2.Length == 0) {
            return num1;
        }
        
        var i = num1.Length - 1;
        var j = num2.Length - 1;
        var sb = new StringBuilder();
        var carray = 0;
        while (i >= 0 || j >= 0) {
            var sum = carray;
            if (i >= 0) {
                sum += num1[i--] - '0';
            }
            if (j >= 0) {
                sum += num2[j--] - '0';
            }
            carray = sum / 10;
            sb.Insert(0, (char) (sum % 10 + '0'));
        }
        if (carray > 0) {
            sb.Insert(0, (char) (carray + '0'));
        }
        
        return sb.ToString();
    }
}
