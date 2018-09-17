public class Solution {
    public string SmallestGoodBase(string n) {
        var num = Convert.ToInt64(n);
        for (var m = (int) (Math.Log(num + 1) / Math.Log(2)); m > 2; m--) {
            var left = (long) (Math.Pow(num + 1, 1.0 / m));
            var right = (long) (Math.Pow(num, 1.0 / (m - 1)));
            
            while (left <= right) {
                long k = left + (right - left) / 2;
                for (var i = 0; i < m; i++, f = f * k + 1);  // (k^m - 1) / (k - 1) may overflow
                if (num == f) {
                    return k.ToString();
                } else if (num < f) {
                    right = k - 1;
                } else {
                    left = k + 1;
                }
            }
        }
        
        return (num - 1).ToString();
    }
} 
