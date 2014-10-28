class Solution {
public:
    vector<int> getRow(int rowIndex) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<int> Row(rowIndex+1, 1);
        
        for (int i = 1; i <= rowIndex; i++) {
            int tmp1 = 1, tmp2;
            for (int j = 1; j < i; j++) {
                tmp2 = Row[j];
                Row[j] = tmp1 + Row[j];
                tmp1 = tmp2; 
            }
        }
        return Row;
    }
};