namespace _05.MoldorsCrueltyPlan
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class FoodFactory
    {
        public static IList<IFood> ProduceFood(string input)
        {
            var foods = new List<IFood>();
            var inputTokens = input.ToLower().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var entry in inputTokens)
            {
                switch (entry)
                {
                    case "cram":
                        foods.Add(new Cram());
                        break;
                    case "lembas":
                        foods.Add(new Lembas());
                        break;
                    case "apple":
                        foods.Add(new Apple());
                        break;
                    case "melon":
                        foods.Add(new Melon());
                        break;
                    case "honeycake":
                        foods.Add(new HoneyCake());
                        break;
                    case "mushrooms":
                        foods.Add(new Mushrooms());
                        break;
                    default:
                        foods.Add(new OtherFood());
                        break;

                }
            }

            return foods;
        }
    }
}
