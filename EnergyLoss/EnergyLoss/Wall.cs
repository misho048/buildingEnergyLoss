using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Wall : IWalls
    {
        private double _area;
        private double _tempDiff;
        public double HeatingTemp { get; }
        public double OutsideTemp { get; }
        private List<Material> _listOfMaterials;

        public Wall(double area, List<Material> listOfMaterials, double heatingTemp, double outsideTemp)
        {
            _area = area;
            _listOfMaterials = listOfMaterials;
            OutsideTemp = outsideTemp;
            HeatingTemp = heatingTemp;
        }


        public double Calculate()
        {

            double something = ((1 / (_listOfMaterials.Sum(x => x.CalculateR()))) * _area) * GetTempDiff();

            return something;
        }

        public virtual double GetTempDiff()
        {
            _tempDiff = Math.Abs(HeatingTemp - OutsideTemp);
            return (_tempDiff <= 1) ? 1 : _tempDiff;

        }
    }
}
