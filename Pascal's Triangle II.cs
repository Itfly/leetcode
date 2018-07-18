public class Solution {
    public IList<int> GetRow(int rowIndex) {
        if (rowIndex < 0) {
            return null;
        }
        
        var row = Enumerable.Repeat(1, rowIndex + 1).ToList();
        for (var i = 1; i <= rowIndex; i++) {
            var prev = 1;
            for (int j = 1; j < i; j++) {
                var temp = row[j];
                row[j] = prev + row[j];
                prev = temp;
            }
        }
        
        return row;
    }
}
