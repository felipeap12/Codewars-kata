public static class StringExtensions
{
    public static bool IsUpperCase(this string text)
    {
      return text == text.ToUpper();
        // Alfabeto completo sem letras faltando ou repetidas
        string conf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
        
        foreach (char teste in text)
        {
            // Se encontrar QUALQUER caractere que NÃO é maiúsculo, encerra na hora
            if (!conf.Contains(teste)) {
                return false;
            }
        }
        
        // Se percorreu todo o texto e NENHUMA letra falhou, retorna true no final
        return true;
    }
}