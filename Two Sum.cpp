class Solution {
public:
    vector<int> twoSum(vector<int> &numbers, int target) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        map<int, int> maps;
        vector<int> result(2);
        
        for (int i = 0; i < numbers.size(); i++) {
            if (maps.find(target - numbers[i]) != maps.end()) {
                result[0] = maps[target-numbers[i]] + 1;
                result[1] = i + 1;
                break;
            } else {
                maps.insert(make_pair(numbers[i], i));
            }
        }
        return result;
    }
};