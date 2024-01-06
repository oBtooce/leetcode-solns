/* 
 * Problem 14: Longest Common Prefix
 * 
 * Description: Return a string containing the longest prefix for all incoming strings
 * Difficulty: Easy
 * Language: C#
 */

public class Solution
{
    public static void Main()
    {
        // Alter this string set as needed
        string[] strs = new string[2] { "ab", "a" };

        string prefix = "";
        string tempStr = "";

        bool findingPrefix = true;
        int i = 0;
        int count = 0;

        if (strs.Length == 1)
        {
            Console.WriteLine($"The prefix is: {prefix}");
            return;
        }

        foreach (string str in strs)
        {
            if (str == "")
            {
                Console.WriteLine($"The prefix is: {prefix}");
                return;
            }
        }

        while (findingPrefix == true)
        {
            // Get all first letters from strings
            foreach (string str in strs)
            {
                if (i < str.Length)
                    tempStr += str[i];
            }

            if (tempStr.Length != strs.Length)
            {
                break;
            }

            // LINQ-less way to get total count of a character
            while (count < tempStr.Length && tempStr[count] == strs[0][i])
                count++;

            if (count == strs.Length)
            {
                count = 0;
                prefix += tempStr[0];
                i++;
                tempStr = "";
            }
            else
                findingPrefix = false;
        }

        Console.WriteLine($"The prefix is: {prefix}");
    }
}