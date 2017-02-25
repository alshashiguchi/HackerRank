using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day28RegExPatternsAndIntroToDatabases
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            var userValid = new List<string>();
            for(var i = 0; i < n; i++)
            {
                var register = Console.ReadLine().Split(' ');
                
                var rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@(gmail.com)$");

                if (rg.IsMatch(register[1]))
                {
                    userValid.Add(register[0]);                    
                }
            }


            userValid = userValid.OrderBy(x => x).ToList();

            foreach(var name in userValid)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
