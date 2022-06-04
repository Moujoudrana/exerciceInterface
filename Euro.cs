using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceInterface
{
    internal class Euro : Devise

    {
        private double tauxmad;
        private double tauxdollar;

        public Euro(double td, double tm, double v, string s) : base(v, s)
        {
            this.tauxdollar = td;
            this.tauxmad = tm;
        }
        public override Devise convertto(string sym)
        {
            if (sym == "dollar")
            {
                return this.modifierdevise(this.tauxdollar,"dollar");
            }
            else if (sym == "mad")
            {
                return this.modifierdevise(this.tauxmad,"mad");

            }
            else return this;
        }
    }
}
