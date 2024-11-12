public class Solution {
    public string ToLowerCase(string s) {
        
        //return s.ToLower();
        
        List<char> resultString = new List<char>{};

        for (int sIndex = 0; sIndex < s.Length; sIndex++)
        {
            char charIndex = s[sIndex];
            if (charIndex >= 'A' && charIndex <= 'Z')
            {
                resultString.Add((char)(charIndex + 32));
            }
            else
            {
                resultString.Add(charIndex);
            }
        }
        return new string(resultString.ToArray());
    }
}