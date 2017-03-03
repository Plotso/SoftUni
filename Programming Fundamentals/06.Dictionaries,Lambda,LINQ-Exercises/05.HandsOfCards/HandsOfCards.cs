namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
                var mainDictionary = new Dictionary<string, int>();
                var separators = new char[] { ':', ' ', ',' };
                var drawnCards = new Dictionary<string, List<string>>();

                var sum = 0;

                var powersDictionary = new Dictionary<string, int>()
            {
                {"J", 11 },
                {"Q", 12 },
                {"K", 13 },
                {"A", 14 }
            };

                var typesDictionary = new Dictionary<string, int>()
            {
                {"S", 4 },
                {"H", 3 },
                {"D", 2 },
                {"C", 1 }
            };

                var inputName = Console.ReadLine()
                    .Split(':')
                    .ToList();

                while (inputName[0] != "JOKER")
                {
                    var secondInput = inputName[1].Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (!mainDictionary.ContainsKey(inputName[0]))
                    {
                        mainDictionary[inputName[0]] = 0;
                    }

                    var powerList = secondInput.Distinct().ToList();

                    foreach (var item in powerList)
                    {
                        var cardPower = string.Empty;
                        var typePower = string.Empty;

                        if (item.Length > 2)
                        {
                            cardPower = item.Substring(0, 2);
                            typePower = item.Substring(2);
                        }
                        else
                        {
                            cardPower = item.Substring(0, 1);
                            typePower = item.Substring(1);
                        }

                        if (cardPower == "J" || cardPower == "Q" || cardPower == "K" || cardPower == "A")
                        {
                            sum = powersDictionary[cardPower] * typesDictionary[typePower];
                        }
                        else
                        {
                            sum = Convert.ToInt32(cardPower) * typesDictionary[typePower];
                        }

                        if (drawnCards.ContainsKey(inputName[0]) && drawnCards[inputName[0]].Contains(item))
                        {
                            sum = 0;
                        }

                        mainDictionary[inputName[0]] += sum;
                    };
                    sum = 0;
                    drawnCards[inputName[0]] = powerList;

                    inputName = Console.ReadLine()
                    .Split(':')
                    .ToList();
                }

                foreach (var item in mainDictionary)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
    }
}
