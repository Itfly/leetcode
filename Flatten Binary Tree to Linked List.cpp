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
    void help(TreeNode *root, TreeNode **last) {
        if (root->left) {
            help(root->left, last);
            (*last)->right = root->right;
            root->right = root->left;
            root->left = NULL;
        } else {
            *last = root;
        }
        
        if ((*last)->right) {
            help((*last)->right, last);
        }
      //  (*last)->right = NULL;
    }
    
public:
    void flatten(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (root == NULL) {
            return;
        }
        TreeNode *last;
        help(root, &last);
        last->right = NULL;
        return;
    }
};


class Solution {
    
    TreeNode *help(TreeNode *root) {
       if (root == NULL) return NULL;
       TreeNode *lefttail = help(root->left);
       TreeNode *righttail = help(root->right);
       if (root->left) {
           lefttail->right = root->right;
           root->right = root->left;
           root->left = NULL;
       }
       
       if (righttail) return righttail;
       else if (lefttail) return lefttail;
       else return root;
    }
public:
    void flatten(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        
        help(root);
    }
};