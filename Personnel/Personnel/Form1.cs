using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        private void ascendingBtn_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.OrderByAscending(this.personnelDataSet.Employee);
        }

        private void descendingBtn_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.OrderByDesc(this.personnelDataSet.Employee);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SearchDesc(this.personnelDataSet.Employee, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);
        }
    }
}
