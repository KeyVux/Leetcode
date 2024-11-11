public class Solution {
    public int SubtractProductAndSum(int n) {

        return takeProductOfDigits(n) - takeSumOfDigit(n);

        int takeProductOfDigits(int n)
        { 
            int digitProduct = 1;
            while (n > 0)
            {
                digitProduct*= n % 10;
                n /= 10;
            }
            return digitProduct;
        }

        int takeSumOfDigit(int i)
        {
            int digitSum = 0;
            while (i > 0)
            {
                digitSum+= i % 10;
                i /= 10;
            }
            return digitSum;
        }
    }
}