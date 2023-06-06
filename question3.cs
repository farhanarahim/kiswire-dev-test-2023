using System;

public class Program
{
    public static string IsPalindrome(string S)
    {
        char[] charArray = S.ToCharArray();
        Array.Reverse(charArray);
        string P = new string(charArray);
        
        if (S == P)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }

    public static void Main()
    {
        string S = "ABCDCBA";
        Console.WriteLine(IsPalindrome(S));
    }
}
