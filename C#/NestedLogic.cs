using System;
using System.Linq;

namespace Day26NestedLogic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var entrega = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            var vencto = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            if ((vencto[0] < entrega[0]) && (vencto[1] == entrega[1]) && (vencto[2] == entrega[2]))
            {
                Console.WriteLine(15 * (entrega[0] - vencto[0]));
            }
            else if ((vencto[1] < entrega[1]) && (vencto[2] == entrega[2]))
            {
                Console.WriteLine(500 * (entrega[1] - vencto[1]));
            }
            else if (vencto[2] < entrega[2])
            {
                Console.WriteLine(10000);
            }
            else
            {
                Console.WriteLine(0);
            }

            Console.ReadLine();
        }
    }
}
