using System;
using System.Linq;
​
public class TwoToOne 
{
    public static string Longest (string s1, string s2) 
    {
​
        return new string((s1 + s2).Distinct().OrderBy(c => c).ToArray());
    }
}