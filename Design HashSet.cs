public class MyHashSet {
    private bool[][] buckets;
    private int k;
    
    private int Hash(int key) {
        return key % k;
    }

    /** Initialize your data structure here. */
    public MyHashSet() {
        buckets = new bool[1000][];
        k = 1000;
    }
    
    public void Add(int key) {
        var hashKey = Hash(key);
        if (buckets[hashKey] == null) {
            buckets[hashKey] = new bool[1001];
        }
        buckets[hashKey][key / k] = true;
    }
    
    public void Remove(int key) {
        var hashKey = Hash(key);
        if (buckets[hashKey] != null) {
            buckets[hashKey][key / k] = false;
        }
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        var hashKey = Hash(key);
        return buckets[hashKey] != null && buckets[hashKey][key / k];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
