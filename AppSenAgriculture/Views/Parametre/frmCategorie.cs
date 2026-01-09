using AppSenAgriculture.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenAgriculture.Views.Parametre
{
    public partial class frmCategorie : Form
    {
        public frmCategorie()
        {
            InitializeComponent();
        }

        BdSenAgricultureContext db = new BdSenAgricultureContext();

        private void frmCategorie_Load(object sender, EventArgs e)
        {
            DgCategorie.DataSource = db.Categories.ToList();
        }

        private void effacer_champs()
        {
            txtLibelle.Clear();
            txtDescription.Clear();
            DgCategorie.DataSource = db.Categories.ToList();
            txtLibelle.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Categorie cat = new Categorie()
            {
                LibelleCategorie = txtLibelle.Text,
                DescriptionCategorie = txtDescription.Text
            };
            //Ajouter la catégorie dans la base de données cache
            db.Categories.Add(cat);
            //Ajouter dans la base de données physique
            db.SaveChanges();
            effacer_champs();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(DgCategorie.CurrentRow.Cells[0].Value.ToString());
            Categorie cat = db.Categories.Find(id);
            if (cat != null)
            {
                cat.LibelleCategorie = txtLibelle.Text;
                cat.DescriptionCategorie = txtDescription.Text;
                db.SaveChanges();
                effacer_champs();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(DgCategorie.CurrentRow.Cells[0].Value.ToString());
            Categorie cat = db.Categories.Find(id);
            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
                effacer_champs();
            }
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            txtLibelle.Text = DgCategorie.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
