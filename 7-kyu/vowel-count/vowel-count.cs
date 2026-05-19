using System;
​
public static class Kata
{
    public static int GetVowelCount(string str)
    {
      int somando = 0;
      string teste = "aeiouAEIOU";
      
     foreach(char i in str)
       {
       if (teste.Contains(i))
         {
         somando ++;
       }
    }
  return somando;
}
  }
​