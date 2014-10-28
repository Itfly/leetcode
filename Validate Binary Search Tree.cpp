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
public:
    bool isValidBST(TreeNode *root, TreeNode *&pre) {
        if (root == NULL) return true;
        
        if (!isValidBST(root->left, pre)) {
        		return false;
        }
        if (pre && pre->val >= root->val) {
            return false;
        }
        pre = root;
        return isValidBST(root->right, pre);
    }
    bool isValidBST(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        TreeNode *pre = NULL;
        return isValidBST(root, pre);
    }
};