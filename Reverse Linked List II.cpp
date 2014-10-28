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
    ListNode *reverseBetween(ListNode *head, int m, int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        ListNode *X = new ListNode(-1);
        ListNode *pre = X;
        ListNode *start;
        int i = 1;
        X->next = head;
        while (i < m) {
            pre = head;
            head = head->next;
            i++;
        }
        start = head;
        head = head->next;
        i++;
        while (i <= n) {
            start->next = head->next;
            head->next = pre->next;
            pre->next = head;
            i++;
            head = start->next;
        }
        
        return X->next;
    }
};