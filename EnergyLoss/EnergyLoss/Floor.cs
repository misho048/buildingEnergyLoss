using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Floor : Wall
    {

        
        public Floor(double area, List<Material> listOfMaterials,double heatingTemp,double outsideTemp): base(area,listOfMaterials,heatingTemp,outsideTemp)
        {
          
        }
         
         public override double GetTempDiff()
        {
            return Math.Abs(HeatingTemp - 3);            
                  
           
        }


    }
}
