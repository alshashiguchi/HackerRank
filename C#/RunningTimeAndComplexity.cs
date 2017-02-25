using System;

public class Solution
{
    public static void Main()
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var qtd = Convert.ToInt32(Console.ReadLine());

        for (var i = 0; i < qtd; i++)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(number))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");
        }

        Console.ReadLine();
    }

    private static bool IsPrime(int prime)
    {
        
        switch (prime)
        {
            case 2:
            case 3:
            case 5:
            case 7:
                return true;
        }

        if (prime == 1)
            return false;

        if (prime % 2 == 0)
        {
            return false;
        }

        var resSqrt = Math.Ceiling(Math.Sqrt(prime));

        var isNotPrime = false;
        for (var i = 3; i <= resSqrt; i++)
        {
            if (prime % i == 0)
            {
                isNotPrime = true;
                break;
            }
        }

        if (isNotPrime)
            return false;

        return true;

    }
}