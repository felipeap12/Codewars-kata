class Kata
{
    public static int StrCount(string str, char letter)
    {
      int resultado = 0;
        foreach(char teste in str)
          {
          if (teste == letter)
            {
            resultado++;
        }
    }
      return resultado;
}
  }