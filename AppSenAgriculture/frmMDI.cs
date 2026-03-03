using AppSenAgriculture.Views.Parametre;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace AppSenAgriculture
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void fermer()
        {
            foreach (Form chform in this.MdiChildren)
                chform.Close();
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProduit f = new frmProduit();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmCategorie f = new frmCategorie();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            // Maximized respecte les Dock (StatusBar visible)
            this.WindowState = FormWindowState.Maximized;

            // Date et heure en francais
            CultureInfo fr = new CultureInfo("fr-FR");
            this.lblStatusDate.Text = DateTime.Now.ToString("dddd dd MMMM yyyy  HH:mm", fr);
            // Resultat : "mardi 03 mars 2026  12:30"
        }
    }
}