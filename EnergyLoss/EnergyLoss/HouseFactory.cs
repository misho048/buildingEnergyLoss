using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class HouseFactory
    {
        private List<IWalls> _house = new List<IWalls>();
        private double _heatingTemp;
        private double _outsideTemp;

        public HouseFactory(double heatingTemp, double outsideTemp)
        {
            _heatingTemp = heatingTemp;
            _outsideTemp = outsideTemp;
        }

        public void CreateWall(List<(double width, string value)> materialInformationList, double area)
        {
            Material_Repository material_Repository = new Material_Repository(materialInformationList);

            _house.Add(new Wall(area, material_Repository.GetMaterialList(), _heatingTemp, _outsideTemp));
        }

        public void CreateFloor(List<(double width, string value)> materialInformationList, double area)
        {
            Material_Repository material_Repository = new Material_Repository(materialInformationList);

            _house.Add(new Floor(area, material_Repository.GetMaterialList(), _heatingTemp, _outsideTemp));
        }

        public void CreateRoof(List<(double width, string value)> materialInformationList, double area)
        {
            Material_Repository material_Repository = new Material_Repository(materialInformationList);

            _house.Add(new Roof(area, material_Repository.GetMaterialList(), _heatingTemp, _outsideTemp));
        }


        public List<IWalls> GetHouse()
        {
            return _house;
        }





    }
}
