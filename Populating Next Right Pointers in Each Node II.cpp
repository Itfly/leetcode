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
            TreeLinkNode *nextfirstnode = NULL, *pre = NULL;
            while (p != NULL) {
                if (nextfirstnode == NULL) {
                    nextfirstnode = p->left ? p->left : p->right;
                }
                if (p->left != NULL) {
                    if (pre == NULL) {
                        pre = p->left;
                    } else {
                        pre->next = p->left;
                        pre = p->left;
                    }
                }
                if (p->right != NULL) {
                    if (pre == NULL) {
                        pre = p->right;
                    } else {
                        pre->next = p->right;
                        pre = p->right;
                    }
                }
                
                p = p->next;
            }
            cur = nextfirstnode;
        }
    }
};