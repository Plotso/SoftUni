namespace _04.AcademyGraduation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AcademyGraduation
    {
        public static void Main()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            var dictionary = new SortedDictionary<string, double>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var name = Console.ReadLine();
                var marks = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse);

                var avgMark = marks.Average();

                dictionary[name] = avgMark;
            }

            foreach (var student in dictionary)
            {
                var name = student.Key;
                var mark = student.Value;

                Console.WriteLine($"{name} is graduated with {mark}");
            }
        }
    }
}
