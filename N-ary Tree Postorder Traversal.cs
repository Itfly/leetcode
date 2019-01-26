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
    public IList<int> Postorder(Node root) {
        var sequence = new List<int>();
        if (root == null) {
            return sequence;
        }
        
        foreach (var child in root.children) {
            sequence.AddRange(Postorder(child));
        }
        sequence.Add(root.val);
        
        return sequence;
    }
}
