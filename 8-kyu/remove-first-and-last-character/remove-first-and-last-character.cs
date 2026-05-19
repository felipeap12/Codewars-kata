using System;
​
public class Kata
{
    public static string Remove_char(string s)
{
    // Começamos no 1.
    // O comprimento final será o total (s.Length) menos 2 (as duas pontas).
    return s.Substring(1, s.Length - 2);
}
}