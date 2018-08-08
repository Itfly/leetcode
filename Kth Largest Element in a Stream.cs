public class KthLargest {
    private TreeNode root;
    private int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        foreach (var num in nums) {
            Insert(num);
        }
    }
    
    public int Add(int val) {
        Insert(val);
        return Search(this.root, this.k);
    }
    
    private int Search(TreeNode root, int k) {
        var cur = root;
        while (cur.right != null && cur.right.count > k) {
            cur = cur.right;
        }
        
        if (cur.right != null) {
            k -= cur.right.count;  
            if (k == 0) {
                cur = cur.right;
                while (cur.left != null) {
                    cur = cur.left;
                }
                return cur.val;
            }
        }
        
        
        k -= cur.valCnt;
        if (k <= 0) {
            return cur.val;
        } else {
            return Search(cur.left, k);
        }
    }
    
    
    private void Insert(int val) {
        if (this.root == null) {
            this.root = new TreeNode(val);
            return;
        }
        
        TreeNode pre = null;
        TreeNode cur = this.root;
        while (cur != null) {
            ++cur.count;
            if (cur.val == val) {
                ++cur.valCnt;
                return;
            } 
            
            if (cur.val > val) {
                pre = cur;
                cur = cur.left;
            } else {
                pre = cur;
                cur = cur.right;
            }
        }
        if (pre.val > val) {
            pre.left = new TreeNode(val);
        } else {
            pre.right = new TreeNode(val);
        }
    }
    
    class TreeNode {
        public int val;
        public int count;
        public int valCnt;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) {
            val = x;
            count = 1;
            valCnt = 1;
        }
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
