class Solution {
public:
    typedef enum {NUM, DOT, E, START, ERROR, RSPACE} STATE;
    STATE state;
    bool isNumber(const char *s) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        if (s[0] == '\0') return false;
        state = START;
        bool isdotnum = false;
        bool isexpnum = false;
        bool isnum = false;
        int i = 0;
        while (true) {
            switch (state) {
                case START:
                    //ignore spaces and +/-
                    while (s[i] == ' ') i++;
                    if (s[i] == '+' || s[i] == '-') i++;
                    
                    if (isdigit(s[i])) {
                        state = NUM;
                    } else if (s[i] == '.') {
                        state = DOT;
                        //dotnum = true;
                        i++;
                    } else {
                        state = ERROR;
                    }
                    
                    break;
                case NUM:
                    isnum = true;
                    while (isdigit(s[i])) i++;
                    
                    if (s[i] == '.' && isdotnum == false) {
                        state = DOT;
                        
                        i++;
                    } else if (s[i] == 'e' && isexpnum == false) {
                        state = E;
                        i++;
                    } else if (s[i] == ' ') {
                        state = RSPACE;
                    } else if (s[i] == '\0') {
                        return true;
                    } else {
                        state = ERROR;
                    }
                    
                    break;
                case DOT:
                    isdotnum = true;
                    if (isdigit(s[i])) {
                        state = NUM;
                    } else if (s[i] == 'e' && isnum == true) {
                        state = E;
                        i++;
                    } else if (isnum == true){
                        state = RSPACE;
                    } else {
                        state = ERROR;
                    }
                    break;
                case E:
                    isexpnum = true;
                    isdotnum = true;
                    if (s[i] == '+' || s[i] == '-') i++;
                    if (isdigit(s[i])) {
                        state = NUM;
                    } else {
                        state = ERROR;
                    }
                    break;
                case RSPACE:
                    while (s[i] == ' ') i++;
                    if (s[i] == '\0') return true;
                    else return false;
                case ERROR:
                    return false;
                    
            }
        }
    }
};