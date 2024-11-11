public class Solution {
    public string FirstPalindrome(string[] words) {
        for (int stringIndex = 0; stringIndex < words.Length; stringIndex++)
        {
            if (check(words[stringIndex]))
            {
                return words[stringIndex];
            }
        }
        return "";

        bool check(string s)
        {
            int reverseIndex = s.Length - 1;
            for (int index = 0; index < reverseIndex; index++)
            {
                if (s[index] != s[reverseIndex])
                {
                    return false;
                }
                reverseIndex--;
            }
            return true;
        }
    }
}