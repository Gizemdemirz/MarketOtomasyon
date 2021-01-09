using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtamasyon.Forms
{
    public partial class SatısSil : Form
    {
        public SatısSil()
        {
            InitializeComponent();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if(txtSifre.Text == "123456")
            {
           
                this.Hide();
            }
            else
            {
                lblHata.Text = "Şifre hatalı!!";
                txtSifre.Text = "";
            }
        }
    }
}
