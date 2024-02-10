using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03_excepEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double f =double.Parse( this.txtfirst.Text);
            double s = double.Parse(this.txtsecond.Text);
            this.lblResult.Text =$"Result of Add= {f + s} ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double f = double.Parse(this.txtfirst.Text);
            double s = double.Parse(this.txtsecond.Text);
            this.lblResult.Text = $"Result of Add= {f - s} ";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            double f = double.Parse(this.txtfirst.Text);
            double s = double.Parse(this.txtsecond.Text);
            this.lblResult.Text = $"Result of multiply= {f* s} ";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double f = double.Parse(this.txtfirst.Text);
            double s = double.Parse(this.txtsecond.Text);
            this.lblResult.Text = $"Result of Deivide= {f / s} ";
        }
    }
}
