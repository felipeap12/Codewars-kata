public class Kata {
  public static int[] Between(int a, int b)
  {
int[] resultado = new int [b - a + 1];
int posicao = 0;
for (int i=a; i<=b; i++)
​
{
  resultado[posicao] = i;
  posicao++;
}
    return resultado;
​
     
    }
  }
​