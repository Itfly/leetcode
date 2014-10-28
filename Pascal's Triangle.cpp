class Solution {
public:
    vector<vector<int> > generate(int numRows) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<int> > triangle;
        if (numRows == 0) {
            return triangle;
        }
        
        vector<int> row(1,1);
        triangle.push_back(row);
        for (int i = 1; i < numRows; i++) {
            vector<int> row(i+1, 1);
            triangle.push_back(row);
            for (int j = 1; j < i; j++) {
                triangle[i][j] = triangle[i-1][j] + triangle[i-1][j-1];
            }
         }
         
         return triangle;
    }
};