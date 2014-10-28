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
    void helper(TreeNode *root, vector<int> path, vector<vector<int> > &result, int sum) {
        if (root == NULL) return;
        
        path.push_back(root->val);
        sum -= root->val;
        if (root->left == NULL && root->right == NULL && sum == 0) {
            result.push_back(path);
            //path.pop_back();
            return;
        }
        
        helper(root->left, path, result, sum);
        helper(root->right, path, result, sum);
        //path.pop_back();
    }
    vector<vector<int> > pathSum(TreeNode *root, int sum) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > res;
        vector<int> path;
        helper(root, path, res, sum);
        
        return res;
    }
};