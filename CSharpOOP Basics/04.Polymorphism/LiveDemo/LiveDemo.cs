namespace LiveDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LiveDemo
    {
        public static void Main()
        {
            var math = new MathOperation();
            var math2 = new MathSubClass();

            int resultOfInts = math.Add(5, 9);
            double resultOfDoubles = math.Add(5.5, 7);
            decimal resultOfDecimals = math2.Add(5.5m, 7.7m);

            Console.WriteLine(resultOfInts);
            Console.WriteLine(resultOfDoubles);
            Console.WriteLine(resultOfDecimals);
        }
    }
}
