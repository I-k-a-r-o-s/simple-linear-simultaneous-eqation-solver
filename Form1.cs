using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                double x, y;
                x = ((double.Parse(txtInput_m.Text) * double.Parse(txtInput_d.Text)) - (double.Parse(txtInput_n.Text) * double.Parse(txtInput_b.Text))) / ((double.Parse(txtInput_a.Text) * double.Parse(txtInput_d.Text)) - (double.Parse(txtInput_b.Text) * double.Parse(txtInput_c.Text)));
                y = ((double.Parse(txtInput_m.Text) * double.Parse(txtInput_c.Text)) - (double.Parse(txtInput_n.Text) * double.Parse(txtInput_a.Text))) / ((double.Parse(txtInput_b.Text) * double.Parse(txtInput_c.Text)) - (double.Parse(txtInput_a.Text) * double.Parse(txtInput_d.Text)));
                lblDisplay1.Text = x.ToString();
                lblDisplay2.Text = y.ToString();
            }
            catch
            {
                MessageBox.Show("INPUT RELEVANT DATA!!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtInput_a.Text = string.Empty;
            txtInput_b.Text = string.Empty;
            txtInput_c.Text = string.Empty;
            txtInput_d.Text = string.Empty;
            txtInput_m.Text = string.Empty;
            txtInput_n.Text = string.Empty;
            lblDisplay1.Text = "ax+by=m";
            lblDisplay2.Text = "cx+dy=n";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
