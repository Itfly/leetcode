public class Solution {
    public int FindMaximumXOR(int[] nums) {
        if (nums == null || nums.Length <= 0) {
            return 0;
        }
        
        var root = new TrieNode();
        foreach (var num in nums) {
            var cur = root;
            for (var i = 31; i >= 0; i--) {
                var curBit = (num >> i) & 0x1;
                if (cur.Children[curBit] == null) {
                    cur.Children[curBit] = new TrieNode();
                }
                cur = cur.Children[curBit];
            }
        }
        
        var max = 0;
        foreach (var num in nums) {
            var cur = root;
            int curMax = 0;
            for (var i = 31; i >= 0; i--) {
                var curBit = (num >> i) & 0x1;
                if (cur.Children[curBit ^ 0x1] != null) {
                    curMax += (1 << i);
                    cur = cur.Children[curBit ^ 0x1];
                } else {
                    cur = cur.Children[curBit];
                }
            }
            max = Math.Max(max, curMax);
        }
        return max;
    }
        
    class TrieNode
    {
        public TrieNode[] Children = new TrieNode[2];
    }
}
