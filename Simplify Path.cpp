class Solution {
public:
    string simplifyPath(string path) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        int n = path.length();
        vector<string> s;
        int start, end;
        string sub, result;
        int i = 0;
        while (i != n-1) {
            start = path.find('/', i);
            end = path.find('/', start+1);
           /* while (end != -1 && end == start + 1) {
                start = end;
                end = path.find('/', start+1);
            }*/ // no need to do this,  because sub != ""
            if (end == -1) {
    					sub = path.substr(start+1);
						} else {
    		  	  sub = path.substr(start+1, end-start-1);
						}
            
            if (sub == "..") {
                if (!s.empty())
                    s.pop_back();
            } else if (sub != "." && sub != "") {
                s.push_back(sub);
            }
            
            if (end == -1) break;
            i = end;
        }
        
        if (s.empty()) {
            return string("/");
        }
        for (auto iter = s.begin(); iter != s.end(); iter++) {
            result = result + "/"+ *iter;
        }
        return result;
    }
};


class Solution {
public:
    string simplifyPath(string path) {
        stack<int> sk;
        string p;

        path.append("/"); // normalize the back slash in the end.
        sk.push(0);
        int s=0;
        for (int i=1; i<path.size(); i++) {
            if (path[i] == '/') {
                if (path[i-1] == '/'
                    || path[i-1] == '.' && (i-2 < 0 || path[i-2] != '.')) {
                    // skip double //  or /./
                    s = i;
                }
                else if (path[i-1] == '.' && i-2 >= 0 && path[i-2] == '.') {
                    s = i;
                    if (sk.top() == 0) continue;
                    // popping one part
                    int e = sk.top(); sk.pop();
                    p.erase(sk.top(), e-sk.top());
                }
                else {
                    // add new part
                    p.append(path, s, i-s);
                    sk.push(p.size());
                    s = i;
                }
            }
        }

        return p.size() == 0 ? "/" : p;
    }
};
