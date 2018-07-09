public class Solution {
    public string AddBinary(string a, string b) {
        if (a == null || b == null) {
            return "";
        }
        
        var na = a.Length - 1;
        var nb = b.Length - 1;
        var sb = new StringBuilder();
        int carry = 0;
        while (na >= 0 || nb >= 0) {
            var sum = carry;
            if (na >= 0) {
                sum += a[na] - '0';
                na--;
            }
            if (nb >= 0) {
                sum += b[nb] - '0';
                nb--;
            }
            carry = sum >> 1;
            sum = sum & 1;
            sb.Insert(0, sum == 0 ? '0' : '1');
        }
        if (carry > 0) {
            sb.Insert(0, '1');
        }
        
        return sb.ToString();
    }
}

