public class MinStack {
    
    private Stack<int> stack;
    private Stack<int> min;
    
    private bool IsStackEmpty => stack.Count == 0;
    private bool IsMinEmpty => min.Count == 0;

    /** initialize your data structure here. */
    public MinStack() {
        stack = new Stack<int>();
        min = new Stack<int>();
    }
    
    public void Push(int x) {
        stack.Push(x);
        if (x <= GetMin()) {
            min.Push(x);
        }
    }
    
    public void Pop() {
        if (this.IsStackEmpty) {
            return;
        }
        
        var x = stack.Pop();
        if (x == GetMin()) {
            min.Pop();
        }
    }
    
    public int Top() {
        if (this.IsStackEmpty) {
            return int.MaxValue;
        }
        
        return stack.Peek();
    }
    
    public int GetMin() {
        if (this.IsMinEmpty) {
            return int.MaxValue;
        }
        
        return min.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
