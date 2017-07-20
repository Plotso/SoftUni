namespace Encapsulation_LiveDemo
{
    using System;

    public class Cat : Animal
    {
        private string name;
        private int age;

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.NumberOfLegs = 8;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Name should contain letters!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name should containt at least 3 letters");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public string SayHello()
        {
            return "Meya!!!";
        }
    }
}
