using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Material_Repository
    {
        private Dictionary<string, double> _mapOfTheMaterials = DataLayer.LoadFromFile();
        private List<(double width, string value)> _valWidList = new List<(double width, string value)>();

        public Material_Repository(List<(double width, string value)> ValWidList)
        {
            _valWidList = ValWidList;
        }

        public List<Material> GetMaterialList()
        {
            List<Material> materialList = new List<Material>();
            foreach (var item in _valWidList)
            {
                materialList.Add(new Material(item.width, _mapOfTheMaterials[item.value], item.value));
            }
            return materialList;

        }
    }
}
