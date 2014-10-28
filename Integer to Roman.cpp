class Solution {
    int val[13] = {1000,900,500,400,100,90,50,40,10,9,5,4,1};
    string r[13] = {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};

public:
    string intToRoman(int num) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function    
        int i = 0; 
        string RomanNum = "";
        while (num > 0) {
            while (val[i] <= num) {
                num -= val[i];
                RomanNum += r[i];
            }
            i++;
        }
        return RomanNum;
    }
};