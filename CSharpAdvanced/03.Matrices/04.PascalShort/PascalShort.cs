namespace _04.PascalShort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PascalShort
    {
        public static void Main()
        {
            var height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                long startNumber = 1;

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(startNumber + " ");
                    //Console.Write(" ");
                    startNumber = startNumber * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
