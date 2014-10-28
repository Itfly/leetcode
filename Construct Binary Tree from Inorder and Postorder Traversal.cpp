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
    TreeNode *buildTree(vector<int> &inorder, vector<int> &postorder, int s1, int e1, int s2, int e2) {
        if (s1 > e1 || s2 > e2) {
            return NULL;
        }
        
        int i = s1;
        while (i <= e1) {
            if (inorder[i] == postorder[e2]) break;
            i++;
        }
        
        TreeNode *root = new TreeNode(postorder[e2]);
        root->left = buildTree(inorder, postorder, s1, i-1, s2, s2 + i - 1- s1);
        root->right = buildTree(inorder, postorder, i+1, e1, s2 + i - s1, e2-1);
        
        return root;
    }
    TreeNode *buildTree(vector<int> &inorder, vector<int> &postorder) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        return buildTree(inorder, postorder, 0, inorder.size() - 1, 0, postorder.size() - 1);
    }
};