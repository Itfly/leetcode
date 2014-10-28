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
    ListNode *insertionSortList(ListNode *head) {
        // IMPORTANT: Please reset any member data you declared, as
        // the same Solution instance will be reused for each test case
        if (head == NULL || head->next == NULL) return head;
        
        ListNode *p, *q, *pre;
        p = head->next;
        head->next = NULL;
        pre = new ListNode(-1);
        pre->next = head;
        head = pre;
        
        while (p != NULL) {
            q = p->next;
            pre = head;
            while (pre->next != NULL && pre->next->val <= p->val) {
                pre = pre->next;
            }
            p->next = pre->next;
            pre->next =p;

            p = q;
        }
        
        p = head;
        head = head->next;
        delete(p);
        
        return head;
    }
};