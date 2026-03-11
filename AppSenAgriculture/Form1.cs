using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSenAgriculture.Models;
using AppSenAgriculture.Helper;


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
            // Récupère les informations de connexion
            string login = txtIdentifiant.Text.Trim();
            string motDePasse = txtMotDePasse.Text;

            // Vérifie que les champs ne sont pas vides
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Vérifie les informations de connexion dans la base de données
                using (var context = new BdSenAgricultureContext())
                {
                    var admin = context.Admins.FirstOrDefault(a => a.Login == login);
                    if (admin != null && CryptageHelper.VerifierMotDePasse(motDePasse, admin.MotDePasse))
                    {
                        // Enregistre la connexion réussie dans les logs
                        LogHelper.WriteAction(login, "Connexion réussie");
                        MailHelper.EnvoyerMail(
                        System.Configuration.ConfigurationManager.AppSettings["Email"],
                            "Connexion SenAgriculture",
                            "Bonjour,\n\nUne connexion a été effectuée avec le compte : " + login + "\nDate : " + DateTime.Now
                        );
                         // Connexion réussie, ouvre le formulaire principal
                        frmMDI mdiForm = new frmMDI();
                        mdiForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Enregistre la tentative de connexion échouée dans les logs
                        LogHelper.WriteAction(login, "Tentative de connexion échouée");

                        // Connexion échouée, affiche un message d'erreur
                        MessageBox.Show("Login ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Enregistre l'erreur dans les logs
                LogHelper.WriteFileError("frmConnexion.BtnConnexion_Click : " + ex.ToString());

                // Affiche un message d'erreur à l'utilisateur
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            using (var context = new BdSenAgricultureContext())
            {
                if (!context.Admins.Any())
                {
                    // Crée un compte administrateur par défaut
                    Admin admin = new Admin
                    {
                        NomPersonne = "Admin",
                        PrenomPersonne="Admin",
                        TelephonePersonne="777756224",
                        Login = "admin",
                        MotDePasse = CryptageHelper.HacherMotDePasse("admin123") // Mot de passe par défaut
                    };
                    context.Admins.Add(admin);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        // Enregistre l'erreur dans les logs
                        LogHelper.WriteFileError("frmConnexion.frmConnexion_Load : " + ex.ToString());
                        // Affiche un message d'erreur à l'utilisateur
                        MessageBox.Show("Erreur lors de la création du compte administrateur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
