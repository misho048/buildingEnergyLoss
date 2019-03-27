using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class CalculateStuff
    {

        private List<IWalls> _house;
        double _condition;
        double _heatingPeriod;

        public CalculateStuff(List<IWalls> house, double condition, double heatingPeriod)
        {
            _house = house;
            _condition = condition;
            _heatingPeriod = heatingPeriod;
        }

        public double CalculateHeatLoss()
        {

            return ((_house.Sum(x => x.Calculate())) * _condition) * _heatingPeriod;

        }
    }
}
