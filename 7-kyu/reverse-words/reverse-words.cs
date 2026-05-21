using System;
​
public static class Kata
{
    public static string ReverseWords(string str)
    {
     
        string[] palavras = str.Split(' ');
        
        
        string[] palavrasInvertidas = new string[palavras.Length];
        
        for (int i = 0; i < palavras.Length; i++)
        {
    
            char[] letras = palavras[i].ToCharArray();
            
     
            Array.Reverse(letras);
            
    
            palavrasInvertidas[i] = new string(letras);
        }
        
      
        return string.Join(" ", palavrasInvertidas);
    }
}