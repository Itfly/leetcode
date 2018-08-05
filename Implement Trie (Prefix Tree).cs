public class Trie {
    private TrieNode root;

    /** Initialize your data structure here. */
    public Trie() {
        root = new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        if (string.IsNullOrEmpty(word)) {
            return;
        }
        
        var cur = root;
        foreach (var ch in word) {
            var index = ch - 'a';
            if (cur.Children[index] == null) {
                cur.Children[index] = new TrieNode();
            }
            cur = cur.Children[index];
        }
        cur.IsWord = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        if (string.IsNullOrEmpty(word)) {
            return true;
        }
        
        var node = SearchNode(word);
        if (node == null) {
            return false;
        }
        return node.IsWord;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        if (string.IsNullOrEmpty(prefix)) {
            return true;
        }
        
        return SearchNode(prefix) != null;
    }
    
    
    class TrieNode {
        public TrieNode[] Children = new TrieNode[26];
        public bool IsWord;
    }
    
    private TrieNode SearchNode(string str) {
        var cur = root;
        foreach (var ch in str) {
            var index = ch - 'a';
            if (cur.Children[index] == null) {
                return null;
            }
            cur = cur.Children[index];
        }
        return cur;
    }
}


/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
