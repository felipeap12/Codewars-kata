using System;
​
public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int numero = 0;
    
    foreach(int t in arr){
    
if (t >=0)
  {
  numero += t;
}
    }
    return numero;
  }
}
​