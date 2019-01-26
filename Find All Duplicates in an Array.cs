public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var i = 0;
        while (i < nums.Length) {
            if (nums[i] != nums[nums[i] - 1]) {
                var temp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = temp;
            } else {
                i++;
            }
        }
        
        var result = new List<int>();
        for (i = 0; i < nums.Length; i++) {
            if (nums[i] != i + 1) {
                result.Add(nums[i]);
            }
        }
        
        return result;
    }
    
    // method 2: 
    /*
    traverse the list for i= 0 to n-1 elements
{
  check for sign of A[abs(A[i])] ;
  if positive then
     make it negative by   A[abs(A[i])]=-A[abs(A[i])];
  else  // i.e., A[abs(A[i])] is negative
     this   element (ith element of list) is a repetition
}

     */
}
