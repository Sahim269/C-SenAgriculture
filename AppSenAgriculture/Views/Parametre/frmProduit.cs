using AppSenAgriculture.Helper;
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
    public partial class frmProduit : Form
    {
        public frmProduit()
        {
            InitializeComponent();
        }
        BdSenAgricultureContext db = new BdSenAgricultureContext();

        FillList fillList = new FillList();

        private void ResetFrom()
        {
            cbbUniteMesure.DataSource = fillList.fillUniteMesure();
            cbbUniteMesure.DisplayMember = "Text";
            cbbUniteMesure.ValueMember = "Value";

            cbbCategorie.DataSource = fillList.fillCategorie();
            cbbCategorie.DisplayMember = "Text";
            cbbCategorie.ValueMember = "Value";

            dgProduits.DataSource = db.Produits.Select(u => new
            { 
                u.IdProduit,
                u.LibelleProduit,
                u.DescriptionProduit,
                u.PrixUnitaireMin,
                u.PrixUnitaireMax,
                Categorie = u.Categorie.DescriptionCategorie,
                UniteMesure = u.UniteMesure.NameUnite
            }


             ).ToList();

            txtDescription.Text = string.Empty;
            txtPrixUnitaireMax.Text = string.Empty;
            txtPrixUnitaireMin.Text = string.Empty;
            txtLibelle.Text = string.Empty;

            txtLibelle.Focus();
        }
        private void frmProduit_Load(object sender, EventArgs e)
        {
            ResetFrom();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            // Validation robuste avant conversion
            var sel = Convert.ToString(cbbUniteMesure.SelectedValue);
            if (int.TryParse(sel, out int idUnite))
            {
                p.IdUniteMesure = idUnite;
            }
            else
            {
                // Mapper les codes texte vers des ids connus ou gérer l'erreur utilisateur
                switch (sel)
                {
                    case "g": p.IdUniteMesure = 1; break;
                    case "kg": p.IdUniteMesure = 2; break;
                    default:
                        MessageBox.Show("Unité invalide, veuillez sélectionner une unité valide.");
                        return;
                }
            }

            p.CategorieId = int.Parse(cbbCategorie.SelectedValue.ToString());
            p.LibelleProduit = txtLibelle.Text;
            p.DescriptionProduit = txtDescription.Text;
            p.PrixUnitaireMax = double.Parse(txtPrixUnitaireMax.Text);
            p.PrixUnitaireMin = double.Parse(txtPrixUnitaireMin.Text);
            db.Produits.Add(p);
            db.SaveChanges();
            ResetFrom();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();

            p.CategorieId = int.Parse(cbbCategorie.SelectedValue.ToString());
            p.LibelleProduit = txtLibelle.Text;
            p.DescriptionProduit = txtDescription.Text;
            p.PrixUnitaireMax = double.Parse(txtPrixUnitaireMax.Text);
            p.PrixUnitaireMin = double.Parse(txtPrixUnitaireMin.Text);
            db.SaveChanges();
            ResetFrom();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduits.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produits.Find(id);
            db.Produits.Remove(p);
            db.SaveChanges();
            ResetFrom();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduits.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produits.Find(id);
            txtDescription.Text = p.DescriptionProduit;
            txtLibelle.Text = p.LibelleProduit;
            txtPrixUnitaireMax.Text = p.PrixUnitaireMax.ToString();
            txtPrixUnitaireMin.Text = p.PrixUnitaireMin.ToString();
            cbbCategorie.SelectedIndex = p.CategorieId;
            cbbUniteMesure.SelectedIndex = p.IdUniteMesure;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.Produits.ToList();

            if (!string.IsNullOrEmpty(txtRLibelle.Text))
            {
                liste = liste.Where(a => a.LibelleProduit.ToUpper().Contains(txtRLibelle.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtRDescription.Text))
            {
                liste = liste.Where(a => a.DescriptionProduit.ToUpper().Contains(txtRDescription.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtRPrixMin.Text))
            {
                int price = int.Parse(txtRPrixMin.Text);
                liste = liste.Where(a => a.PrixUnitaireMin>=price).ToList();
            }

            dgProduits.DataSource = liste.Select(u => new
            {
                u.IdProduit,
                u.LibelleProduit,
                u.DescriptionProduit,
                u.PrixUnitaireMin,
                u.PrixUnitaireMax,
                Categorie = db.Categories.Find(u.CategorieId).DescriptionCategorie,
                UniteMesure = db.UniteMesures.Find(u.IdUniteMesure).NameUnite
            }).ToList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
