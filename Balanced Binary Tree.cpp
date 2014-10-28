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
    bool helper(TreeNode *root, int &depth) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (root == NULL) {
            depth = 0;
            return true;
        }
        int leftdepth, rightdepth;
        if (!helper(root->left, leftdepth) || !helper(root->right, rightdepth)) return false;
        
        depth = max(leftdepth, rightdepth) + 1;
        if (abs(leftdepth-rightdepth) > 1) { 
            return false;
        } else {
            return true;    
        }
    }
    
    bool isBalanced(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int depth;
        return helper(root, depth);
    }
};

