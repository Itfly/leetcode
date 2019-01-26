public class LFUCache {
    private readonly int capacity;
    private int minFrequency;
    private readonly IDictionary<int, Node> cache;
    private readonly IDictionary<int, Node> frequency;

    public LFUCache(int capacity) {
        this.capacity = capacity;
        this.cache = new Dictionary<int, Node>(capacity);
        this.frequency = new Dictionary<int, Node>(); 
        this.minFrequency = 0;
    }
    
    public int Get(int key) {
        if (cache.TryGetValue(key, out var node)) {
            IncreFrequency(node);
            return node.Entity.Value;
        }
        
        return -1;
    }
    
    public void Put(int key, int value) {
        if (this.capacity == 0) {
            return;
        }
        
        if (cache.TryGetValue(key, out var node)) {
            node.Entity = new KeyValuePair<int, int>(key, value);
            IncreFrequency(node);
            return;
        }
        
        if (cache.Count == this.capacity) {
            var minHead = frequency[minFrequency];
            cache.Remove(minHead.Prev.Entity.Key);
            RemoveNode(minHead.Prev);
        }
        
        var newNode = new Node(key, value);
        this.minFrequency = 1;
        cache[key] = newNode;
        MoveNode(newNode);
    }
    
    private void IncreFrequency(Node node) {
        RemoveNode(node);
        node.Frequency++;
        MoveNode(node);
    }
    
    private void RemoveNode(Node node) {
        if (node.Prev == node) {
            frequency.Remove(node.Frequency);
            if (node.Frequency == this.minFrequency) {
                this.minFrequency++;
            }
        } else {
            if (frequency[node.Frequency] == node)
            {
                frequency[node.Frequency] = node.Next;
            }
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;    
        }
    }
    
    private void MoveNode(Node node) {
        if (frequency.TryGetValue(node.Frequency, out var head)) {
            node.Next = head;
            node.Prev = head.Prev;
            head.Prev = node;   
            node.Prev.Next = node;
        } else {
            node.Next = node;
            node.Prev = node;
            
        }
        frequency[node.Frequency] = node;
    }
    
    class Node {
        public KeyValuePair<int, int> Entity;
        public Node Next;
        public Node Prev;
        public int Frequency;
        
        public Node(int key, int value) {
            this.Entity = new KeyValuePair<int, int>(key, value);
            this.Next = null;
            this.Prev = null;
            this.Frequency = 1;
        }
    }
}


// better: https://www.jianshu.com/p/437f53341f67

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
