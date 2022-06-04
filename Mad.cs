using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceInterface
{
    internal class Mad : Devise

    {
        private double tauxeuro;
        private double tauxdollar;

        public Mad(double ta, double td, double v, string s):base(v,s)
        {
            this.tauxdollar = td;
            this.tauxeuro = ta;
        }
        public override Devise convertto(string sym)
        {
            if (sym == "dollar")
            {
                return this.modifierdevise(this.tauxdollar,"dollar");
            }
            else if (sym == "euro")
            {
                return this.modifierdevise(this.tauxeuro,"euro");

            }
            else return this;
        }
    }
}
