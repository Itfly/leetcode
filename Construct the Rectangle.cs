public class Solution {
    public int[] ConstructRectangle(int area) {
        for (var i = (int)Math.Sqrt(area); i >= 1; i--) {
            if (area % i == 0) {
                return new int[] {area / i, i};
            }
        }
        
        return null;
    }
}
