﻿namespace LiveDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string name;
        private int age;
        protected float height = 155.4f;

        public Person(int height)
        {
            this.height = height;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

    }
}
