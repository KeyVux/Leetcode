public class Solution {
    public int XorOperation(int n, int start) {
        int xor = 0;
        for (int indexN = 0; indexN < n; indexN++)
        {
            int nums = start + 2*indexN;
            xor ^= nums;
        }
        return xor;
    }
}