Merge(new int[] {1, 2, 5, 0, 0}, 3, new int[] {3, 4}, 2); // Change these values for testing

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    for (int i = m + n - 1; i >= m; i--)
    {
        nums1[i] = nums2[i - m];
    }

    Array.Sort(nums1);
}