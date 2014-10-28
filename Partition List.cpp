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
    ListNode *partition(ListNode *head, int x) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (head == NULL) return head;
        ListNode h(-1);
        ListNode *less = NULL, *p = head, *pre = NULL;
        //less->next = head;
        while (p != NULL && p->val < x) {
            less = p;
            p = p->next;
        }
        if (p == NULL) return head;
        pre = p;
        p = p->next;
        while (p != NULL) {
            if (p->val < x) {
                pre->next = p->next;
                if (less == NULL) {
                    less = p;
                    less->next = head;
                    head = less;
                } else {
                    p->next = less->next;
                    less->next = p;
                    less = p;
                }
            } else {
                pre = p;
            }
            
            p = p->next;
        }
        return head;
    }
};