namespace _02.LadybugsS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LadybugsS
    {
        public static void Main()
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            var ladybugArray = new int[sizeOfField];

            var ladyBugPlaces = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var fromHereToDirection = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < sizeOfField; i++)
            {
                ladybugArray[i] = 0;
            }

            for (int i = 0; i < sizeOfField; i++)
            {
                for (int j = 0; j < ladyBugPlaces.Length; j++)
                {
                    if (i == ladyBugPlaces[j])
                    {
                        ladybugArray[i] = 1;
                    }
                }
            }

            while (fromHereToDirection[0] != "end")
            {
                var fromHere = Convert.ToInt32(fromHereToDirection[0]);
                var direction = fromHereToDirection[1];
                var numberOfSkips = Convert.ToInt32(fromHereToDirection[2]);

                if (fromHere < ladybugArray.Length && fromHere >= 0 && ladybugArray[fromHere] == 1)
                {
                    var placeToLandRight = fromHere + numberOfSkips;
                    var placeToLandLeft = fromHere - numberOfSkips;

                    if (numberOfSkips != 0)
                    {
                        if (direction == "right" && placeToLandRight < ladybugArray.Length && placeToLandRight >= 0)
                        {
                            if (ladybugArray[placeToLandRight] == 0)
                            {
                                ladybugArray[fromHere] = 0;
                                ladybugArray[placeToLandRight] = 1;
                            }
                            else if (ladybugArray[placeToLandRight] == 1)
                            {
                                for (int i = 0; i < ladybugArray.Length; i++)
                                {
                                    if (placeToLandRight < ladybugArray.Length && ladybugArray[placeToLandRight] == 1)
                                    {
                                        placeToLandRight += numberOfSkips;
                                    }
                                    else if (placeToLandRight < ladybugArray.Length && ladybugArray[placeToLandRight] == 0)
                                    {
                                        ladybugArray[fromHere] = 0;
                                        ladybugArray[placeToLandRight] = 1;
                                        break;
                                    }
                                    else
                                    {
                                        ladybugArray[fromHere] = 0;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                ladybugArray[fromHere] = 0;
                            }
                        }
                        else if (direction == "left" && placeToLandLeft >= 0 && placeToLandLeft < ladybugArray.Length)
                        {
                            if (ladybugArray[placeToLandLeft] == 0)
                            {
                                ladybugArray[fromHere] = 0;
                                ladybugArray[placeToLandLeft] = 1;
                            }
                            else if (ladybugArray[placeToLandLeft] == 1)
                            {
                                for (int i = 0; i < ladybugArray.Length; i++)
                                {
                                    if (placeToLandLeft >= 0)
                                    {
                                        if (ladybugArray[placeToLandLeft] == 1)
                                        {
                                            placeToLandLeft -= numberOfSkips;
                                        }
                                        else if (ladybugArray[placeToLandLeft] == 0)
                                        {
                                            ladybugArray[fromHere] = 0;
                                            ladybugArray[placeToLandLeft] = 1;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        ladybugArray[fromHere] = 0;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            ladybugArray[fromHere] = 0;
                        }
                    }
                }

                fromHereToDirection = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", ladybugArray));
        }
    }
}
