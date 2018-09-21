/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        var random = 40;
        while (random >= 40) {
            random = 7 * (Rand7() - 1) + (Rand7() - 1);
        }
        
        return random % 10 + 1;
    }
}

// https://leetcode.com/problems/implement-rand10-using-rand7/discuss/150301/Three-line-Java-solution-the-idea-can-be-generalized-to-%22Implement-RandM()-Using-RandN()%22
