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
    ListNode *merge(ListNode *p1, ListNode *p2) {
        ListNode *p, *ph ;
        ph = p = new ListNode(-1);
        while (p1 != NULL && p2 != NULL) {
            if (p1->val < p2->val) {
                p->next = p1;
                p = p1;
                p1 = p1->next;
            } else {
                p->next = p2;
                p = p2;
                p2 = p2->next;
            }
        }
        p->next = (p1 == NULL) ? p2 : p1;
        
        p = ph;
        ph = ph->next;
        free(p);
        
        return ph;
    }
    ListNode *mergeSort(ListNode *p, int len) {
        if (len == 1) {
            p->next = NULL;
            return p;
        }
        
        ListNode *pmid = p;
        for (int i = 0; i < len/2; i++) {
            pmid = pmid->next;
        }
        
        ListNode *p1 = mergeSort(p, len/2);
        ListNode *p2 = mergeSort(pmid, len - len/2);
        
        return merge(p1, p2);
    }
    ListNode *sortList(ListNode *head) {
        // IMPORTANT: Please reset any member data you declared, as
        // the same Solution instance will be reused for each test case.
        if (head == 0) return NULL;
        
        int len = 0;
        ListNode *p = head;
        while (p != NULL) {
            p = p->next;
            ++len;
        }
        return mergeSort(head, len);
    }
};