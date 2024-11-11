public class Solution {
    public int CountDigits(int num) {
        int dupNum = num;
        int devisableQuantities = 0;

        while (dupNum > 0)
        {
            int leftestDigit = dupNum % 10;
            if (num % leftestDigit == 0)
            {
                devisableQuantities+=1;
            }
            dupNum = dupNum/10;
        }
        return devisableQuantities;
    }
}