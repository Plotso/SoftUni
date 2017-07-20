namespace _02.Monopoly
{
    using System;
    using System.Linq;

    public class Monopoly
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r = dimensions[0];
            var c = dimensions[1];

            var field = FillField(r, c);

            var money = 50;
            var turns = 0;
            var hotels = 0;

            for (int rowIndex = 0; rowIndex < r; rowIndex++)
            {
                if (rowIndex % 2 == 0)
                {
                    for (int colIndex = 0; colIndex < c; colIndex++)
                    {

                        if (field[rowIndex][colIndex] == 'H')
                        {
                            hotels++;
                            Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");
                            money = 0;
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }
                            turns++;
                        }
                        else if (field[rowIndex][colIndex] == 'F')
                        {
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }
                            turns++;
                        }
                        else if (field[rowIndex][colIndex] == 'J')
                        {
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }
                            

                            Console.WriteLine($"Gone to jail at turn {turns}.");

                            turns++;
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }
                            turns++;
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }
                            turns++;

                        }
                        else if (field[rowIndex][colIndex] == 'S')
                        {
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }

                            var sum = (rowIndex + 1) * (colIndex + 1);

                            if (money > sum)
                            {
                                money -= sum;

                                Console.WriteLine($"Spent {sum} money at the shop.");
                            }
                            else
                            {
                                Console.WriteLine($"Spent {money} money at the shop.");
                                money = 0;
                            }


                            turns++;
                        }
                    }
                }
                else
                {
                    for (int colIndex = c - 1; colIndex >= 0; colIndex--)
                    {
                        if (field[rowIndex][colIndex] == 'H')
                        {
                            hotels++;
                            Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");
                            money = 0;
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }
                            turns++;
                        }
                        else if (field[rowIndex][colIndex] == 'F')
                        {
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }
                            turns++;
                        }
                        else if (field[rowIndex][colIndex] == 'J')
                        {
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }
                            

                            Console.WriteLine($"Gone to jail at turn {turns}.");

                            turns++;
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }
                            turns++;
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }
                            turns++;

                        }
                        else if (field[rowIndex][colIndex] == 'S')
                        {
                            for (int h = 0; h < hotels; h++)
                            {
                                money += 10;
                            }

                            var sum = (rowIndex + 1) * (colIndex + 1);

                            if (money > sum)
                            {
                                money -= sum;

                                Console.WriteLine($"Spent {sum} money at the shop.");
                            }
                            else
                            {
                                Console.WriteLine($"Spent {money} money at the shop.");
                                money = 0;
                            }


                            turns++;
                        }

                    }
                }
            }

            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {money}");
        }

        private static char[][] FillField(int r, int c)
        {
            var field = new char[r][];

            for (int row = 0; row < r; row++)
            {
                field[row] = Console.ReadLine().ToCharArray();
            }

            return field;
        }
    }
}
