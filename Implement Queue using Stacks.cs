public class MyQueue {
    private Stack<int> inbox;
    private Stack<int> outbox;
    
    private void Transfer() {
        if (outbox.Count == 0) {
            while (inbox.Count > 0) {
                outbox.Push(inbox.Pop());
            }
        }
    }

    /** Initialize your data structure here. */
    public MyQueue() {
        inbox = new Stack<int>();
        outbox = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        inbox.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        Transfer();
        return outbox.Pop();
    }
    
    /** Get the front element. */
    public int Peek() {
        Transfer();
        return outbox.Peek();
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return inbox.Count == 0 && outbox.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
