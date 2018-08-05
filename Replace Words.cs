public class Solution {
    public string ReplaceWords(IList<string> dict, string sentence) {
        var trie = GenerateTrie(dict);
        var words = sentence.Split(' ');
        for (var i = 0; i < words.Length; i++) {
            var root = trie.SearchRoot(words[i]);
            if (root != null) {
                words[i] = root;
            }
        }
        
        return string.Join(" ", words);
    }
       
    class Trie {
        private TrieNode root = new TrieNode();
        
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
        
        public string SearchRoot(string word) {
            var cur = root;
            var sb = new StringBuilder();
            foreach (var ch in word) {
                var index = ch - 'a';
                if (cur.Children[index] == null) {
                    return null;
                }
                cur = cur.Children[index];
                sb.Append(ch);
                if (cur.IsWord) {
                    return sb.ToString();
                }
            }
            
            return null;
        }
        
        class TrieNode {
            public TrieNode[] Children = new TrieNode[26];
            public bool IsWord; 
        }
    }
    
    private Trie GenerateTrie(IList<string> dict) {
        var trie = new Trie();
        foreach (var word in dict) {
            trie.Insert(word);
        }
        
        return trie;
    }    
}
