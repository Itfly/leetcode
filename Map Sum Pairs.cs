public class MapSum {
    private Trie root;
    private Dictionary<string, int> values;

    /** Initialize your data structure here. */
    public MapSum() {
        root = new Trie();
        values = new Dictionary<string, int>();
    }
    
    public void Insert(string key, int val) {
        var inc = val;
        if (values.ContainsKey(key)) {
            inc = val - values[key];
        }
        values[key] = val;
        
        var cur = root;
        foreach (var ch in key) {
            var index = (int) ch;
            if (cur.Children[index] == null) {
                cur.Children[index] = new Trie();
            }
            cur.Children[index].Sum += inc;
            cur = cur.Children[index];
        }
    }
    
    public int Sum(string prefix) {
        var cur = root;
        foreach (var ch in prefix) {
            var index = (int) ch;
            if (cur.Children[index] == null) {
                return 0;
            }
            cur = cur.Children[index];
        }
        return cur.Sum;
    }
    
    class Trie {
        public Trie[] Children = new Trie[128];
        public int Sum;
    }
}

/**
 * Your MapSum object will be instantiated and called as such:
 * MapSum obj = new MapSum();
 * obj.Insert(key,val);
 * int param_2 = obj.Sum(prefix);
 */
