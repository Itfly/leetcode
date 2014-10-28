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
    void helper(vector<TreeNode *> levelNodes, vector<vector<int> > &res) {
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
        
        if (nextlevelNodes.size() != 0) {
            helper(nextlevelNodes, res);
        }
        res.push_back(vals);
        
    }
    vector<vector<int> > levelOrderBottom(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > res;
        if (root == NULL) return res;
        vector<TreeNode *> nodes;
        nodes.push_back(root);
        helper(nodes, res);
        return res;
    }
};



class Solution {
public:
    vector<vector<int> > levelOrderBottom(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > ret;
        if (root == NULL) return ret;
        
        
        queue<TreeNode *> que1;
        que1.push(root);
        
        while (!que1.empty()) {
            queue<TreeNode *> que2;
            vector<int> tmp;
            
            while (!que1.empty()) {
                TreeNode *p = que1.front();
                tmp.push_back(p->val);
                que1.pop();
            
                if (p->left) {
                    que2.push(p->left);
                }
                if (p->right) {
                    que2.push(p->right);
                }
            }
            
            ret.insert(ret.begin(), tmp);
            que1 = que2;
            
        }
        return ret;
    }
};