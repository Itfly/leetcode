public class Solution {
    public IList<string> FindWords(char[,] board, string[] words) {
        if (board == null || board.Length == 0 || words == null || words.Length == 0) {
            return new List<string>();
        }
        
        var trie = BuildTrie(words);
        var result = new List<string>();
        
        for (var i = 0; i < board.GetLength(0); i++) {
            for (var j = 0; j < board.GetLength(1); j++) {
                Search(board, i, j, trie, result);
            }
        }
        
        return result;
    }
    
    private TrieNode BuildTrie(string[] words) {
        var root = new TrieNode();        
        foreach (var word in words) {
            var cur = root;
            foreach (var ch in word) {
                var index = ch - 'a';
                if (cur.Children[index] == null) {
                    cur.Children[index] = new TrieNode();
                }
                cur = cur.Children[index];
            }
            cur.Word = word;
        }
        
        return root;
    }
    
    private static int[,] dirs = new int[4,2] {{-1, 0}, {1, 0}, {0, -1}, {0, 1}};
    
    private void Search(char[,]board, int i, int j, TrieNode node, List<string> result) {
        if (i < 0 || i >= board.GetLength(0) || j < 0 || j >= board.GetLength(1) || board[i, j] == '#') {
            return;
        }
        
        var ch = board[i, j];
        node = node.Children[ch - 'a'];
        if (node == null) {
            return;
        }
        
        if (node.Word != null) {
            result.Add(node.Word);
            node.Word = null;
        }
         
        board[i, j] = '#';
        for (var k = 0; k < 4; k++) {
            var ii = i + dirs[k, 0];
            var jj = j + dirs[k, 1];
            Search(board, ii, jj, node, result);
        }
        board[i, j] = ch;
    }
        
    class TrieNode
    {
        public TrieNode[] Children = new TrieNode[26];
        public string Word;
    }
}
