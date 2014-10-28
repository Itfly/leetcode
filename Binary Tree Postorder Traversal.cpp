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
    vector<int> postorderTraversal(TreeNode *root) {
        // IMPORTANT: Please reset any member data you declared, as
        // the same Solution instance will be reused for each test case.
        vector<int> res;
        stack<TreeNode *> st;
        TreeNode *cur = root, *pre = NULL;
        while (cur != NULL || !st.empty()) {
            while (cur != NULL) {
                st.push(cur);
                cur = cur->left;
            }
            cur = st.top();
            if (cur->right == NULL || cur->right == pre) {
                res.push_back(cur->val);
                pre = cur;
                st.pop();
                cur = NULL;
            } else {
                cur = cur->right;
            }
        }
        return res;
    }
};