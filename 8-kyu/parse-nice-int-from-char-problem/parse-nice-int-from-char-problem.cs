using System;
​
public class Kata
{
  public static int GetAge(string inputString)
  {
  char c =inputString[0];
  int numero = (int)char.GetNumericValue(c);
  return numero;
    
  }
}