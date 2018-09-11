public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
        Array.Sort(heaters);
        var radius = int.MinValue;
        
        foreach (var house in houses) {
            var index = Array.BinarySearch(heaters, house);
            if (index < 0) {
                // If value is not found and value is less than one or more elements in array, 
                // a negative number which is the bitwise complement of the index of the first element that is larger than value.
                index = ~index; // or -(index + 1)
            }
            
            var radius1 = index >= 1 ? house - heaters[index - 1] : int.MaxValue;
            var radius2 = index < heaters.Length ? heaters[index] - house : int.MaxValue;
            
            radius = Math.Max(radius, Math.Min(radius1, radius2));
        }
        
        return radius;
    }
}
