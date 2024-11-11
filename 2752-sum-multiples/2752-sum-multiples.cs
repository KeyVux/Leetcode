public class Solution {
    public int SumOfMultiples(int n) {
        int sum = 0;
        for (int indexN = 1; indexN <= n; indexN++)
        {
            if (indexN % 3 == 0 || indexN % 5 == 0 || indexN % 7 == 0)
            {
                sum += indexN;
            }
        }

        return sum;
    }
}