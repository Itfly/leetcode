public class MyCircularQueue {
    
    private int[] queue;
    private int head;
    private int tail;
    private int capacity;

    /** Initialize your data structure here. Set the size of the queue to be k. */
    public MyCircularQueue(int k) {
        queue = Enumerable.Repeat(-1, k + 1).ToArray();
        head = 0;
        tail = 0;
        capacity = k + 1;
    }
    
    /** Insert an element into the circular queue. Return true if the operation is successful. */
    public bool EnQueue(int value) {
        if (IsFull()) {
            return false;
        }
            
        queue[tail] = value;
        tail = (tail + 1) % capacity;
    
        return true;
    }
    
    /** Delete an element from the circular queue. Return true if the operation is successful. */
    public bool DeQueue() {
        if (IsEmpty()) {
            return false;
        }
        
        head = (head + 1) % capacity;
        
        return true;
    }
    
    /** Get the front item from the queue. */
    public int Front() {
        if (IsEmpty()) {
            return -1;
        }
        
        return queue[head];
    }
    
    /** Get the last item from the queue. */
    public int Rear() {
        if (IsEmpty()) {
            return -1;
        }
        
        return queue[(tail - 1 + capacity) % capacity];
    }
    
    /** Checks whether the circular queue is empty or not. */
    public bool IsEmpty() {
        return tail == head;
    }
    
    /** Checks whether the circular queue is full or not. */
    public bool IsFull() {
        return (tail + 1) % capacity == head;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */
