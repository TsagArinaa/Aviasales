using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviasales
{
    internal class Fligth
    {
        string fligth;
        string name;
        string place;

        public Fligth(string fligth, string name, string place)
        {
            this.fligth = fligth;
            this.name = name;
            this.place = place;
        }

        public override string ToString()
        {
            return fligth + " " + name + " " + place;
        }
    }
}
