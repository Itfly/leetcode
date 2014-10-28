/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode *deleteDuplicates(ListNode *head) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (head == NULL || head->next == NULL) return head;
        ListNode *hh = new ListNode(-1);
        ListNode *p = head, *pre =hh;
        hh->next = head;
        
        while (p != NULL) {
            ListNode *q = p->next;
            while (q != NULL && p->val == q->val) {
                q = q->next;
            }
            if (p->next != q) {
                pre->next = q;
                ListNode *t;
                while (p != q) {
                    t = p;
                    p = p->next;
                    delete t;
                }
                
            } else {
                pre = p;
            }
            p = pre->next;
        }
        
        return hh->next;
    }
};