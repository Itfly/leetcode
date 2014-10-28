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
    void helper(vector<TreeNode *> levelNodes, vector<vector<int> > &res, int level) {
        vector<TreeNode *> nextlevelNodes;
        vector<int> vals;
        for (int i = 0; i < levelNodes.size(); i++) {
            TreeNode *tmp = levelNodes[i];
            if (tmp->left) {
                nextlevelNodes.push_back(tmp->left);
            }
            if (tmp->right) {
                nextlevelNodes.push_back(tmp->right);
            }
            vals.push_back(tmp->val);
        }
        if ((level & 0x1) == 1) {
            reverse(vals.begin(), vals.end());
        }
        res.push_back(vals);
        if (nextlevelNodes.size() != 0) {
            helper(nextlevelNodes, res, level + 1);
        }
        
    }
    vector<vector<int> > zigzagLevelOrder(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > res;
        if (root == NULL) return res;
        vector<TreeNode *> nodes;
        nodes.push_back(root);
        helper(nodes, res, 0);
    }
};