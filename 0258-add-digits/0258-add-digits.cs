public class Solution {
    public int AddDigits(int num) {
        while (num >9)
        {
            num = num%10 + num/10;
        }
        return num;
    }
}