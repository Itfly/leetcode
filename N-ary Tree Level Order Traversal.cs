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
    public IList<IList<int>> LevelOrder(Node root) {
        var result = new List<IList<int>>();
        if (root == null) {
            return result;
        }
        
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            var size = queue.Count;
            var values = new List<int>();
            for (var i = 0; i < size; i++) {
                var cur = queue.Dequeue();
                values.Add(cur.val);
                foreach (var child in cur.children) {
                    queue.Enqueue(child);
                }
            }
            result.Add(values);
        }
        
        return result;
    }
}
