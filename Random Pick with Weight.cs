public class Solution {
    private Random random;
    private int[] wsum;
    private int sum;
    
    public Solution(int[] w) {
        random = new Random();
        
        wsum = new int[w.Length];
        wsum[0] = w[0];
        for (var i = 1; i < w.Length; i++) {
            wsum[i] = wsum[i - 1] + w[i]; 
        }
        sum = wsum[wsum.Length - 1];
    }
    
    public int PickIndex() {
        var weight = random.Next(sum) + 1;
        
        var left = 0;
        var right = wsum.Length - 1;
        while (left <= right) {
            var mid = left + (right - left) / 2;
            if (wsum[mid] == weight) {
                return mid;
            } else if (wsum[mid] > weight) {
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        
        return left;
    }
}

/**
 * Another question from interview
 * if pick one then decrease one of the weight?
 * Use Huffman tree
 */
