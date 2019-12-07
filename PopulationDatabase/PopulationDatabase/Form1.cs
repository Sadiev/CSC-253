using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
* 12/06/2019
* CSC 253
* Dilshod Sadiev
* Population Database
*/
namespace PopulationDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);

        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortComboBox.SelectedIndex)
            {
                case 0:
                    this.cityTableAdapter.OrderByPopulationASC(this.populationDBDataSet.City);
                    break;
                case 1:
                    this.cityTableAdapter.OrderByPopulationDESC(this.populationDBDataSet.City);
                    break;
                case 2:
                    this.cityTableAdapter.OrderByCity(this.populationDBDataSet.City);
                    break;
                default:
                    break;
            }
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total population of all cities is "+ this.cityTableAdapter.SumQuery());
        }

        private void AvgButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Average population of all cities is " + this.cityTableAdapter.AvgQuery());
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Highest population is " + this.cityTableAdapter.MaxQuery());
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lowest population is " + this.cityTableAdapter.MinQuery());
        }
    }
}
