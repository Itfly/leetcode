public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        var low = 0;
        var high = letters.Length - 1;
        while (low < high) {
            var mid = low + (high - low) / 2;
            if (letters[mid] <= target) {
                low = mid + 1;
            } else {
                high = mid;
            }
        }
        
        return letters[low] > target ? letters[low] : letters[0];
    }
}


public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        var low = 0;
        var high = letters.Length;
        while (low < high) {
            var mid = low + (high - low) / 2;
            if (letters[mid] <= target) {
                low = mid + 1;
            } else {
                high = mid;
            }
        }
        
        return letters[low % letters.Length];
    }
}
