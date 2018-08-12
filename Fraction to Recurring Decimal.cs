public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        if (numerator == 0) {
            return "0";
        }
        if (denominator == 0) {
            return "";
        }
        
        string result;
        if ((numerator < 0) ^ (denominator < 0)) {
            result = "-";
        } else {
            result = "";
        }
        
        var numeratorL = Math.Abs((long) numerator);
        var denominatorL = Math.Abs((long) denominator);
        
        result += numeratorL / denominatorL;
        numeratorL = (numeratorL % denominatorL) * 10;
        if (numeratorL == 0) {
            return result;
        }
        
        var map = new Dictionary<long, int>();
        result += ".";
        while (numeratorL != 0) {
            if (map.ContainsKey(numeratorL)) {
                var index = map[numeratorL];
                var temp1 = result.Substring(0, index);
                var temp2 = result.Substring(index, result.Length - index);
                return $"{temp1}({temp2})";
            }
            
            map[numeratorL] = result.Length;
            result += numeratorL / denominatorL;
            numeratorL = (numeratorL % denominatorL) * 10;
        }
        
        return result;
    }
}
