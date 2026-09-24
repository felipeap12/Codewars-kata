using System;
​
public class Kata
{
    public static int[] SortNumbers(int[] nums)
    {
        // 1. Verifica se o array é nulo ou vazio
        if (nums == null || nums.Length == 0)
        {
            return new int[0]; // Retorna um array de inteiros vazio
        }
​
        // 2. Ordena o array do menor para o maior
        Array.Sort(nums);
​
        // 3. Retorna o array já ordenado
        return nums;
    }
}