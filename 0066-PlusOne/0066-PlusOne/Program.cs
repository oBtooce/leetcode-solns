PlusOne(new int[6] { 9,9,9,9,9,9 });

int[] PlusOne(int[] digits)
{
    // Two paths, one with all 9's and one without; the following line determines the path
    int numberOfNines = digits.Count(num => num == 9);

    // All 9's: Make a new array that is one number larger, then assign the first number a value of 1
    // (when creating a new int array, all values are set to 0 by default, hence no assignment needed
    if (numberOfNines == digits.Length)
    {
        int[] newDigits = new int[numberOfNines + 1];

        newDigits[0] = 1;

        return newDigits;
    }
    else // Not All 9's: Increment as far as needed, then return
    {
        int counter = digits.Length - 1;

        digits[counter]++;
        int tempDigit = digits[counter];

        while (tempDigit == 10)
        {
            digits[counter] = 0;
            counter--;

            digits[counter]++;
            tempDigit = digits[counter];
        }

        return digits;
    }
}
