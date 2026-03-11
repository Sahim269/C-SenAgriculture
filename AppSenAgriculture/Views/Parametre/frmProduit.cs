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
using System.Data.Entity;


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
                Categorie = u.Categorie.LibelleCategorie,
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
            try
            {
                Produit p = new Produit();
                // Validation robuste avant conversion
                var sel = cbbUniteMesure.SelectedValue;

                int? idUnite = db.UniteMesures.Where(u => u.CodeUnite == sel).Select(u => u.idUnite).FirstOrDefault();

                if (!idUnite.HasValue)
                {
                    MessageBox.Show("Veuillez selectionner une unité de mesure valide.");
                    return;
                }

                if (int.Parse(txtPrixUnitaireMax.Text) < int.Parse(txtPrixUnitaireMin.Text))
                {
                    MessageBox.Show("Le prix minimum ne doit pas etre superieur au prix maximum");
                    return;
                }

                p.IdUniteMesure = (int)idUnite;
                p.CategorieId = int.Parse(cbbCategorie.SelectedValue.ToString());
                p.LibelleProduit = txtLibelle.Text;
                p.DescriptionProduit = txtDescription.Text;
                p.PrixUnitaireMax = double.Parse(txtPrixUnitaireMax.Text);
                p.PrixUnitaireMin = double.Parse(txtPrixUnitaireMin.Text);
                db.Produits.Add(p);

                db.SaveChanges();
                ResetFrom();

            }
            catch
            {
                MessageBox.Show("Erreur lors de la creation du produit");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Produit p = db.Produits.Find(dgProduits.CurrentRow.Cells[0].Value);

                p.CategorieId = int.Parse(cbbCategorie.SelectedValue.ToString());
                p.LibelleProduit = txtLibelle.Text;
                p.DescriptionProduit = txtDescription.Text;
                p.PrixUnitaireMax = double.Parse(txtPrixUnitaireMax.Text);
                p.PrixUnitaireMin = double.Parse(txtPrixUnitaireMin.Text);
                p.IdUniteMesure = int.Parse(cbbUniteMesure.SelectedValue.ToString());
                db.SaveChanges();
                ResetFrom();
            }
            catch
            {
                MessageBox.Show("Erreur ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = int.Parse(dgProduits.CurrentRow.Cells[0].Value.ToString());
                var p = db.Produits.Find(id);
                db.Produits.Remove(p);
                db.SaveChanges();
                ResetFrom();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la suppression");
            }
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = int.Parse(dgProduits.CurrentRow.Cells[0].Value.ToString());
                var p = db.Produits.Find(id);

                txtDescription.Text = p.DescriptionProduit;
                txtLibelle.Text = p.LibelleProduit;
                txtPrixUnitaireMax.Text = p.PrixUnitaireMax.ToString();
                txtPrixUnitaireMin.Text = p.PrixUnitaireMin.ToString();
                cbbCategorie.SelectedValue = p.CategorieId.ToString();
                cbbUniteMesure.SelectedValue = p.IdUniteMesure.ToString();
            }
            catch
            {
               
            }
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
                Categorie = db.Categories.Find(u.CategorieId).LibelleCategorie,
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


    // TODO : Créer un bouton "Générer PDF" dans le Designer (frmProduit.Designer.cs)
    // Nom du bouton : btnGenererPDF
    // Texte du bouton : "Générer PDF"
    // Puis associer l'événement Click à cette méthode
    private void btnGenererPDF_Click(object sender, EventArgs e)
{
    try
    {
        // Récupère la liste des produits depuis la base de données
        using (var context = new BdSenAgricultureContext())
        {
            // Charge les produits avec leurs catégories associées
            var produits = context.Produits.Include("Categorie").ToList();

            // Génère le rapport PDF et récupère le chemin du fichier
            string cheminPDF = RapportHelper.GenererRapportProduits(produits);

            // Log de l'action
            LogHelper.WriteAction("Admin", "Rapport PDF produits généré : " + cheminPDF);

            // Informe l'utilisateur que le rapport a été généré
            MessageBox.Show(
                "Rapport généré avec succès !\n" + cheminPDF,
                "Succès",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
    catch (Exception ex)
    {
        // Enregistre l'erreur dans les logs
        LogHelper.WriteFileError("frmProduit.btnGenererPDF_Click : " + ex.ToString());

        // Affiche un message d'erreur
        MessageBox.Show("Erreur lors de la génération du rapport : " + ex.Message,
            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}   
    }
}
