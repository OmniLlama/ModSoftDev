using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmplApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToForm2_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(txtFirst.Text,
                txtLast.Text,
                Convert.ToDecimal(txtSalary.Text));
            lstResult.Items.Add(emp);
            txtResult.AppendText(emp.ToString());
            EmplList.AddEmployee(emp);
            
/*            txtFirst.Clear();
            txtLast.Clear();
            txtSalary.Clear();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblIndexOfSelected.Text = lstResult.SelectedIndex.ToString();
        }
    }
}
