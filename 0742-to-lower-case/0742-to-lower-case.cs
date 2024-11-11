public class Solution {
    public string ToLowerCase(string s) {
        
        //return s.ToLower();
        
        StringBuilder resultString = new StringBuilder();

        for (int sIndex = 0; sIndex < s.Length; sIndex++)
        {
            char charIndex = s[sIndex];
            if (charIndex >= 'A' && charIndex <= 'Z')
            {
                resultString.Append((char)(charIndex + 32));
            }
            else
            {
                resultString.Append(charIndex);
            }
        }
        return resultString.ToString();
    }
}