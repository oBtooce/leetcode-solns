
IsPalindrome("A man, a plan, a canal: Panama");

bool IsPalindrome(string s)
{
    // Remove all non-letter and non-digit values
    char[] strChars = s.ToCharArray();

    strChars = Array.FindAll<char>(strChars, (c => char.IsLetterOrDigit(c)));
    s = new string(strChars).ToLower();

    if (s.Length == 0)
        return true;

    double strLen = Math.Floor((double)s.Length / 2);

    // Check letters front and back until string is done
    for (int i = 0; i < strLen; i++)
    {
        if (s[i] != s[(s.Length - 1) - i])
            return false;
    }

    return true;
}