public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int sumOfDeviseible = 0;
        int sumOfNotDevisible = 0;
        for (int indexN = 1; indexN <= n; indexN++)
        {
            if (indexN % m == 0)
            {
                sumOfDeviseible += indexN;
            }

            else
            {
                sumOfNotDevisible += indexN;
            }
        }

        return sumOfNotDevisible - sumOfDeviseible;
    }
}