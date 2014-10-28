class Solution {
public:
    void recoverTree(TreeNode *root) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        TreeNode *p = root;
        TreeNode *p1, *p2;
				TreeNode *pre = NULL;
				bool findFirstVal = false;
		  	while (p) {
    	  		TreeNode *t = p->left;
						if (t != NULL) {
								while (t->right && t->right != p) {
										t = t->right;
								}
								if (t->right == NULL) {
										t->right = p;
										p = p->left;
										continue;
								} else {
										t->right = NULL;
								}
						}
       	    // if (p == NULL) break;
						if (pre && pre->val > p->val) {
        		 		if (!findFirstVal) {
         			   		p1 = pre;
        		    		findFirstVal = true;
						 		}
						 		p2 = p;
						}
    
						pre = p;
						p = p->right;
				}
         
    		if (findFirstVal) {
    	 			swap(p1->val, p2->val);
    		}
  	}
};



void proc(TreeNode *root, TreeNode *&n1, TreeNode *&n2, TreeNode *&prev)
{
    if(!root)
        return;
    proc(root->left,n1,n2,prev);
    if(prev && prev->val > root->val)
    {
        n2 = root;
        if(!n1)
            n1 = prev;
    }
    prev = root;
    proc(root->right,n1,n2,prev);
}
void recoverTree(TreeNode *root) {
    // Start typing your C/C++ solution below
    // DO NOT write int main() function
    TreeNode *n1 = NULL;
    TreeNode *n2 = NULL;
    TreeNode *prev = NULL;
    proc(root,n1,n2,prev);
    if(n1 && n2)
        swap(n1->val,n2->val);
}