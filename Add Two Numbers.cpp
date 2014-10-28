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
    ListNode *addTwoNumbers(ListNode *l1, ListNode *l2) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (l1 == NULL) {
            return l2;
        } else if (l2 == NULL) {
            return l1;
        }
        
        int carry = 0;
        ListNode *head = new ListNode(-1);
        ListNode *pre = head;
        while (l1 && l2) {
            int sum = l1->val + l2->val + carry;
            carry = sum / 10;
            sum = sum % 10;
            ListNode *cur = new ListNode(sum);
            pre->next = cur;
            pre = cur;
            l1 = l1->next;
            l2 = l2->next;
        }
        
        if (l2 != NULL) {
            l1 = l2;
        }
        
        while (l1 != NULL) {
            int sum = l1->val + carry;
            carry = sum / 10;
            sum = sum % 10;
            ListNode *cur = new ListNode(sum);
            pre->next = cur;
            pre = cur;
            l1 = l1->next;
        }
        if (carry == 1) {
            ListNode *cur = new ListNode(1);
            pre->next = cur;
            pre = cur;
        }
        pre->next = NULL;
        
        return head->next;
    }
};