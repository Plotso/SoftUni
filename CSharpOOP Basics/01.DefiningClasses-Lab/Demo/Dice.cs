namespace Demo
{
    using System;

    public class Dice
    {
        private int sizes;
        private string colour;
        private Random rnd = new Random();
        
        public Dice(int sizes)
        {
            //this.sizes = sizes -> takes the sizes mentioned above this constructor
            this.Sizes = sizes;
        }

        public Dice(int sizes, string colour)
        {
            this.Sizes = sizes;
            this.colour = colour;
        }

        public int Sizes
        {
            get
            {
                return this.sizes;
            }
            set
            {
                if (value < 6 || value > 333333)
                {
                    throw new Exception("Dice can't have less than 6 sizes or more than 333333 sizes!");
                }
                this.sizes = value;
            }
        }

        public string Colour
        {
            get
            {
                return this.colour;
            }
        }

        public int Roll()
        {
            return this.rnd.Next(1, this.Sizes);
        }
    }
}
