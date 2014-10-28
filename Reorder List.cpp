/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
    ListNode *reverseList(ListNode *head) {
        if (head == NULL || head->next == NULL) {
            return head;
        }
        
        ListNode *post = head, *p = NULL;
        while (post->next) {
            p = post->next;
            post->next = p->next;
            p->next = head;
            head = p;
        }
        return head;
    }
public:
    void reorderList(ListNode *head) {
        // IMPORTANT: Please reset any member data you declared, as
        // the same Solution instance will be reused for each test case.
        if (head == NULL || head->next == NULL) {
            return;
        }
        ListNode *p1, *p2;
        p1 = p2 = head;
        while (p2 && p2->next) {
            p1 = p1->next;
            p2 = p2->next->next;
        }
        
        p2 = p1->next; 
        p1->next = NULL;
        
        p2 = reverseList(p2);
        p1 = head;
        
        while (p2 != NULL) {
            ListNode *tmp = p2->next;
            p2->next = p1->next;
            p1->next = p2;
            p1 = p1->next->next;
            p2 = tmp;
        }
    }
};