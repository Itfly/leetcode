public class Solution {
    public int LargestPalindrome(int n) {
        if (n == 1) {
            return 9;
        }
        
        var upper = (int) Math.Pow(10, n) - 1;
        var lower = (int) Math.Pow(10, n - 1);
        for (var i = upper; i >= lower; i--) {
            var product = BuildPalindromeProduct(i);
            for (long j = upper; j * j >= product; j--) {
                if (product % j == 0) {
                    return (int) (product % 1337);
                }
            }
        }
        
        return -1;
    }
    
    private long BuildPalindromeProduct(int value) {
        var s = value.ToString();
        return Convert.ToInt64(s + Reverse(s));
    }
    
    private static string Reverse(string s)
    {
        var arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
