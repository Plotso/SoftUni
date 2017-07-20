using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CatLady
{
    public class Cat
    {
        public Cat(string name)

        {

            this.Name = name;

        }

        private string name;



        public string Name

        {

            get

            {

                return this.name;

            }



            private set

            {

                this.name = value;

            }
        }
    }
}
