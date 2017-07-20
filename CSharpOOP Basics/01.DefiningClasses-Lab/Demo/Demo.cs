namespace Demo
{
    using System;

    public class Demo
    {
        public static void Main()
        {
            var dice = new Dice(6, "nigger");
            var dice1 = new Dice(8);
            var dice2 = new Dice(12);
            var dice3 = new Dice(20);
            //dice.Sizes = -2;//6;
            dice1.Sizes = 8;
            dice2.Sizes = 12;
            dice3.Sizes = 20;

            Console.WriteLine($"Your dice has {dice.Sizes} sizes");
            Console.WriteLine($"Your dice is {dice.Colour}");

            Console.WriteLine("We are gonna roll the dice 10 times and show you what is the reuslt: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Roll {i} => {dice.Roll()}");
            }
        }
    }
}
