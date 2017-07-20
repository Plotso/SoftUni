namespace _03.NumberWars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NumberWars
    {
        public static void Main()
        {
            var lettersList = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm','n','o','p','q','r','s','t','u','v','w','x','y','z' };

            var firstPlayerCards = Console.ReadLine()
                .Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToArray();
            var secondPlayerCards = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var firstPlayerDeck = new Queue<string>();
            var secondPlayerDeck = new Queue<string>();

            foreach (var card in firstPlayerCards)
            {
                firstPlayerDeck.Enqueue(card);
            }

            foreach (var card in secondPlayerCards)
            {
                secondPlayerDeck.Enqueue(card);
            }

            var turns = 0;

            while (true)
            {
                var currentHandP1 = firstPlayerDeck.Dequeue().ToString();
                var firstPlayerNumberAsString = string.Empty;
                for (int i = 0; i < currentHandP1.Length - 1; i++)
                {
                    firstPlayerNumberAsString += currentHandP1[i].ToString();
                }
                var numberP1 = int.Parse(firstPlayerNumberAsString);
                var letterAsCharP1 = currentHandP1[currentHandP1.Length - 1];

                var currentHandP2 = secondPlayerDeck.Dequeue().ToString();
                var secondPlayerNumberAsString = string.Empty;
                for (int i = 0; i < currentHandP2.Length - 1; i++)
                {
                    secondPlayerNumberAsString += currentHandP2[i].ToString();
                }
                var numberP2 = int.Parse(secondPlayerNumberAsString);
                var letterAsCharP2 = currentHandP2[currentHandP2.Length - 1];

                if (numberP1 > numberP2)
                {
                    var resultList = new List<string>();
                    resultList.Add(currentHandP1);
                    resultList.Add(currentHandP2);
                    foreach (var result in resultList.OrderByDescending(x => int.Parse(x.Substring(0, x.Length - 1))).ThenByDescending(x => x.Substring(x.Length - 1)))
                    {
                        firstPlayerDeck.Enqueue(result);
                    }
                    turns++;
                }
                else if (numberP1 < numberP2)
                {
                    var resultList = new List<string>();
                    resultList.Add(currentHandP1);
                    resultList.Add(currentHandP2);
                    foreach (var result in resultList.OrderByDescending(x => int.Parse(x.Substring(0, x.Length - 1))).ThenByDescending(x => x.Substring(x.Length - 1))) 
                    {
                        secondPlayerDeck.Enqueue(result);
                    }
                    turns++;
                }
                else if(numberP1 == numberP2)
                {
                    var firstPlayersHandsList = new List<string>();
                    var secondPlayerHandsList = new List<string>();
                    if (firstPlayerDeck.Count == secondPlayerDeck.Count && firstPlayerDeck.Count < 3 && secondPlayerDeck.Count < 3)
                    {
                        Console.WriteLine($"Draw after {turns + 1} turns");
                        return;
                    }
                    if (firstPlayerDeck.Count < 3)
                    {
                        Console.WriteLine($"Second player wins after {turns + 1} turns");
                        return;
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        firstPlayersHandsList.Add(firstPlayerDeck.Dequeue().ToString());
                    }
                    if (secondPlayerDeck.Count < 3)
                    {
                        Console.WriteLine($"First player wins after {turns + 1} turns");
                        return;
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        secondPlayerHandsList.Add(secondPlayerDeck.Dequeue().ToString());
                    }

                    var firstPlayerLettersSum = 0;
                    foreach (var card in firstPlayersHandsList)
                    {
                        var letter = card[card.Length - 1];
                        var letterAsDigit = lettersList.IndexOf(letter) + 1;
                        firstPlayerLettersSum += letterAsDigit;
                    }
                    var secondPlayerLettersSum = 0;
                    foreach (var card in secondPlayerHandsList)
                    {
                        var letter = card[card.Length - 1];
                        var letterAsDigit = lettersList.IndexOf(letter) + 1;
                        secondPlayerLettersSum += letterAsDigit;
                    }

                    if (firstPlayerLettersSum > secondPlayerLettersSum)
                    {
                        var resultList = new List<string>();
                        resultList.Add(currentHandP1);
                        resultList.Add(currentHandP2);
                        foreach (var hand in firstPlayersHandsList)
                        {
                            resultList.Add(hand);
                        }
                        foreach (var hand in secondPlayerHandsList)
                        {
                            resultList.Add(hand);
                        }
                        foreach (var result in resultList.OrderByDescending(x => int.Parse(x.Substring(0, x.Length - 1))).ThenByDescending(x => x.Substring(x.Length - 1)))
                        {
                            firstPlayerDeck.Enqueue(result);
                        }
                        turns++;
                    }
                    else if (firstPlayerLettersSum < secondPlayerLettersSum)
                    {
                        var resultList = new List<string>();
                        resultList.Add(currentHandP1);
                        resultList.Add(currentHandP2);
                        foreach (var hand in firstPlayersHandsList)
                        {
                            resultList.Add(hand);
                        }
                        foreach (var hand in secondPlayerHandsList)
                        {
                            resultList.Add(hand);
                        }
                        foreach (var result in resultList.OrderByDescending(x => x))
                        {
                            secondPlayerDeck.Enqueue(result);
                        }
                        turns++;
                    }
                    else if (firstPlayerLettersSum == secondPlayerLettersSum)
                    {
                        var resultList = new List<string>();
                        resultList.Add(currentHandP1);
                        resultList.Add(currentHandP2);
                        foreach (var hand in firstPlayersHandsList)
                        {
                            resultList.Add(hand);
                        }
                        foreach (var hand in secondPlayerHandsList)
                        {
                            resultList.Add(hand);
                        }
                        while (firstPlayerLettersSum == secondPlayerLettersSum)
                        {
                            firstPlayerLettersSum = 0;
                            secondPlayerLettersSum = 0;
                            var firstPlayerHandsListAgain = new List<string>();
                            var secondPlayerHandsListAgain = new List<string>();
                            if (firstPlayerDeck.Count == secondPlayerDeck.Count && firstPlayerDeck.Count < 3 && secondPlayerDeck.Count < 3)
                            {
                                Console.WriteLine($"Draw after {turns+ 1} turns");
                                return;
                            }
                            if (firstPlayerDeck.Count < 3)
                            {
                                Console.WriteLine($"Second player wins after {turns + 1} turns");
                                return;
                            }
                            for (int i = 0; i < 3; i++)
                            {
                                firstPlayerHandsListAgain.Add(firstPlayerDeck.Dequeue().ToString());
                            }
                            if (secondPlayerDeck.Count < 3)
                            {
                                Console.WriteLine($"First player wins after {turns + 1} turns");
                                return;
                            }
                            for (int i = 0; i < 3; i++)
                            {
                                secondPlayerHandsListAgain.Add(secondPlayerDeck.Dequeue().ToString());
                            }
                            foreach (var card in firstPlayerHandsListAgain)
                            {
                                var letter = card[card.Length - 1];
                                var letterAsDigit = lettersList.IndexOf(letter) + 1;
                                firstPlayerLettersSum += letterAsDigit;
                            }
                            foreach (var card in secondPlayerHandsListAgain)
                            {
                                var letter = card[card.Length - 1];
                                var letterAsDigit = lettersList.IndexOf(letter) + 1;
                                secondPlayerLettersSum += letterAsDigit;
                            }

                            if (firstPlayerLettersSum > secondPlayerLettersSum)
                            {
                                foreach (var hand in firstPlayerHandsListAgain)
                                {
                                    resultList.Add(hand);
                                }
                                foreach (var hand in secondPlayerHandsListAgain)
                                {
                                    resultList.Add(hand);
                                }
                                foreach (var result in resultList.OrderByDescending(x => int.Parse(x.Substring(0, x.Length - 1))).ThenByDescending(x => x.Substring(x.Length - 1)))
                                {
                                    firstPlayerDeck.Enqueue(result);
                                }
                                turns++;
                            }

                            else if (firstPlayerLettersSum < secondPlayerLettersSum)
                            {
                                foreach (var hand in firstPlayerHandsListAgain)
                                {
                                    resultList.Add(hand);
                                }
                                foreach (var hand in secondPlayerHandsListAgain)
                                {
                                    resultList.Add(hand);
                                }
                                foreach (var result in resultList.OrderByDescending(x => int.Parse(x.Substring(0, x.Length - 1))).ThenByDescending(x => x.Substring(x.Length - 1)))
                                {
                                    firstPlayerDeck.Enqueue(result);
                                }
                                turns++;
                            }
                            else if (firstPlayerLettersSum == secondPlayerLettersSum)
                            {
                                foreach (var hand in firstPlayerHandsListAgain)
                                {
                                    resultList.Add(hand);
                                }
                                foreach (var hand in secondPlayerHandsListAgain)
                                {
                                    resultList.Add(hand);
                                }
                            }
                        }
                    }
                }

                if (firstPlayerDeck.Count == 0 && secondPlayerDeck.Count != 0)
                {
                    Console.WriteLine($"Second player wins after {turns} turns");
                    return;
                }
                else if (firstPlayerDeck.Count != 0 && secondPlayerDeck.Count == 0)
                {
                    Console.WriteLine($"First player wins after {turns} turns");
                    return;
                }
                if (turns >= 1000000)
                {
                    if (firstPlayerDeck.Count > secondPlayerDeck.Count)
                    {
                        Console.WriteLine($"First player wins after {turns} turns");
                        return;
                    }
                    else if (firstPlayerDeck.Count < secondPlayerDeck.Count)
                    {
                        Console.WriteLine($"Second player wins after {turns} turns");
                        return;
                    }
                }
            }
        }
    }
}
