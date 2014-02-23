using System;
using System.Text;

public static class Substring
{
    public static StringBuilder SUBString(this StringBuilder input, int startIndex)
    {
        StringBuilder substring = new StringBuilder();

        if (startIndex < 0 || startIndex > input.Length)
        {
            throw new ArgumentOutOfRangeException("Start index is out of range!Start index must be greater or equal to zero or smaller than string length!");
        }

        for (int i = startIndex; i < input.Length; i++)
        {
            substring.Append(input[i]);
        }

        return substring;
    }

    public static StringBuilder SUBString(this StringBuilder input, int index, int length)
    {
        StringBuilder substring = new StringBuilder();

        if (index < 0 || length <= 0 || index + length - 1 >= input.Length)
        {
            throw new ArgumentOutOfRangeException("Either index or length is out of range!Index must be greater or equal to zero!Length must be greater than zero!");
        }

        int endIndex = index + length;

        for (int i = index; i < endIndex; i++)
        {
            substring.Append(input[i]);
        }

        return substring;
    }
}
