class Solution {
public:
    int ladderLength(string start, string end, unordered_set<string> &dict) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        unordered_set<string> found;
        queue<string> que1;
        int len = 1;
        int n = start.length();
        
        que1.push(start);
        found.insert(start);
        
        while(!que1.empty()) {
            queue<string> que2;
            
            while (!que1.empty()) {
                string s = que1.front();
                que1.pop();
                
                for (int i = 0; i < n; i++) {
                    for (int j = 0; j < 26; j++) {
                        string tmp = s;
                        tmp[i] = 'a' + j;
                        if (tmp != s) {
                            if (tmp == end) return len + 1;
                            if (dict.find(tmp) != dict.end() && found.find(tmp) == found.end()) {
                                found.insert(tmp);
                                que2.push(tmp);
                            }
                        }
                    }
                }
            }
            
            len++;
            que1 = que2;
        }
        return 0;
    }
};


class Solution {
public:
    int ladderLength(string start, string end, unordered_set<string> &dict) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        unordered_set<string> found;
        vector<string> que;
        int len = 1;
        int n = start.length();
        
        que.push_back(start);
        int cur = 0, last = 1;
        while (cur < que.size()) {
            last = que.size();
            
            while (cur < last) {
                string s = que[cur++];
                
                for (int i = 0; i < n; i++) {
                    for (int j = 'a'; j <= 'z'; j++) {
                        string tmp(s);
                        tmp[i] = j;
                        if (tmp == s) continue;
                        if (tmp == end) return len + 1;
                        if (dict.find(tmp) != dict.end() && found.find(tmp) == found.end()) {
                            found.insert(tmp);
                            que.push_back(tmp);
                        }
                    }
                }
            }
            len++;
        }
        
        return 0;
    }
};