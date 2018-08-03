public class Solution {
    public bool IsHappy(int n) {
        var set = new HashSet<int>();
        while (!set.Contains(n)) {
            set.Add(n);
            n = GetSum(n);
            if (n == 1) {
                return true;
            }
        }
        
        return false;
    }
    
    private int GetSum(int n) {
        int sum = 0;
        while (n > 0) {
            sum += (n % 10) * (n % 10);
            n /= 10;
        }
        
        return sum;
    }
}
