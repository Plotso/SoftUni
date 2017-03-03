using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            int heightCM = (int)( height * 100/120);
            int widthCM = (int)(width * 100 - 100)/70 ;
            
            
            int workingPlaces = heightCM*widthCM - 3;

           
            Console.WriteLine(workingPlaces);

            
            
        }
    }
}
