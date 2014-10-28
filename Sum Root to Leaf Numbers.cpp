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
    int help(TreeNode *root, int num) {
        if (root == NULL) return 0;
        num = num * 10 + root->val;
        if (root->left == NULL && root->right == NULL) return num;
        return help(root->left, num) + help(root->right, num);
    }
    int sumNumbers(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        return help(root, 0);
    }
};