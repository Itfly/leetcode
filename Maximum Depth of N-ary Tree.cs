/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
public class Solution {
    public int MaxDepth(Node root) {
        if (root == null) {
            return 0;
        }
        
        var depth = 0;
        foreach (var child in root.children) {
            var childDepth = MaxDepth(child);
            depth = Math.Max(depth, childDepth);
        }
        return depth + 1;
    }
}
