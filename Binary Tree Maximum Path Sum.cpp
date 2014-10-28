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
    void help(TreeNode *root, int &curmax, int &maxSum) {
        if (root == NULL) {
            curmax = 0;
            return;
        }
        
        int lmax, rmax;
        help(root->left, lmax, maxSum);
        help(root->right, rmax, maxSum);
        curmax = max(max(lmax, rmax), 0) + root->val;
        maxSum = max(maxSum, max(curmax, lmax+rmax+root->val));
    }
    int maxPathSum(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int maxSum = INT_MIN, curmax;
        help(root, curmax, maxSum);
        return maxSum;
    }
};