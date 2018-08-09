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
    public IList<int> Preorder(Node root) {
        var sequence = new List<int>();
        if (root == null) {
            return sequence;
        }
        
        sequence.Add(root.val);
        foreach (var child in root.children) {
            sequence.AddRange(Preorder(child));
        }
        
        return sequence;
    }
}
