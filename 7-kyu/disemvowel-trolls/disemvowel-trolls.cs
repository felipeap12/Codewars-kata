using System;
using System.Collections.Generic;
public static class Kata
{
    public static string Disemvowel(string str)
    {
  List<char> listaNegra = new List<char> {'A','E','I','O','U','a','e','i','o','u'};
      string resultado = "";
      foreach(char letra in str)
        
        {
        if (!listaNegra.Contains(letra))
          resultado += letra;
        
      }
        return resultado;
    }
}