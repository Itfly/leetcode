public class Solution {
    public string LargestNumber(int[] nums) {
        Array.Sort(nums, Comparer);
        if (nums[0] == 0) {
            return "0";
        }
        
        var sb = new StringBuilder();
        foreach (var num in nums) {
            sb.Append(num);
        }
        return sb.ToString();
    }
    
    private static int Comparer(int a, int b) {
        var str1 = $"{a}{b}";
        var str2 = $"{b}{a}";
        return str2.CompareTo(str1);
    }
}
