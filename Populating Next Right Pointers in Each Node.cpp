/**
 * Definition for binary tree with next pointer.
 * struct TreeLinkNode {
 *  int val;
 *  TreeLinkNode *left, *right, *next;
 *  TreeLinkNode(int x) : val(x), left(NULL), right(NULL), next(NULL) {}
 * };
 */
class Solution {
public:
    void connect(TreeLinkNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        TreeLinkNode *cur = root;
        while (cur != NULL) {
            TreeLinkNode *p = cur;
            while (p != NULL) {
                if (p->left != NULL) {
                    p->left->next = p->right;
                }
                if (p->right != NULL && p->next != NULL) {
                    p->right->next = p->next->left;
                }
                
                p = p->next;
            }
            cur = cur->left;
        }
    }
};