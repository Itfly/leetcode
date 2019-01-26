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
    bool helper(TreeNode *l, TreeNode *r) {
        if (l == NULL && r == NULL) return true;
        if (l == NULL || r == NULL) return false;
        if (l->val != r->val) return false;
        return helper(l->left, r->right) && helper(l->right, r->left);
    }

    bool isSymmetric(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (root == NULL) return true;
        
        return helper(root->left, root->right);
    }
};


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
    bool isSymmetric(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (root == NULL) return true;
        
        queue<TreeNode *> ql, qr;
        ql.push(root->left);
        qr.push(root->right);
        
        while (!ql.empty() && !qr.empty()) {
            TreeNode *lnode = ql.front();
            TreeNode *rnode = qr.front();
            ql.pop();
            qr.pop();
            
            if (lnode == NULL && rnode == NULL) continue;
            if (lnode == NULL || rnode == NULL) return false;
            if (lnode->val != rnode->val) return false;
            
            ql.push(lnode->left);
            ql.push(lnode->right);
            qr.push(rnode->right);
            qr.push(rnode->left);
        }
        
        if (!ql.empty() || !qr.empty()) {
            return false;
        }
        return true;
    }
};