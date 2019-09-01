using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multipleforms
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            adddata adddata = new adddata();
            adddata.ShowDialog();

            string data = string.Format(adddata.txtdata.Text);
            lbldata.Text = data;
            this.Text = "Ok";
        }
    }
}
