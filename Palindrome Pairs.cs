public class Solution {
    public IList<IList<int>> PalindromePairs(string[] words) {
        var result = new List<IList<int>>();
        if (words == null || words.Length == 0) {
            return result;
        }

        var trie = BuildTrie(words);
        for (var i = 0; i < words.Length; i++) {
            var word = words[i];
            var cur = trie;
            for (var j = 0; j < word.Length; j++) {
                var index = word[j] - 'a';
                if (cur.Id >= 0 && cur.Id != i && IsPalindrome(word, j, word.Length - 1)) {
                    result.Add(new List<int>() {i, cur.Id});
                }

                cur = cur.Children[index];
                if (cur == null) {
                    break;
                }
            }

            if (cur == null) {
                continue;
            }
            foreach (var pos in cur.Palindromes) {
                if (pos == i) {
                    continue;
                }

                result.Add(new List<int>() {i, pos});
            }
        }
        
        return result;
    }
    
    private static bool IsPalindrome(string str, int i, int j) {
        while (i < j) {
            if (str[i++] != str[j--]) {
                return false;
            }
        }
        return true;
    }
    
    private TrieNode BuildTrie(string[] words) {
        var root = new TrieNode();
        for (var i = 0; i < words.Length; i++) {
            var word = words[i];
            var cur = root;
            for (var j = word.Length - 1; j >= 0; j--) {
                var index = word[j] - 'a';
                if (cur.Children[index] == null) {
                    cur.Children[index] = new TrieNode();
                }
                if (IsPalindrome(word, 0, j)) {
                    cur.Palindromes.Add(i);
                }
                cur = cur.Children[index];
            }
            cur.Id = i;
            cur.Palindromes.Add(i);
        }
        
        return root;
    }
    
    class TrieNode
    {
        public TrieNode[] Children = new TrieNode[26];
        public List<int> Palindromes = new List<int>();  // str positions if their substr is palindrome.
        public int Id = -1; // str position
    }
}
