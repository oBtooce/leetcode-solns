/* 
 * Problem 27: Remove Element
 * 
 * Description: Return the count of all numbers that are not equal to a specified input.
 *              Additionally, format the array to put all unique values at the front.
 *              
 * Difficulty: Easy
 * Language: C#
 */

public class Solution
{
    public static int Main()
    {
        // Alter these for test purposes
        int[] nums = new int[] { 1, 2, 2, 1, 5, 3, 4, 7, 9, 4, 3 };
        int val = 3;

        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
                nums[i] = 101; // Chosen because the problem constraints show: 0 <= nums[i] <= 100
            else
                result++;
        }

        Array.Sort(nums);

        Console.WriteLine($"The total number of values not equal to the specified number is: {result}");

        return result;
    }
}