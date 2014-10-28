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
    vector<int> inorderTraversal(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<int> seq;
        if (root == NULL) return seq;
        stack<TreeNode *> s;
        TreeNode *p = root;
        
        while (p != NULL || !s.empty()) {
            while (p != NULL) {
                s.push(p);
                p = p->left;
            }
            if (!s.empty()) {
                p = s.top();
                s.pop();
                seq.push_back(p->val);
                p = p->right;
            }
        }
        return seq;
    }
};