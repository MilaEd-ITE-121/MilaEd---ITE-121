
using System;

class EdzelMilaVowels
{
    public static void Main(String[] args)
    {
        String str = "abc doefgaa";
        Console.WriteLine($"string: {str}");
        Console.WriteLine($"Total number of vowels: {TotalVowels(str, str.Length)}");
    }
    static Boolean IsVowel(char ch)
    {
        ch = char.ToUpper(ch);

        return (ch == 'A' || ch == 'E' ||
                ch == 'I' || ch == 'O' ||
                ch == 'U') == true &&
                ch >= 65 && ch <= 90;
    }

    static int TotalVowels(String str, int n)
    {
        if (n == 1)
        {
            if (IsVowel(str[0]))
                return 1;
            else
                return 0;
        }

        if (IsVowel(str[n - 1]))
            return TotalVowels(str, n - 1) + 1;
        else
            return TotalVowels(str, n - 1);
    }
}
// code for counting vowels

//code by Edzel Mila BSIT-1