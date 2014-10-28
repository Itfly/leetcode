class Solution {
public:
    vector<string> anagrams(vector<string> &strs) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        vector<string> result;
        map<string, vector<string> > dict;
        
        for (auto iter = strs.begin(); iter != strs.end(); iter++) {
            string word = *iter;
            sort(word.begin(), word.end());
            dict[word].push_back(*iter);
        }
        
        for (auto iter = dict.begin(); iter != dict.end(); iter++) {
            vector<string> words = iter->second;
            if (words.size() > 1) {
                result.insert(result.end(), words.begin(), words.end());
            }
        }
        
        return result;
    }
};
