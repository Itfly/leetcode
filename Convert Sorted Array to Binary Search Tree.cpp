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
    TreeNode *sortArrayToBST(vector<int> &num, int start, int end) {
        if (start > end) return NULL;
        
        int mid = start + (end - start) / 2;
        TreeNode *root = new TreeNode(num[mid]);
        
        TreeNode *leftchild = sortArrayToBST(num, start, mid - 1);
        TreeNode *rightchild = sortArrayToBST(num, mid + 1, end);
        
        root->left = leftchild;
        root->right = rightchild;
        
        return root;
    }
    TreeNode *sortedArrayToBST(vector<int> &num) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        return sortArrayToBST(num, 0, num.size() - 1);
    }
};