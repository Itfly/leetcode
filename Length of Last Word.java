public class Solution {
    public int lengthOfLastWord(String s) {
        // Start typing your Java solution below
        // DO NOT write main() function
        s = s.trim();
        int last = s.lastIndexOf(" ");
        if (last == -1) return s.length();
        return s.substring(last+1).length();
    }
}