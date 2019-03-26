using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyLoss
{
    public partial class AreaView : Form
    {
        public List<IWalls> house;
        public AreaView()
        {
            house= new List<IWalls>();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public List<IWalls> ReturnHouse()
        {
            return house;
        }
        

        private void buttonAccept_Click(object sender, EventArgs e)
        {
         
            house.Add(CreateFloor());
            house.Add(CreateRoof());
            house.Add(CreateWall());
            
            DialogResult = DialogResult.OK;


        }

        private IWalls CreateFloor()
        {
            List<Material> materialList = new List<Material>();
            materialList.Add(new Material(Convert.ToDouble(textBoxConcreteFloor.Text), 1.74, "Beton"));
            materialList.Add(new Material(Convert.ToDouble(textBoxYtongFloor.Text), 0.09, "Ytong"));
            materialList.Add(new Material(Convert.ToDouble(textBoxPolystyreFloor.Text), 0.03, "Polystyren"));
            materialList.Add(new Material(Convert.ToDouble(textBoxPlasterFloor.Text), 0.25, "Omietka"));
            materialList.Add(new Material(Convert.ToDouble(textBoxGlassWoolFloor.Text), 0.039, "Sklena Vata"));
            materialList.Add(new Material(Convert.ToDouble(textBoxPlasterBoardFloor.Text), 0.34, "Sadrokarton"));
            return new Floor(Convert.ToDouble(textBoxFloorArea.Text), materialList);

        }

        private IWalls CreateWall()
        {
            List<Material> materialList = new List<Material>();
            materialList.Add(new Material(Convert.ToDouble(textBoxConcreteWall.Text), 1.74, "Beton"));
            materialList.Add(new Material(Convert.ToDouble(textBoxYtongWall.Text), 0.09, "Ytong"));
            materialList.Add(new Material(Convert.ToDouble(textBoxPolystyreWall.Text), 0.03, "Polystyren"));
            materialList.Add(new Material(Convert.ToDouble(textBoxPlasterWall.Text), 0.25, "Omietka"));
            materialList.Add(new Material(Convert.ToDouble(textBoxGlassWoolWall.Text), 0.039, "Sklena Vata"));
            materialList.Add(new Material(Convert.ToDouble(textBoxPLasterboardWall.Text), 0.34, "Sadrokarton"));
            return new Wall(Convert.ToDouble(textBoxWallArea.Text), materialList);
        }

        private IWalls CreateRoof()
        {
            List<Material> materialList = new List<Material>();
            materialList.Add(new Material(Convert.ToDouble(textBoxConcreteRoof.Text), 1.74, "Beton"));
            materialList.Add(new Material(Convert.ToDouble(textBoxYtongRoof.Text), 0.09, "Ytong"));
            materialList.Add(new Material(Convert.ToDouble(textBoxPolystyreneRoof.Text), 0.03, "Polystyren"));
            materialList.Add(new Material(Convert.ToDouble(textBoxPlasterRoof.Text), 0.25, "Omietka"));
            materialList.Add(new Material(Convert.ToDouble(textBoxGlassWoolRoof.Text), 0.039, "Sklena Vata"));
            materialList.Add(new Material(Convert.ToDouble(textBoxPlasterBoardRoof.Text), 0.34, "Sadrokarton"));
            return new Roof(Convert.ToDouble(textBoxRoofArea.Text), materialList);
        }
    }
}
