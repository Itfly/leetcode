class Solution {
public:
    vector<int> findSubstring(string S, vector<string> &L) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        unordered_map<string, int> dict;
        vector<int> ret;
        int n,k;
        n = L.size();
        k = L[0].length();
        int bound = S.length() - n * k + 1;
        for (auto iter = L.begin(); iter < L.end(); iter++) {
           // if (dict.count(*iter) == 0) dict[*iter] = 1;
            //else dict[*iter]++;
            dict[*iter]++;
        }
        
        for (int offset = 0; offset < k; offset++) {
            for (size_t i = offset; i < bound; i+=k) {
                unordered_map<string, int> needed;
                string word = S.substr(i, k);
                int j = 0;
                while (j < n) {
                    if (dict.find(word) == dict.end()){
                        i += j*k;
                        break;
                    }
                    needed[word]++;
                    if (needed[word] > dict[word]) break;
                    j++;
                    word = S.substr(i+j*k, k);
                }
                if (j == n) {
                    ret.push_back((int)i);  
                } 
            }
        }
        return ret;
    }
};