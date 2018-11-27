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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(var item in EmplList.ShowEmployee())
            {
                lstResult2.Items.Add(item);
            }

        }

        private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
