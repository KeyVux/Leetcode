public class Solution {
    public int CountKeyChanges(string s) {
        s = s.ToLower();
        int changeTimes = 0;
        for (int stringIndex = 0; stringIndex < s.Length - 1; stringIndex++)
        {
            if(s[stringIndex] != s[stringIndex+1])
            {
                changeTimes++;
            }
        }
        return changeTimes;
    }
}