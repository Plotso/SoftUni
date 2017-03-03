using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*',i) + "\\" + new string('-',2 * n + 3 - 2 * i - 2) + "/" + new string('*',i));
            }
            //middle
            for (int j = 1; j < (n/3) + 1; j++)
            {
                Console.WriteLine("|" + new string('*',n/2 + j - 1) + "\\" + new string('*', 2 * n - 1 - 2 * (n/2 + j - 1) ) + "/" + new string('*',n / 2 + j -1) + "|");
            }
            // bot
            for (int k = 1; k <= n; k++)
            {
                Console.WriteLine(new string('-', k) + "\\" + new string('*', 2 * n + 3 - 2 * k - 2) + "/" + new string('-', k));
            }

        }
    }
}
