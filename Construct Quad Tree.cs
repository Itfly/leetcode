/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node(){}
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
}
*/
public class Solution {
    public Node Construct(int[][] grid) {
        return Construct(grid, 0, 0, grid.Length - 1, grid.Length - 1);
    }
    
    private Node Construct(int[][] grid, int i1, int j1, int i2, int j2) {
        if (i1 == i2) {
            return new Node(grid[i1][j1] == 1, true, null, null, null, null);
        }
        
        var mi = i1 + (i2 - i1) / 2;
        var mj = j1 + (j2 - j1) / 2;
        var node = new Node();
        node.topLeft = Construct(grid, i1, j1, mi, mj);
        node.topRight = Construct(grid, i1, mj + 1, mi, j2);
        node.bottomLeft = Construct(grid, mi + 1, j1, i2, mj);
        node.bottomRight = Construct(grid, mi + 1, mj + 1, i2, j2);
        
        if (node.topLeft.isLeaf && node.topRight.isLeaf && node.bottomLeft.isLeaf && node.bottomRight.isLeaf
           && node.topLeft.val == node.topRight.val && node.topLeft.val == node.bottomLeft.val 
            && node.topLeft.val == node.bottomRight.val) {
            node.isLeaf = true;
            node.val = node.topLeft.val;
            node.topLeft = null;
            node.topRight = null;
            node.bottomLeft = null;
            node.bottomRight = null;
        }
        
        return node;
    }
}
