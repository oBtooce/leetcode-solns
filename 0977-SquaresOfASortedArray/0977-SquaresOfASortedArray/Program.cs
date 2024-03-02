int[] nums = new int[5] { -4, -1, 0, 3, 10 };
SortedSquares(nums);

int[] SortedSquares(int[] nums)
{
    // Simple solution
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] *= nums[i];
    }

    Array.Sort(nums);

    return nums;
}
