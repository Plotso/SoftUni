namespace _10.СРЪБСКОUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class СРЪБСКОUnleashed
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split('@').ToList();
            var venue = input[1].Split(' ').ToList();
            var dictionary = new Dictionary<string, Dictionary<string, int>>();
            var venuePrice = new Dictionary<string, List<int>>();
            var venuePriceMoney = new List<int>();
            string clubName;
            var realPrice = 0;
            var sum = 0;
            while (input[0] != "End")
            {
                if (!dictionary.ContainsKey(input[0]))
                {
                    dictionary.Add(input[0], null);
                }
                if (venue[1] is string && !venuePrice.ContainsKey(string.Join(" ", venue[0], venue[1])))
                {
                    clubName = string.Join(" ",venue[0],venue[1]);
                    realPrice = Convert.ToInt32(venue[2]);
                    venuePriceMoney[realPrice] = Convert.ToInt32(venue[3]);
                    //venuePrice.Add(clubName, null);
                    venuePrice.Add(clubName, venuePriceMoney);
                }
                else if(venue[1] is string && venuePrice.ContainsKey(string.Join(" ", venue[0], venue[1])))
                {
                    clubName = string.Join(" ", venue[0], venue[1]);
                    sum = Convert.ToInt32(venue[2]) * Convert.ToInt32(venue[3]);

                    venuePriceMoney[0] = sum;
                    venuePrice[clubName] = venuePriceMoney;
                    dictionary[input[0]] = venuePrice;
                }
                if (venuePrice.ContainsKey(venue[0]))
                {
                    //venuePrice.Add(venue)
                }
                if (!dictionary.ContainsKey(input[0]))
                {
                    dictionary.Add(input[0],venuePrice);
                }
            }
        }
    }
}
