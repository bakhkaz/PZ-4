using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_4
{
    internal class Alchohol:Liquid
    {
        private double sturdiness;

        public Alchohol(string myName, double myDensity, double mySturdiness) : base(myName, myDensity)
        {
            sturdiness = mySturdiness;
        }

        public void setSturdiness(double mySturdiness)
        {
            sturdiness = mySturdiness;
        }
    }
}
