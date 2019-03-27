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
        private double _heatingPeriod;
        private double _heatingTemp;
        private double _outsideTemp;
        private AreaView _areaView;
        private Dictionary<string, double> _mapOfTheMaterials;

        public Mechanics(double condition, double heatingLength, AreaView areaView, double heatingTemp, double outsideTemp)
        {
            _areaView = areaView;
            _condition = condition;
            _heatingPeriod = heatingLength;
            _mapOfTheMaterials = DataLayer.LoadFromFile();
            _heatingTemp = heatingTemp;
            _outsideTemp = outsideTemp;
        }

        private void CreateFactory()
        {
            HouseFactory factory = new HouseFactory(_heatingTemp, _outsideTemp);
            factory.CreateWall(_areaView.CreateWall(), _areaView.ReturnArea()[1]);
            factory.CreateRoof(_areaView.CreateRoof(), _areaView.ReturnArea()[2]);
            factory.CreateFloor(_areaView.CreateFloor(), _areaView.ReturnArea()[0]);
            _house = factory.GetHouse();
        }

        public double DoCalculations()
        {
            CreateFactory();
            CalculateStuff calculations = new CalculateStuff(_house, _condition, _heatingPeriod);
            return calculations.CalculateHeatLoss();
        }

    }
}
