namespace _01.StudentsResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentsResults
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
           
            Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|",
                "Name","CAdv","COOP","AdvOOP","Average"));
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var inputTokens = input.Split(new[] { '-', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = inputTokens[0];
                var firstResult = double.Parse(inputTokens[1]);
                var secondResult = double.Parse(inputTokens[2]);
                var thirdResult = double.Parse(inputTokens[3]);
                var average = (firstResult + secondResult + thirdResult) / 3;

                Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",
                name, firstResult, secondResult, thirdResult, average));
            }
        }
    }
}
