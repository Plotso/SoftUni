namespace CalculatePinOptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CalculatePinOptions
    {
        public static void Main()
        {
            Console.WriteLine("Here are all possible PIN options, the only restrictions are that the PIN should not be composed of consecutive numbers nor same numbers in a row! ");
            var options = 0;

            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int e = 0; e <= 9; e++)
                        {
                            for (int f = 0; f <= 9; f++)
                            {
                                for (int g = 0; g <= 9; g++)
                                {
                                    if ((a==b || a == b + 1) && (b == c || b == c+1) &&
                                        (c == e || c == e + 1) && (e == f || e == f + 1) && (f == g || f == g+1) /*isInvalidPIN(a,b,c,e,f,g)*/)
                                    {
                                        Console.WriteLine($"{a}{b}{c}{e}{f}{g} IS NOT A VALID PIN!");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{a}{b}{c}{e}{f}{g}");
                                        options++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Total possible PINs are: {options}");
        }

        //private static bool isInvalidPIN(int a, int b, int c, int e, int f, int g)
        //{
        //    bool isInvalid = false;

        //    if (a == b || (a == b+1 && b)
        //    {

        //    }
        //}
    }
}
