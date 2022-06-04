using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceInterface
{
    abstract internal class Devise : Idevise

    {
        private double valeur;
        private String symbole;

        public Devise(double v, string s)
        {
            this.valeur = v;
            this.symbole = s;
        }

        abstract public Devise convertto(string sym);

        public Devise modifierdevise(double t, string s)
        {
            this.valeur = this.valeur * t;
            this.symbole = s;
            return this;
        }

        public static double operator*(Devise d1, double d2)
        {
            double res = d1.valeur * d2;
            return res;
        }
        
    }
}
