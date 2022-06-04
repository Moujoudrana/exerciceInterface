using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceInterface
{
    internal class Dollar : Devise

    {
        private double tauxeuro;
        private double tauxmad;

        public Dollar(double te, double tm, double v ,string s): base(v,s)
        {
            this.tauxeuro = te;
            this.tauxmad = tm;
        }
        public override Devise convertto(string sym)
        {
            if (sym == "mad")
            {
                return this.modifierdevise(this.tauxmad,"mad");
            }
            else if (sym == "euro")
            {
                return this.modifierdevise(this.tauxeuro,"euro");

            }
            else return this;
        }
    }
}
