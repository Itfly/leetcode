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
    bool isBST(TreeNode *root, int min, int max) {
        if (root == NULL) {
            	return true;
        }
        
        if (root->val <= min || root->val > max) {
        	return false;
        }
        
        return isBST(root->left, min, root->val) && isBST(root->right, root->val, max);    
    }
    bool isValidBST(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int pre = INT_MIN;
        return isBST(root, INT_MIN, INT_MAX);
    }
};