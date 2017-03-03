using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonsP1 = int.Parse(Console.ReadLine());
            int pokemonsP2 = int.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            int overall = 0;
            for (int i = 1; i <= pokemonsP1; i++)
            {
                if (overall == battles)
                {
                    break;
                }
                for (int j = 1; j <= pokemonsP2; j++)
                {
                    if (overall == battles)
                    {
                        break; 
                    }
                    Console.Write("({0} <-> {1}) ",i,j);
                    overall++;
                }
                 
            }
        }
    }
}
