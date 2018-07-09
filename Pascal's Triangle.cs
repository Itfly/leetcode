public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var triangle = new List<IList<int>>();
        if (numRows <= 0) {
            return triangle;
        }
        
        var row = new List<int>();
        row.Add(1);
        triangle.Add(row);
        for (int i = 1; i < numRows; i++) {
            row = new List<int>(i+1);
            for (int j = 0; j <= i; j++) {
                row.Add(1);
            }
            triangle.Add(row);
            for (int j = 1; j < i; j++) {
                triangle[i][j] = triangle[i-1][j] + triangle[i-1][j-1];
            }
        }
        
        return triangle;
    }
    
}
