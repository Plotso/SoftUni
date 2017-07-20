namespace LiveDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Demo
    {
        public static void Main()
        {
            Student student = new Student("SoftU");
            student.Name = "Pesho";
            student.Age = 22;
            student.School = "SoftUni";
        }
    }
}
