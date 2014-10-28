/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
/**
 * Definition for binary tree
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */
class Solution {
    TreeNode *sortListToBST(ListNode *&head, int start, int end) {
        if (start > end) return NULL;
        int mid = start + (end - start) / 2;
        TreeNode *leftchild = sortListToBST(head, start, mid-1);
        TreeNode *root = new TreeNode(head->val);
        root->left = leftchild;
        head = head->next;
        TreeNode *rightchild = sortListToBST(head, mid+1, end);
        root->right = rightchild;
        return root;
    }
          
public:
    TreeNode *sortedListToBST(ListNode *head) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int n = 0; 
        ListNode *p = head;
        while (p != NULL) {
            p = p->next;
            n++;
        }
        
        return sortListToBST(head, 0, n-1);
    }
};