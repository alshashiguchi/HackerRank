using System;
using System.Linq;

public class Solution
{

    public static void Main(String[] args)
    {
        var palavra = Console.ReadLine();
        var qtd = Convert.ToInt64(Console.ReadLine());

        var count = palavra.Length;
        var countA = palavra.Count(x => x == 'a');

        var numero = ((decimal)qtd / (decimal)count);
        var perc = numero - Math.Floor(numero);
        long tot = 0;

        if (perc == 0)
        {
            tot = (qtd / count) * countA;
        }else
        {
            var qtdLetrasFaltantes = Math.Round(count * perc);            
            var textoFaltante = palavra.Substring(0, (int)qtdLetrasFaltantes);
            var qtdAFaltante = textoFaltante.Count(x => x == 'a');

            tot = ((qtd / count) * countA) + qtdAFaltante;

        }
        
        Console.WriteLine(tot);
        Console.ReadLine();
    }
    
}
