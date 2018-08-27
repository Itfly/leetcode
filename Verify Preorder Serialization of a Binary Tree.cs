public class Solution {
    public bool IsValidSerialization(string preorder) {
        var stack = new string[preorder.Length];
        var index = 0;
        foreach (var ch in preorder.Split(',')) {
            stack[index++] = ch;
            while (index >= 3 && stack[index-1] == "#" && stack[index-2] == "#" && stack[index-3] != "#") {
                index -= 3;
                stack[index++] = "#";
            }
        }
        
        return index == 1 && stack[index-1] == "#";
    }
}
