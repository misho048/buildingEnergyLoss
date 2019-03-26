using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Floor : Wall
    {

        public Floor(double area, List<Material> listOfMaterials): base(area,listOfMaterials)
        {
            
        }

    }
}
