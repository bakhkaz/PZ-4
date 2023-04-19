using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_4
{
    internal class Liquid
    {
        private string name;
        private double density;
        public Liquid(string myName, double myDensity)
        {
            name = myName;
            density = myDensity;
        }
        public void setName(string myName)
        {
            name = myName;
        }

        public void setDensity(double myDensity)
        {
            density = myDensity;
        }
        
    }
} 

