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
    vector<int> preorderTraversal(TreeNode *root) {
        // IMPORTANT: Please reset any member data you declared, as
        // the same Solution instance will be reused for each test case.
        vector<int> res;
        if (root == NULL) return res;
        
        stack<TreeNode *> st;
        while (root) {
            st.push(root);
            res.push_back(root->val);
            root = root->left;
        }
        
        while (!st.empty()) {
            root = st.top()->right;
            st.pop();
            while (root) {
                st.push(root);
                res.push_back(root->val);
                root = root->left;
            }
        }
        
        return res;
    }
};