public class Solution {
    public string ReverseWords(string s) {
        if (string.IsNullOrEmpty(s)) {
            return s;
        }
        
        var strs = s.Split(null);
        var sb = new StringBuilder(s.Length);
        var isFirst = true;
        foreach(var str in strs) {
            var space = isFirst ? "" : " ";
            sb.Append(space + Reverse(str));
            isFirst = false;
        }
        
        return sb.ToString();
    }
    
    public static string Reverse(string s)
    {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
