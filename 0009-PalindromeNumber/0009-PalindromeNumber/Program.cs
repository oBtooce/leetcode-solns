IsPalindrome(10);

bool IsPalindrome(int x)
{
    if (x < 0)
        return false;

    int length = 0;
    int num = x;

    while (num > 0)
    {
        num /= 10;
        length++;
    }

    if (length == 1)
        return true;

    int midpoint = length % 2 == 0 ? length / 2 : (length - 1) / 2;
    int endpoint = length - 1;
    int[] digits = new int[length];

    for (int i = 0; i < length; i++)
    {
        digits[i] = (int)(x / Math.Pow(10, i)) / 10;
    }

    for (int i = 0; i < midpoint; i++)
    {
        if (digits[i] != digits[endpoint])
            return false;

        endpoint--;
    }

    return true;
}
