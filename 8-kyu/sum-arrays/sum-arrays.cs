public class Kata
{
  public static double SumArray(double[] array)
  {
    double soma = 0;
    foreach(double teste in array)
      {
      if (teste == null) 
      {
        return 0;
        }
      else {
        soma += teste;
      }
    }
    return soma;
    
    
  }
}