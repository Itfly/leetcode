public class Solution {
    private static int[,] dirs = new int[4, 2] {{-1, 0}, {1, 0}, {0, 1}, {0, -1}};
    
    public int[,] FloodFill(int[,] image, int sr, int sc, int newColor) {
        if (image[sr, sc] == newColor) {
            return image;
        }
        
        var m = image.GetLength(0);
        var n = image.GetLength(1);
        var color = image[sr, sc];
        var stack = new Stack<int>();
        stack.Push(sr * n + sc);
        
        while (stack.Count > 0) {
            var cur = stack.Pop();
            var i = cur / n;
            var j = cur % n;
            image[i, j] = newColor;
            
            for(var k = 0; k < 4; k++) {
                var ii = i + dirs[k, 0];
                var jj = j + dirs[k, 1];
                if (ii >= 0 && ii < m && jj >= 0 && jj < n && image[ii, jj] == color) {
                    stack.Push(ii * n + jj);
                }
            }
        }
        
        return image;
    }
}
