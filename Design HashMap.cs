public class MyHashMap {
    private int[][] buckets;
    private int k;
    
    private int Hash(int key) {
        return key % k;
    }

    /** Initialize your data structure here. */
    public MyHashMap() {
        buckets = new int[1000][];
        k = 1000;
    }
    
    /** value will always be non-negative. */
    public void Put(int key, int value) {
        var hashKey = Hash(key);
        if (buckets[hashKey] == null) {
            buckets[hashKey] = Enumerable.Repeat(-1, 1001).ToArray();
        }
        buckets[hashKey][key / k] = value;
    }
    
    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key) {
        var hashKey = Hash(key);
        if (buckets[hashKey] != null) {
            return buckets[hashKey][key / k];
        }
        return -1;
    }
    
    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key) {
        var hashKey = Hash(key);
        if (buckets[hashKey] != null) {
            buckets[hashKey][key / k] = -1;
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
