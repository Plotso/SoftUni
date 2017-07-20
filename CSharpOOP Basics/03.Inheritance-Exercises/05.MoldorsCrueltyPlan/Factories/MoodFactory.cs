namespace _05.MoldorsCrueltyPlan
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class MoodFactory
    {
        public static void ChangeMood(IMood person, IList<IFood> foods)
        {
            foreach (var food in foods)
            {
                person.Mood += food.Happiness;
            }
        }
    }
}
