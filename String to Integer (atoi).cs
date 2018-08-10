public class Solution {
    public int MyAtoi(string str) {
        str = str?.Trim();
        if (string.IsNullOrEmpty(str)) {
            return 0;
        }
        
        bool positive = true;
        var i = 0;
        if (str[0] == '+') {
            i++;
        } else if (str[0] == '-') {
            positive = false;
            i++;
        }
        
        long result = 0;
        var maxInt = (long) int.MaxValue + 1;
        while (i < str.Length && Char.IsDigit(str[i])) {
            result = result * 10 + str[i++] - '0';
            if (result > int.MaxValue) {
                return positive ? int.MaxValue : int.MinValue;
            }
        }
        if (!positive) {
            result = -result;
        }
        
        if (result > int.MaxValue) {
            return int.MaxValue;
        } else if (result < int.MinValue) {
            return int.MinValue;
        }
        
        return (int) result;
    }
}
