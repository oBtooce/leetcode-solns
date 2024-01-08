/* 
* Problem 58: Length Of Last Word
* 
* Description: Return the length of the last word of a string.
*              
* Difficulty: Easy
* Language: C#
*/

public class Solution
{
    public static int Main()
    {
        string s = "Change this string to test outputs";

        int length = 0;

        if (s.Length == 1)
            return 1;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (Char.IsLetter(s[i]))
            {
                length++;
            }
            else if (length > 0)
            {
                break;
            }
        }

        Console.WriteLine($"The length of the last word in the input string is: {length}");

        return length;
    }
}