namespace _02.PokemonDontGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PokemonDontGo
    {
        public static void Main()
        {
            var inputSequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            var sum = 0;

            while (inputSequence.Any())
            {
                var integer = int.Parse(Console.ReadLine());
                int numToBeRemoved = 0;
                if (integer < 0)
                {
                    numToBeRemoved += inputSequence[0];
                    inputSequence.RemoveAt(0);
                    var lastElement = inputSequence[inputSequence.Count - 1];
                    inputSequence.Insert(0, lastElement);

                    sum += numToBeRemoved;
                }
                else if (integer > inputSequence.Count - 1)
                {
                    numToBeRemoved += inputSequence[inputSequence.Count - 1];
                    inputSequence.RemoveAt(inputSequence.Count - 1);
                    var firstElement = inputSequence[0];
                    inputSequence.Add(firstElement);

                    sum += numToBeRemoved;
                }
                else
                {
                    numToBeRemoved += inputSequence[integer];
                    inputSequence.RemoveAt(integer);

                    sum += numToBeRemoved;
                }
                for (int i = 0; i < inputSequence.Count; i++)
                {
                    if (inputSequence[i] <= numToBeRemoved)
                    {
                        inputSequence[i] += numToBeRemoved;
                    }
                    else
                    {
                        inputSequence[i] -= numToBeRemoved;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
