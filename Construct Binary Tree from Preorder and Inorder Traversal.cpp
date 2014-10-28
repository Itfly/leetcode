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
    TreeNode *buildTree(vector<int> &preorder, vector<int> &inorder, int s1, int e1, int s2, int e2) {
        if (s1 > e1 || s2 > e2) {
            return NULL;
        }
        
        int i = s2;
        while (i <= e2) {
            //if (preorder[s1] == inorder[i]) break;
            if (inorder[i] == preorder[s1]) break;
            i++;
        }
        
        TreeNode *root = new TreeNode(preorder[s1]);
        root->left = buildTree(preorder, inorder, s1 + 1, s1 + i - s2, s2, i - 1);
        root->right = buildTree(preorder, inorder, s1 + i - s2 + 1, e1, i + 1, e2);
        
        return root;
    }
    TreeNode *buildTree(vector<int> &preorder, vector<int> &inorder) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        return buildTree(preorder, inorder, 0, preorder.size() - 1, 0, inorder.size() - 1);
    }
};