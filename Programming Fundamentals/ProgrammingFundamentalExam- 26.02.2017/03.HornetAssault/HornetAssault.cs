namespace _03.HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetAssault
    {
        public static void Main()
        {
            var beeHives = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            var beesAfterAtack = new List<long>();
            var totalPowerOfHornets = 0L;
            foreach (var hornet in hornets)
            {
                totalPowerOfHornets += hornet;
            }
            for (int i = 0; i < beeHives.Length; i++)
            {
                if (totalPowerOfHornets < beeHives[i] && totalPowerOfHornets > 0)
                {
                    beesAfterAtack.Add(beeHives[i] - totalPowerOfHornets);
                    totalPowerOfHornets -= hornets[0];
                    hornets.RemoveAt(0);
                    continue;

                }
                else if (totalPowerOfHornets == beeHives[i] && totalPowerOfHornets > 0)
                {
                    totalPowerOfHornets -= hornets[0];
                    hornets.RemoveAt(0);
                    continue;
                }
                else if(totalPowerOfHornets > beeHives[i])
                {
                    beeHives[i] = 0;
                }
                if (hornets.Count == 0)
                {
                    if (beeHives.Length - 1 == i)
                    {
                        if (beeHives[i] != 0)
                        {
                            beesAfterAtack.Add(beeHives[i]);
                            break;
                        }
                        else
                        {
                            break;
                        }
                        
                    }
                    else
                    {
                        if (beeHives[i] != 0)
                        {
                            beesAfterAtack.Add(beeHives[i]);
                        }
                        continue;
                        
                    }
                }
            }
            if (hornets.Count == 0 )
            {
                Console.WriteLine(string.Join(" ",beesAfterAtack));
            }
            else if (beesAfterAtack.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beesAfterAtack));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornets));
            }
            

        }
    }
}
