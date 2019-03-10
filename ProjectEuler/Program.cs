using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Problem number: ");
                int number;
                if (int.TryParse(Console.ReadLine(),out number))
                {
                    Console.WriteLine("The solution is");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("--------------------------");
                    var sol = SolutionFactory.GetSolutionTo(number);
                    Console.WriteLine(sol.Solution());
                    Console.WriteLine("--------------------------");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Elapsed Time: ");
                    Console.WriteLine(sol.ElapsedTime.Milliseconds.ToString() + " ms");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("input was not valid press Enter to continue...");
                    Console.ReadLine();
                }                
                
            }
        }
    }
}
