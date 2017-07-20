namespace _01.CubicArtillery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CubicArtillery
    {
        public static void Main()
        {
            var bunkerCapacity = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var bunkDictionary = new Dictionary<string, Queue<int>>();

            while (input != "Bunker Revision")
            {
                var inputTokens = input.Split();

                foreach (var token in inputTokens)
                {
                    int num;
                    bool isInBunk = false;
                    if (int.TryParse(token, out num))
                    {
                        if (num <= bunkerCapacity)
                        {
                            foreach (var bunk in bunkDictionary)
                            {
                                if (bunkDictionary[bunk.Key].Sum() + num <= bunkerCapacity)
                                {
                                    bunkDictionary[bunk.Key].Enqueue(num);
                                    isInBunk = true;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        bunkDictionary[token] = new Queue<int>();
                    }
                }
                
                input = Console.ReadLine();
            }
        }
    }
}
