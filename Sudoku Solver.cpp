
class Solution {
    short row[9];
    short column[9];
    short subbox[9];
    vector<int> emptycells;
public:
    	bool isValid(int i, int j, char ch) {
				short set = (1 << (ch - '0'));
				if (row[i] & set) return false;
				if (column[j] & set) return false;
				if (subbox[3*(i/3)+j/3] & set) return false;
				return true;
		}
		
		void doSet(int i, int j, char ch) {
				short set = (1 << (ch - '0'));
        row[i] |= set;
        column[j] |= set;
        subbox[3*(i/3)+j/3] |= set;
    }
    
    void undoSet(int i , int j , char ch) {
    		short set = ~(1 << (ch - '0'));
    		row[i] &= set;
        column[j] &= set;
        subbox[3*(i/3)+j/3] &= set;
    }
    
    void solve(vector<vector<char> > &board, int i) {
        if (i == emptycells.size()) return;
        
    } 
    void solveSudoku(vector<vector<char> > &board) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
				memset(row, 0, sizeof(short)*9);
        memset(column, 0, sizeof(short)*9);
        memset(subbox, 0, sizeof(short)*9);
        emptycells.clear();
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char ch = board[i][j];
                if (ch == '.') {
                    emptycells.push_back(i*9+j);
                } else {
                		doSet(i, j, ch);
                }
            }
        }
        if (emptycells.size() == 0) return;
        
		for (int i = 0; i < emptycells.size(); i++) {
			int cur = emptycells[i];
			board[cur/9][cur%9] = '0';
		}
		int k = 0;
		while (k >=0) {
        		int cur = emptycells[k];
            char ch = board[cur/9][cur%9] + 1;
        		while (ch <= '9' && !isValid(cur/9, cur%9, ch)) {
        				ch++;
        		}
        		if (ch <= '9') {
						board[cur/9][cur%9] = ch;
						if (k == emptycells.size()-1) return;
						doSet(cur/9, cur%9, ch);
						k++;
				} else {
						board[cur/9][cur%9] = '0';
						k--;
						if (k <0) return;
						cur = emptycells[k];
						ch = board[cur/9][cur%9];
							//board[cur/9][cur%9] = '0';
						undoSet(cur/9, cur%9, ch);
						//k--;
				}
		}        				
        		
    }
};