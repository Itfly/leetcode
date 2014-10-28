/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class cmp{
public:
    bool operator() (const ListNode *l, const ListNode *r) const {
        return l->val > r->val;
    }    
};
class Solution {
public:
    ListNode *mergeKLists(vector<ListNode *> &lists) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<ListNode *>::iterator iter = lists.begin();
        while (iter != lists.end()) {
            if (*iter == NULL) {
                lists.erase(iter);
            } else {
                iter++;
            }
        }
        if (lists.size() < 1) return NULL;
        
        ListNode *head = NULL, *cur = NULL;
        make_heap(lists.begin(), lists.end(), cmp());
        
        while (lists.size() > 0) {
            if (head == NULL) {
                head = cur = lists[0];
            } else {
                cur = cur->next = lists[0];
            }
            
            pop_heap(lists.begin(), lists.end(), cmp());
            int last = lists.size() - 1;
            if (lists[last]->next != NULL) {
                lists[last] = lists[last]->next;
                push_heap(lists.begin(), lists.end(), cmp());
            } else {
                lists.pop_back();
            }
        }
        return head;
    }
};

