public class MyStack {
    private Queue<int> inbox;
    private Queue<int> outbox;

    /** Initialize your data structure here. */
    public MyStack() {
        inbox = new Queue<int>();
        outbox = new Queue<int>();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        inbox.Enqueue(x);
        while (outbox.Count > 0) {
            inbox.Enqueue(outbox.Dequeue());
        }
        
        var tmp = inbox;
        inbox = outbox;
        outbox = tmp; 
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        return outbox.Dequeue();
    }
    
    /** Get the top element. */
    public int Top() {
        return outbox.Peek();
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return inbox.Count == 0 && outbox.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
/*
push:
  enqueue in queue2
  enqueue all items of queue1 in queue2, then switch the names of queue1 and queue2
pop:
  deqeue from queue1
*/
