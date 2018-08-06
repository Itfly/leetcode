/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if (root == null) {
            return null;
        }
        
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        var sb = new StringBuilder();
        while (stack.Count > 0) {
            var cur = stack.Pop();
            if (cur != null) {
                sb.Append(cur.val + ",");
                stack.Push(cur.right);
                stack.Push(cur.left);
            } else {
                sb.Append("#,");
            }
        }
        
        return sb.ToString().Substring(0, sb.Length - 1);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if (data == null) {
            return null;
        }
        
        var root = 0;
        return deserialize(data.Split(','), ref root);
    }
    
    private TreeNode deserialize(string[] strs, ref int root) {
        if (strs[root] == "#") {
            return null;
        }
        
        var node = new TreeNode(int.Parse(strs[root]));
        root += 1;
        node.left = deserialize(strs, ref root);
        root += 1;
        node.right = deserialize(strs, ref root);
        
        return node;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));
