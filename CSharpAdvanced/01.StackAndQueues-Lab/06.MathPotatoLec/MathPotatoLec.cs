namespace _06.MathPotatoLec
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MathPotatoLec
    {
        public static void Main()
        {
            var children = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {

                }
            }
        }
    }
}
