using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercises_7_LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum = leftSum + num;
            }
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum = rightSum + num;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum =" + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff =" + Math.Abs(rightSum - leftSum));
            }
        }
    }
}
