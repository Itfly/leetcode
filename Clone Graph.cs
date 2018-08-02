/**
 * Definition for undirected graph.
 * public class UndirectedGraphNode {
 *     public int label;
 *     public IList<UndirectedGraphNode> neighbors;
 *     public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        if (node == null) {
            return null;
        }
        
        var stack = new Stack<UndirectedGraphNode>();
        var map = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
        
        stack.Push(node);
        map.Add(node, new UndirectedGraphNode(node.label));
        
        while (stack.Count > 0) {
            var cur = stack.Pop();
            foreach (var neighbor in cur.neighbors) {
                if (!map.ContainsKey(neighbor)) {
                    stack.Push(neighbor);
                    map.Add(neighbor, new UndirectedGraphNode(neighbor.label));
                }
                
                map[cur].neighbors.Add(map[neighbor]);
            }
            
        }
        
        return map[node];
    }
}
