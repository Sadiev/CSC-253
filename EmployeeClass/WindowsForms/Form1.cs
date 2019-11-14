using HRLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            Employee emp1 = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");

            Employee emp2 = new Employee("Mark Jones", 39119);
            emp2.Department = "IT";
            emp2.Position = "Programmer";

            Employee emp3 = new Employee();
            emp3.Name = "Joy Rogers";
            emp3.IdNumber = 81774;
            emp3.Department = "Manufacturing";
            emp3.Position = "Engineer";
            EmployeeListBox.Items.Add($"{"Name",-15}{"ID Number",-15}{"Department",-15}{"Position"}");

            EmployeeListBox.Items.Add(("").PadRight(60, '-'));
            EmployeeListBox.Items.Add($"{emp1.Name,-15}{emp1.IdNumber,-15}{emp1.Department,-15}{emp1.Position}");
            EmployeeListBox.Items.Add($"{emp2.Name,-15}{emp2.IdNumber,-15}{emp2.Department,-15}{emp2.Position}");
            EmployeeListBox.Items.Add($"{emp3.Name,-15}{emp3.IdNumber,-15}{emp3.Department,-15}{emp3.Position}");

        }
    }
}
