public class Solution {
    public string ConvertToBase7(int num) {
        if (num < 0) {
            return "-" + ConvertToBase7(-num);
        }
        if (num < 7) {
            return num.ToString();
        }
        return ConvertToBase7(num / 7) + ConvertToBase7(num % 7);
    }
}
