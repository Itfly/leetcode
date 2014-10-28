class Solution {
public:
    void gen(string start, string end, unordered_map<string, vector<string> > &pre, vector<string> &path, vector<vector<string> > &res) {
        path.push_back(end);
        if (start == end && path.size() > 1) {
            vector<string> tmp;
            for (auto riter = path.rbegin(); riter != path.rend(); riter++) {
                tmp.push_back(*riter);
            }
            res.push_back(tmp);
        } else {
            vector<string> prev = pre[end];
            for (auto iter = prev.begin(); iter != prev.end(); iter++) {
                gen(start, *iter, pre, path, res);
            }
        }
        path.pop_back();
    }
    vector<vector<string>> findLadders(string start, string end, unordered_set<string> &dict) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<string> > res;
        unordered_set<string> found;
        unordered_map<string, vector<string> > pre;
        queue<string> que1;
        int n = start.length();
        bool stop = false;
        
        que1.push(start);
        found.insert(start);
        
        while(!que1.empty()) {
            queue<string> que2;
            unordered_set<string> foundtmp;
            
            while (!que1.empty()) {
                string s = que1.front();
                que1.pop();
                
                for (int i = 0; i < n; i++) {
                    for (int j = 0; j < 26; j++) {
                        string tmp = s;
                        tmp[i] = 'a' + j;
                        if (tmp != s) {
                            if (tmp == end) {
                                stop = true;
                            }
                            if (dict.find(tmp) != dict.end() && found.find(tmp) == found.end()) {
                                pre[tmp].push_back(s);
                                if (foundtmp.find(tmp) == foundtmp.end()) {
                                    foundtmp.insert(tmp);
                                    que2.push(tmp);
                                }
                            }
                        }
                    }
                }
            }
            found.insert(foundtmp.begin(), foundtmp.end());
            que1 = que2;
            if (stop) break;
        }
        
        if (!stop) return res;
        vector<string> path;
        gen(start, end, pre, path, res);
        return res;
        
    }
};



vector<vector<string>> findLadders(string start, string end, unordered_set<string> &dict) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<vector<string> > res;
        unordered_set<string> found;
        unordered_map<string, vector<string> > pre;
        vector<string> que;
        int n = start.length();
        bool stop = false;
        
        que.push_back(start);
        found.insert(start);
        
        int cur = 0, last = 1;
        while (cur < que.size()) {
            last = que.size();
            unordered_set<string> foundtmp;
            while (cur < last) {
                string s = que[cur++];
                //found.insert(s);
                for (int i = 0; i < n; i++) {
                    for (int j = 0; j < 26; j++) {
                        string tmp(s);
                        tmp[i] = 'a' + j;
                        if (tmp != s) {
                            if (tmp == end) stop = true;
                            
                            if (dict.find(tmp) != dict.end() && found.find(tmp) == dict.end()) {
                                if (pre.find(tmp) == pre.end()) {
                                    que.push_back(tmp);
                                }
                                pre[tmp].push_back(s);
                            }
                            
                        }
                    }
                }
            }
            if (stop) break;
            found.insert(que.begin()+last, que.end());
        }
        
        if (!stop) return res;
        vector<string> path;
        gen(start, end, pre, path, res);
        return res;
        
    }
};