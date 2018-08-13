public class LRUCache {
    private readonly int capacity;
    
    private readonly Node head;
    private readonly IDictionary<int, Node> cache;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        this.head = new Node(-1, -1);
        this.head.Next = this.head;
        this.head.Prev = this.head;
        this.cache = new Dictionary<int, Node>(capacity);
    }
    
    public int Get(int key) {
        if (cache.TryGetValue(key, out var node)) {
            MoveToFirst(node);
            return node.Entity.Value;
        }
        
        return -1;
    }
    
    public void Put(int key, int value) {
        if (cache.TryGetValue(key, out var node)) {
            node.Entity = new KeyValuePair<int, int>(key, value);
            MoveToFirst(node);
            return;
        }
            
        if (cache.Count == this.capacity) {
            var lastNode = this.head.Prev;
            cache.Remove(lastNode.Entity.Key);
            RemoveNode(lastNode);
        }
            
        var newNode = new Node(key, value);
        cache[key] = newNode;
        InsertAfterHead(newNode);
    }
    
    private void MoveToFirst(Node node) {
        RemoveNode(node);
        InsertAfterHead(node);
    }
    
    private void RemoveNode(Node node) {
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
    }
    
    private void InsertAfterHead(Node node) {
        node.Next = this.head.Next;
        node.Prev = this.head;
        node.Next.Prev = node;
        this.head.Next = node;
    }
    
    class Node {
        public KeyValuePair<int, int> Entity;
        public Node Next;
        public Node Prev;
        
        public Node(int key, int value) {
            this.Entity = new KeyValuePair<int, int>(key, value);
            this.Next = null;
            this.Prev = null;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
