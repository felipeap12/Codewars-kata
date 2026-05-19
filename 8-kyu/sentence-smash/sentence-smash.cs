public class Kata
{
  public static string Smash(string[] words)
  {
    string arma = "";
    foreach(string w in words)
      {
      if (arma != "")
        {
        arma += " ";
      }
      arma += w;
    }
  return arma ;
  }
}