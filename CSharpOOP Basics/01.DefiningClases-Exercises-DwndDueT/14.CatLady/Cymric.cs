using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CatLady
{
    public class Cymric : Cat

    {

        public Cymric(string name, double furLength) : base(name)

        {

            this.furLength = furLength;

        }



        private double furLength;



        public double FurLength

        {

            get

            {

                return this.furLength;

            }



            set

            {

                this.furLength = value;

            }

        }

        public override string ToString()

        {

            return $"Cymric {this.Name} {this.FurLength:f2}";

        }

    }
}
