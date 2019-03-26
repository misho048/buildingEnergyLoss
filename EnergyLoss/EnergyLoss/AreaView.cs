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
     
        public Dictionary<string, double> mapOfMaterial;
        private List<ComboBox> _listOfBoxes;

        public AreaView()

        {            
            InitializeComponent();
            mapOfMaterial = DataLayer.LoadFromFile();
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            _listOfBoxes = new List<ComboBox>() {
            comboBox1Floor,comboBox2Floor,comboBox3Floor,comboBox4Floor,
            comboBox1Wall,comboBox2Wall,comboBox3Wall,comboBox4Wall,
            comboBox1Roof,comboBox2Roof,comboBox3Roof,comboBox4Roof
            };
            foreach (var comboBox in _listOfBoxes)
            {
                foreach (var key in mapOfMaterial)
                {

                    comboBox.Items.Add(key.Key.ToString());
                }
                comboBox.SelectedIndex = 0;
            }


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        public double[] ReturnArea()
        {
            return new double[] { Convert.ToDouble(numericFloorArea.Text), Convert.ToDouble(numericWallArea.Text), Convert.ToDouble(numericRoofArea.Text) };
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Don't leave any empty values");
            }
        }

        //private bool CheckComboBoxes()
        //{
            
        //    foreach(var box in _listOfBoxes)
        //    {
        //        try
        //        {
        //           string something= box.SelectedValue.ToString();
        //        }
        //        catch (NullReferenceException)
        //        {
        //            return false;
        //        }
                
        //    }
        //    return true;
        //}

        public List<(double, string)> CreateFloor()
        {
            var tupleList = new List<(double width, string value)>
            {
                (Convert.ToDouble(numericWidth1Floor.Value),comboBox1Floor.SelectedItem.ToString()),
                (Convert.ToDouble(numericWidth2Floor.Value),comboBox2Floor.SelectedItem.ToString()),
                (Convert.ToDouble(numericWidth3Floor.Value),comboBox3Floor.SelectedItem.ToString()),
                (Convert.ToDouble(numericWidth4Floor.Value),comboBox4Floor.SelectedItem.ToString()),
            };
            return tupleList;       

        }

        public List<(double, string)> CreateWall()
        {
            var tupleList = new List<(double width, string value)>
            {
                (Convert.ToDouble(numeric1Wall.Value),comboBox1Wall.SelectedItem.ToString()),
                (Convert.ToDouble(numeric2Wall.Value),comboBox2Wall.SelectedItem.ToString()),
                (Convert.ToDouble(numeric3Wall.Value),comboBox3Wall.SelectedItem.ToString()),
                (Convert.ToDouble(numeric4Wall.Value),comboBox4Wall.SelectedItem.ToString())

            };
            return tupleList;
       
        }

        public List<(double, string)> CreateRoof()
        {
            var tupleList = new List<(double width, string value)>
            {
                (Convert.ToDouble(numeric1Roof.Value),comboBox1Roof.SelectedItem.ToString()),
                (Convert.ToDouble(numeric2Roof.Value),comboBox2Roof.SelectedItem.ToString()),
                (Convert.ToDouble(numeric3Roof.Value),comboBox3Roof.SelectedItem.ToString()),
                (Convert.ToDouble(numeric4Roof.Value),comboBox4Roof.SelectedItem.ToString())

            };
            return tupleList;         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericWidth1Floor_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
