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
        if (head == NULL) return NULL;
        
        ListNode *p, *q;
        p = head;
        while (p->next) {
            q = p->next;
            if (p->val == q->val) {
                p->next = q->next;
                delete q;
            } else {
                p = p->next;
            }
            
        }
        
        return head;
    }
};