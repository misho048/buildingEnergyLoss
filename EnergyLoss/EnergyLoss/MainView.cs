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
    public partial class MainView : Form
    {
        AreaView areaView = new AreaView();
        
        public MainView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelTemeperatureAvg_Click(object sender, EventArgs e)
        {

        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            
            areaView.ShowDialog();

        }

      

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (areaView.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("First Enter House Area!!!!");
            }
            else
            {
                double temperatureDifference = Math.Abs(Convert.ToDouble(textBoxAvgTemp.Text) - Convert.ToDouble(textBoxMinTemp.Text));
                double heatingLenght = Convert.ToDouble(textBoxHeatingLenght.Text);
                Mechanics Mech = new Mechanics(GetCondition(),temperatureDifference,heatingLenght);
                Mech.CreateHouse(areaView);
                MessageBox.Show(Convert.ToString(Mech.DoSomething()) + "and number of days is " + heatingLenght);
            }
        }

        private double GetCondition()
        {
            double counter = 1.00;
            if (countryWindy.Checked)
            {
                counter += 0.03;
            }
            if (buildingUnprotected.Checked)
            {
                counter += 0.03;
            }
            else if (buildingUnfavorable.Checked)
            {
                counter += 0.06;
            }
            return counter;
        }
    }
}
