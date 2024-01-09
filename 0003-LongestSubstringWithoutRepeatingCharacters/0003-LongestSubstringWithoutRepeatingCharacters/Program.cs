/* 
* Problem 3: Longest Substring Without Repeating Characters
* 
* Description: Return an integer containing the length of the longest substring in a given input.
* 
* Difficulty: Medium
* Language: C#
*/
public class Solution
{
    public static int Main()
    {
        string s = "Change this to whatever you want to test inputs";

        int result = 1;
        int longest = 1;
        int index;

        string tempString = "";

        if (s == "")
            return 0;

        tempString += s[0];

        for (int i = 1; i < s.Length; i++)
        {
            if (tempString.Contains(s[i]))
            {
                index = tempString.IndexOf(s[i]);

                if (index == 0)
                    tempString = tempString.Substring(1);
                else if (index == tempString.Length - 1)
                    tempString = "";
                else
                    tempString = tempString.Substring(index + 1);
            }

            tempString += s[i];

            result = tempString.Length;
            
            if (result > longest)
                longest = result;
        }

        if (result < longest)
            result = longest;

        Console.WriteLine($"The longest substring in the given input is: {result}");

        return result;
    }
}
