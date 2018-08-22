public class Solution {
    public bool CanWinNim(int n) {
        return n % 4 > 0;
    }
}

// 1,2,3 yes, 4, no, 5,6,7 yes, 8 no....
