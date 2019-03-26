using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
      class Mechanics
    {
        private List<IWalls> _house;
        private double _condition;
        private double _tempDiff;
        private double _heatingLength;

        public Mechanics(List<IWalls> house,double condition,double tempDiff,double heatingLength)
        {
            _house = house;
            _condition = condition;
            _heatingLength = heatingLength;
            _tempDiff = tempDiff;
        }

        public double DoSomething()
        {

            return ((_house.Sum(x => x.Calculate()))*_tempDiff)*_condition;

        }

    }
}
