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
    vector<TreeNode *> generateTrees(int start, int end) {
        vector<TreeNode *> res;
        if (start > end) {
            res.push_back(NULL);
            return res;
        }
        
        
        for (int i = start; i <= end; i++) {
            vector<TreeNode *> leftsub = generateTrees(start, i-1);
            vector<TreeNode *> rightsub = generateTrees(i+1, end);
            
            for (int j = 0; j < leftsub.size(); j++) {
                for (int k = 0; k < rightsub.size(); k++) {
                    TreeNode *root = new TreeNode(i);
                    root->left = leftsub[j];
                    root->right = rightsub[k];
                    res.push_back(root);
                }
            }
        }
        
        return res;
    }
    vector<TreeNode *> generateTrees(int n) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        return generateTrees(1, n);
    }
};