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
    int getLength(ListNode *head, ListNode **last) {
        ListNode *p = head, *pre = NULL;
        int cnt = 0;
        while (p != NULL) {
            cnt++;
            pre = p;
            p = p->next;
        }
        
        *last = pre;
        return cnt;
    }
    ListNode *rotateRight(ListNode *head, int k) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (head == NULL) return NULL;
        ListNode *last, *p = head, *q;
        int n = getLength(head, &last);
        
        k = k % n;
        if (k == 0) {
            return head;
        }
        while (k < n-1) {
            p = p->next;
            k++;
        }
        
        q = p->next;
        p->next = NULL;
        last->next = head;
        return q;
    }
};