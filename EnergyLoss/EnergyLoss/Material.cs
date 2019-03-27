using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Material
    {
        public double Width { get; private set; }
        public double Lambda { get; private set; }
        public string Name { get; private set; }

        public Material(double width, double lambda,string name)
        {
            Width = width;
            Lambda = lambda;
            Name = name;
        }

        public double CalculateR ()
        {
            
            return Width / Lambda;           

        }




    }
}
