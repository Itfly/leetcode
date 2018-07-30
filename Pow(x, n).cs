public class Solution {
    public double MyPow(double x, int n) {
        var sign = true;
        if (n < 0) {
            if (n == int.MinValue) {
                if (x < 0) {
                    x = -x;
                }
                x = 1 / x;
                return x * Pow(x, -(n + 1));
            } else {
                n = -n;
            }
            x = 1 / x;
        }
        
        return Pow(x, n);
    }
    
    private double Pow(double x, int n) {
        if (n == 0) {
            return 1;
        } else if (n == 1) {
            return x;
        }
        
        double power = Pow(x, n / 2);
        power *= power;
        if (n % 2 == 1) {
            power *= x;
        }
        
        return power;
    }
}
