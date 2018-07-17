public class Solution {
    public string ReverseString(string s) {
        if (s == null && s.Length <= 1) {
            return s;
        }
        var charArr = s.ToCharArray();
        int i = 0;
        int j = s.Length - 1;
        while (i < j) {
            var tmp = charArr[i];
            charArr[i] = charArr[j];
            charArr[j] = tmp;
            i++;
            j--;
        }
        return new string(charArr); 
    }
}
