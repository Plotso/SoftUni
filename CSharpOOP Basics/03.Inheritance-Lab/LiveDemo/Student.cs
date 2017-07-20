namespace LiveDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Person
    {
        private string school;

        public Student(int height) 
            : base(height)
        {
        }
        public string School
        {
            get { return this.school; }
            set { this.school = value; }
        }
    }
}
