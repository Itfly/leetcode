class Solution {
    int m, n;
    vector<vector<char> > board;
    //int next[4][2] = {{1,0}, {-1,0}, {-1,0}, {1,0}};
public:
    inline bool isValidCoord(int x, int y) {
        if (x < 0 || x >= m || y < 0 || y >= n) return false;
        return true;
    }
    bool test(vector<vector<bool> > &visited, int x, int y, string word) {
    	static int next[4][2] = {{1,0}, {-1,0}, {0,-1}, {0,1}};
        if (word.size() == 0) return true;
        visited[x][y] = true;
        for (int i = 0; i < 4; i++) {
            int xx = x + next[i][0];
            int yy = y + next[i][1];
            if (isValidCoord(xx, yy) && !visited[xx][yy]) {
                if (word[0] != board[xx][yy]) continue;
               
				        if (word.length() == 1) return true;
              //  visited[xx][yy] = true;
                if (test(visited, xx, yy, word.substr(1))) {
                    return true;
                }
                //visited[xx][yy] = false;
            }
        }
        
        visited[x][y] = false;
        return false;
    }
    bool exist(vector<vector<char> > &board, string word) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        
        m = board.size();
        if (word.size() == 0) return true;
        if (m == 0) return false;
        n = board[0].size();
        this->board = board;
       
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] == word[0]) {
                    vector<vector<bool> > visited(m, vector<bool>(n));
                  //  visited[i][j] = true;
                    
                    if (test(visited, i, j, word.substr(1))) {
                        return true;
                    }
                }
            }
        }
        
        return false;
        
    }
};