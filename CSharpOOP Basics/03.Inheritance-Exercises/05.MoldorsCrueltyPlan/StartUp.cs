namespace _05.MoldorsCrueltyPlan
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var gandalf = new Gandalf();

            var foods = FoodFactory.ProduceFood(input);

            MoodFactory.ChangeMood(gandalf, foods);

            Console.WriteLine(gandalf/*.ToString()*/);
        }
    }
}
