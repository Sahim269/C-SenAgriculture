using AppSenAgriculture.Views.Parametre;
using System;
using System.Globalization;
using System.Windows.Forms;
using AppSenAgriculture.Helper;
using AppSenAgriculture.Views.Account;

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
            LogHelper.WriteAction("Admin", "Déconnexion");
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogHelper.WriteAction("Admin", "Déconnexion et fermeture de l'application");
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

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmClient f = new frmClient();
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