using System;
  public class Kata
  {
    public static int StringToNumber(String str) {
      int numeros = 0;
      
      int.TryParse(str, out numeros);
        return numeros;
  }
}