using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CatLady
{
    public class Siamese : Cat

    {

        public Siamese(string name, int earSize) : base(name)

        {

            this.EarSize = earSize;

        }

        private int earSize;

        public int EarSize

        {

            get

            {

                return this.earSize;

            }



            set

            {

                this.earSize = value;

            }

        }

        public override string ToString()

        {

            return $"Siamese {this.Name} {this.EarSize}";

        }

    }
}
