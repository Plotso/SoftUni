namespace _05.MoldorsCrueltyPlan
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Food : IFood
    {
        protected Food(int happiness)
        {
            this.Happiness = happiness;
        }

        public int Happiness { get; set; }
    }
}
