using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            frmMDI f = new frmMDI();
            f.Show();
            this.Hide();
        }
    }
}
