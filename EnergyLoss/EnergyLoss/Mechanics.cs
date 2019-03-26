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
        private AreaView _areaView;
        private Dictionary<string, double> _mapOfTheMaterials;

        public Mechanics(double condition,double tempDiff,double heatingLength)
        {
            
            _condition = condition;
            _heatingLength = heatingLength;
            _tempDiff = tempDiff;
            _mapOfTheMaterials =DataLayer.LoadFromFile();
        }

        public void CreateHouse(AreaView areaView)
        {
            _areaView = areaView;
            _house = new List<IWalls>();
            _house.Add(CreateWall());
            _house.Add(CreateRoof());
            _house.Add(CreateFloor());

        }

        private IWalls CreateWall()
        {
            List<Material> materialList = new List<Material>();
            foreach (var item in _areaView.CreateWall())
            {
                materialList.Add(new Material(item.Item1, _mapOfTheMaterials[item.Item2], item.Item2));
            }           

           return new Wall(_areaView.ReturnArea()[1], materialList);
        }

        private IWalls CreateRoof()
        {
            List<Material> materialList = new List<Material>();
            foreach (var item in _areaView.CreateRoof())
            {
                materialList.Add(new Material(item.Item1, _mapOfTheMaterials[item.Item2], item.Item2));
            }

            return new Wall(_areaView.ReturnArea()[2], materialList);
        }

        private IWalls CreateFloor()
        {
            List<Material> materialList = new List<Material>();
            foreach (var item in _areaView.CreateFloor())
            {
                materialList.Add(new Material(item.Item1, _mapOfTheMaterials[item.Item2], item.Item2));
            }

            return new Wall(_areaView.ReturnArea()[0], materialList);
        }



        public double DoSomething()
        {
            if (_tempDiff == 0)
            {
                _tempDiff = 1;
            }
            return (((_house.Sum(x => x.Calculate()))*_tempDiff)*_condition)*_heatingLength;

        }

    }
}
