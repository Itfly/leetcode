public class Solution {
    
    public string ToHex(int num) {
        if (num == 0) {
            return "0";
        }
        
        var hexadecimals = new char[16]; // or {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f"};
        for (var i = 0; i < 16; i++) {
            if (i < 10) {
                hexadecimals[i] = (char) (i + '0');
            } else {
                hexadecimals[i] = (char) (i - 10 + 'a');
            }
        }
        
        var unum = (uint) num;
        var sb = new StringBuilder();
        while (unum != 0) {
            sb.Insert(0, hexadecimals[unum & 15]);
            unum >>= 4;
        }
        
        return sb.ToString();
    }
}
