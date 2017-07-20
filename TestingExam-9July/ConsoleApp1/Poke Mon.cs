namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var pokePower = long.Parse(Console.ReadLine());
            var distance = int.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());

            var initialPower = pokePower;

            var counter = 0;

            while (pokePower >= distance)
            {
                
                if ((double)pokePower == (double)initialPower / 2)
                {
                    if (pokePower >= exhaustionFactor)
                    {
                        if (exhaustionFactor > 0 )
                        {
                            pokePower /= exhaustionFactor;
                        }
                          
                       
                    }
                    if (pokePower < distance)
                    {
                        break;
                    }
                }
                pokePower -= distance;
                counter++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(counter);

        }
    }
}
