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
    ListNode *mergeTwoLists(ListNode *l1, ListNode *l2) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        ListNode *head = new ListNode(-1);
        ListNode *p = head;
        
        while (l1 && l2) {
            if (l1->val < l2->val) {
                p->next = l1;
                l1= l1->next;
            } else {
                p->next = l2;
                l2 = l2->next;
            }
            p = p->next;
        }
        if (l2 != NULL) {
            l1 = l2;
        }
        p->next = l1;
        
        return head->next;
    }
};