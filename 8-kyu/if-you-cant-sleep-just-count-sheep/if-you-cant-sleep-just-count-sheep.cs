using System;
​
public static class Kata
{
  public static string CountSheep(int n)
  {
    string resultado = "";
  for (int i = 1; i <= n ; i++)
    { 
    resultado += $"{i} sheep...";
  
  }
      
    return resultado ;
​
    
    
  }
}