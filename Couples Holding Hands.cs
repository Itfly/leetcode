public class Solution {
// https://leetcode.com/problems/couples-holding-hands/discuss/113362/JavaC++-O(N)-solution-using-cyclic-swapping
    public int MinSwapsCouples(int[] row) {
        var result = 0;
        var n = row.Length;
        
        var ptn = new int[n];
        var pos = new int[n];
        for (var i = 0; i < n; i++) {
            ptn[i] = i % 2 == 0 ? i + 1 : i - 1;
            pos[row[i]] = i;
        }
        
        for (var i = 0; i < n; i++) {
            for (var j = ptn[pos[ptn[row[i]]]]; i != j; j = ptn[pos[ptn[row[i]]]]) {
                swap(row, i, j);
                swap(pos, row[i], row[j]);
                result++;
            }
        }
        
        return result;
    }
    
    private void swap(int[] arr, int i, int j) {
        var temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
