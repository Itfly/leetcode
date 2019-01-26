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
    int minDepth(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (root == NULL) return 0;
        if (root->left == NULL && root->right == NULL) return 1;
        else if (root->left == NULL) {
            return minDepth(root->right) + 1;
        } else if (root->right == NULL) {
            return minDepth(root->left) + 1;
        } else {
            return min(minDepth(root->left), minDepth(root->right)) + 1;
        }
    }
};


class Solution {
    int mindep;
public:
    void depth(TreeNode *root, int height) {
        if (root->left == NULL && root->right == NULL) {
            if (height < mindep) {
                mindep = height;
            }
            return;
        }
        
        if (root->left) {
            depth(root->left, height+1);
        }
        if (root->right) {
            depth(root->right, height+1);
        }
    }
    
    int minDepth(Treenode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (root == NULL) return 0;
        
        mindep = INT_MAX;
        depth(root, 1);
        
        return mindep;
    }
};
