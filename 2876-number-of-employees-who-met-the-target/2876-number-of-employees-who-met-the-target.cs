public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int targetMet = 0;
        for (int hoursIndex = 0; hoursIndex < hours.Length; hoursIndex++)
        {
            if (hours[hoursIndex] >= target)
            {
                targetMet++;
            }
        }
        return targetMet;
    }
}