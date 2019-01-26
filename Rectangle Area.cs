public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        if (C < E || G < A || D < F || H < B) {
            // no overlap
            return (C - A) * (D - B) + (G - E) * (H - F);
        }
        
        // A(E).....E(A)....C(G)....G(C), same as H(D)...D(H)...B(F)....F(B)
        var right = Math.Min(C, G);            
        var left = Math.Max(A, E);            
        var top = Math.Min(H, D);
        var bottom = Math.Max(F, B);
        
        return (C - A) * (D - B) + (G - E) * (H - F) - (right - left) * (top - bottom);
    }
}
