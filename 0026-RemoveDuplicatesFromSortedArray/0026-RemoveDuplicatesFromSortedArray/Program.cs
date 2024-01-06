/* 
 * Problem 26: Remove Duplicares From Sorted Array
 * 
 * Description: Return the count of all unique numbers in a given array.
 *              Additionally, format the array to put all unique values at the front.
 *              
 * Difficulty: Easy
 * Language: C#
 */

public class Solution
{
    public static int Main()
    {
        // Change this to whatever for testing purposes
        int[] nums = new int[] { 1,1,2,2,3,3,4,5,6,6 };
        int result = 1;
        int currentNum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == currentNum)
            {
                nums[i] = 101;
            }
            else
            {
                result++;
                currentNum = nums[i];
            }
        }

        Array.Sort(nums);

        Console.WriteLine($"The number of unique values in the array is: {result}");

        return result;
    }
}