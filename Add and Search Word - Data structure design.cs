public class WordDictionary {
    private TrieNode root;

    /** Initialize your data structure here. */
    public WordDictionary() {
        root = new TrieNode();
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
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
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
        if (string.IsNullOrEmpty(word)) {
            return true;
        }
        
        return root.Search(word, 0);
    }
    
    class TrieNode
    {
        public TrieNode[] Children = new TrieNode[26];
        public bool IsWord;
        
        public bool Search(string word, int index) {
            if (index == word.Length) {
                return this.IsWord;
            }
            
            var ch = word[index]; 
            if (ch == '.') {
                foreach (var child in Children) {
                    if (child != null && child.Search(word, index + 1)) {
                        return true;
                    }
                }
                return false;
            } else {
                var i = ch - 'a';
                if (Children[i] == null) {
                    return false;
                }
                return Children[i].Search(word, index + 1);
            }
        }
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
