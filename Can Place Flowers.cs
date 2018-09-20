public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        var count = 1;
        var result = 0;
        for (var i = 0; i < flowerbed.Length; i++) {
            if (flowerbed[i] == 0) {
                count++;
            } else {
                result += (count - 1) / 2;
                count = 0;
            }
        }
        
        if (count != 0) {
            result += count / 2;
        }
        
        return result >= n;
    }
}
