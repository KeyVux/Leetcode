public class Solution {
    public int MaximumWealth(int[][] accounts) {

        int richest = 0;


        for (int customerIndex = 0; customerIndex < accounts.Length; customerIndex++)
        {
            int sumWealth = 0;
            
            for (int bankIndex = 0; bankIndex < accounts[customerIndex].Length; bankIndex++)
            {
                sumWealth += accounts[customerIndex][bankIndex];
            }
            if (sumWealth > richest)
            {
                richest = sumWealth;
            }
        }

        return richest;
    }
}