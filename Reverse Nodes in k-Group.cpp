class Solution {
public:
    ListNode *reverse(ListNode *pre, ListNode *end) {
        ListNode *p = pre->next;
        ListNode *q = p->next;
        while (q != end) {
            p->next = q->next;
            q->next = pre->next;
            pre->next = q;
            q = p->next;
        }
        return p;
    }
    ListNode *reverseKGroup(ListNode *head, int k) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (head == NULL || k == 1) return head;
        ListNode * pre = new ListNode(-1);
        pre->next = head;
        ListNode *p =  head;
        head = pre;
        int i = 0;
        while (p != NULL) {
            i++;
            if (i % k == 0) {
                pre = reverse(pre, p->next);
                p = pre->next;
            } else {
                p = p->next;
            }
            
    
        }
        return head->next;
    }
};