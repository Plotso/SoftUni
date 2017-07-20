namespace _03.Spyfer
{
    using System;
    using System.Linq;

    public class Spyfer
    {
        public static void Main()
        {
            var integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers.Count == 1)
                {
                    break;
                }
                if (i == 0)
                {
                    if (integers [i] == integers[i + 1])
                    {
                        integers.RemoveAt(i + 1);
                        i = 0;
                    }
                }
                else if (i == integers.Count - 1)
                {
                    if (integers[i - 1] == integers[i])
                    {
                        integers.RemoveAt(i - 1);
                        i = 0;
                    }
                }
                else
                {
                    var previousInt = integers[i - 1];
                    var nextInt = integers[i + 1];
                    if (integers[i] == (previousInt + nextInt))
                    {
                        integers.RemoveAt(i - 1);
                        integers.RemoveAt(i);
                        i = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",integers));
        }
    }
}
