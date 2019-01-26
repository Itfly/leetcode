public class Solution {
    public bool IsNumber(string s) {
        if (string.IsNullOrEmpty(s)) {
            return false;
        }
        
        var start = 0;
        var end = s.Length;
        while (start < end && s[start] == ' ') {
            start++;
        }
        if (start < end && (s[start] == '+' || s[start] == '-')) {
            start++;
        }
        bool isNum = false;
        while (start < end && Char.IsDigit(s[start])) {
            start++;
            isNum = true;
        }
        if (start < end && s[start] == '.') {
            start++;
            while (start < end && Char.IsDigit(s[start])) {
                start++;
                isNum = true;
            }
        }
        if (isNum && start < end && s[start] == 'e') {
            start++;
            isNum = false;
            if (start < end && (s[start] == '+' || s[start] == '-')) {
                start++;
            }
            while (start < end && Char.IsDigit(s[start])) {
                start++;
                isNum = true;
            }
        }
        
        while (start < end && s[start] == ' ') {
            start++;
        }
        
        return isNum && start == end;
    }
}

// TODO: use FSM transform matrix