namespace Encapsulation_LiveDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dog : Animal
    {
        private string name;
        private int age;

        public Dog(string name,int age)
            :base()
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public string SayHello()
        {
            return "Djaf!!!";
        }
    }
}
