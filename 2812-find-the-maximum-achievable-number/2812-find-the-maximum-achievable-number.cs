public class Solution {
    public int TheMaximumAchievableX(int num, int t) {
        while (t>0)
        {
            num+=2;
            t--;
        }
        return num;
    }
}