public class Solution {
    public int DiagonalSum(int[][] mat) {
        int res = 0;
        
        for(int i = 0; imat.Length; i++) {
            res += mat[i][i];
            if(mat[i].Length - i - 1 != i) {
                res += mat[i][mat[i].Length - i - 1];
            }
        }
        
        return res;
    }
}