namespace _05.MoldorsCrueltyPlan
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Gandalf : IMood
    {
        public Gandalf(int mood = 0)
        {
            this.Mood = mood;
        }

        public int Mood { get; set; }

        public string MoodType()
        {
            if (this.Mood < -5)
            {
                return "Angry";
            }
            else if (this.Mood >= -5 && this.Mood <= 0)
            {
                return "Sad";
            }
            else if (this.Mood >= 1 && this.Mood <= 15)
            {
                return "Happy";
            }
            else
            {
                return "JavaScript";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Mood).Append(Environment.NewLine).Append(this.MoodType());

            return sb.ToString();
        }
    }
}
