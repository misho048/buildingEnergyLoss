using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Wall : IWalls
    {
        private double _area;
        private List<Material> _listOfMaterials;

        public Wall(double area, List<Material> listOfMaterials)
        {
            _area = area;
            _listOfMaterials = listOfMaterials;
        }

        public double Calculate()
        {

            return (1 / (_listOfMaterials.Sum(x=> x.CalculateR()))) * _area;
        }
    }
}
