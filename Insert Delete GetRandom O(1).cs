public class RandomizedSet {
    private Dictionary<int, int> map1;
    private Dictionary<int, int> map2;
    private static readonly Random random = new Random();


    /** Initialize your data structure here. */
    public RandomizedSet() {
        map1 = new Dictionary<int, int>();
        map2 = new Dictionary<int, int>();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if (map1.ContainsKey(val)) {
            return false;
        }
        
        var cnt = map1.Count;
        map1[val] = cnt;
        map2[cnt] = val;
        
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if (!map1.ContainsKey(val)) {
            return false;
        }
        
        var index = map1[val];
        map1.Remove(val);
        map2.Remove(index);
        
        if (map1.Count == 0 || index == map1.Count) {
            return true;
        }
        
        var key = map2[map2.Count];
        map1[key] = index;
        map2.Remove(map2.Count);
        map2[index] = key;
        
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        if (map1.Count == 0) {
            return -1;
        }
        
        if (map1.Count == 1) {
            return map2[0];
        }
        
        return map2[random.Next(map2.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
