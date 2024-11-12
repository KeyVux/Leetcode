public class Solution {
    public int DifferenceOfSum(int[] nums) {

        int sumOfElement = 0;
        int sumOfDigit = 0;
        for (int numIndex = 0; numIndex < nums.Length; numIndex++)
        {
            sumOfElement += nums[numIndex];
            sumOfDigit += takeSumOfDigit(nums[numIndex]);
        }
        return Math.Abs(sumOfElement-sumOfDigit);
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