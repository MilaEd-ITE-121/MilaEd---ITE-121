
using System;

class EdzelMilaConsonants
{
    public static void Main(String[] args)
    {
        String str = "abc defghigk";
        Console.WriteLine($"string: {str}");
        Console.WriteLine($"Total number of consonants: {TotalConsonants(str, str.Length)}");


    }

    static Boolean IsConsonant(char ch)
    {
        ch = char.ToUpper(ch);

        return (ch == 'A' || ch == 'E' ||
                ch == 'I' || ch == 'O' ||
                ch == 'U') == false &&
                ch >= 65 && ch <= 90;
    }

    static int TotalConsonants(String str, int n)
    {
        if (n == 1)
        {
            if (IsConsonant(str[0]))
                return 1;
            else
                return 0;
        }

        if (IsConsonant(str[n - 1]))
            return TotalConsonants(str, n - 1) + 1;
        else
            return TotalConsonants(str, n - 1);
    }



}
//code for counting consonants

//code by Edzel Mila BSIT-1

