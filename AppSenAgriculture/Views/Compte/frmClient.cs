using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using AppSenAgriculture.Helper;
using AppSenAgriculture.Models;

namespace AppSenAgriculture.Views.Account
{
    /// <summary>
    /// Formulaire de gestion des clients.
    /// Permet d'ajouter, modifier et supprimer des clients.
    /// </summary>
    public partial class frmClient : Form
    {
        // Contexte de la base de données
        private BdSenAgricultureContext _context = new BdSenAgricultureContext();

        // ID du client sélectionné dans le DataGridView
        private int _idClientSelectionne = 0;

        public frmClient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement du formulaire : charge la liste des clients.
        /// </summary>
        private void frmClient_Load(object sender, EventArgs e)
        {
            ChargerClients();
        }

        /// <summary>
        /// Charge et affiche la liste des clients dans le DataGridView.
        /// </summary>
        private void ChargerClients()
        {
            try
            {
                // Recharge le contexte pour avoir les données fraîches
                _context = new BdSenAgricultureContext();

                // Récupère la liste des clients
                var clients = _context.Clients.ToList();

                // Vide le DataGridView
                dgvClients.Rows.Clear();

                // Remplit le DataGridView
                foreach (var client in clients)
                {
                    dgvClients.Rows.Add(
                        client.IdPersonne,
                        client.NomPersonne,
                        client.PrenomPersonne,
                        client.AdresseClient,
                        client.EmailPersonne,
                        client.TelephonePersonne,
                        client.ProfessionClient
                    );
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteFileError("frmClient.ChargerClients : " + ex.ToString());
                MessageBox.Show("Erreur lors du chargement : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Réinitialise les champs du formulaire.
        /// </summary>
        private void ResetForm()
        {
            _idClientSelectionne = 0;
            txtNom.Clear();
            txtPrenom.Clear();
            txtAdresse.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
            txtIdentifiant.Clear();
            txtProfession.Clear();
        }

        /// <summary>
        /// Remplit les champs du formulaire avec les données de la ligne sélectionnée.
        /// </summary>
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClients.Rows[e.RowIndex];

                // Récupère l'ID du client sélectionné
                _idClientSelectionne = Convert.ToInt32(row.Cells[0].Value);

                // Remplit les champs du formulaire
                txtNom.Text = row.Cells[1].Value?.ToString();
                txtPrenom.Text = row.Cells[2].Value?.ToString();
                txtAdresse.Text = row.Cells[3].Value?.ToString();
                txtEmail.Text = row.Cells[4].Value?.ToString();
                txtTelephone.Text = row.Cells[5].Value?.ToString();
                txtProfession.Text = row.Cells[6].Value?.ToString();
            }
        }

        /// <summary>
        /// Ajoute un nouveau client dans la base de données.
        /// </summary>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            try
            {
                // Recuperer le nom et le prénom
                string nom = txtNom.Text.Trim();
                string prenom = txtPrenom.Text.Trim();

                Client client = new Client
                {
                    NomPersonne = nom,
                    PrenomPersonne = prenom,
                    AdresseClient = txtAdresse.Text.Trim(),
                    EmailPersonne = txtEmail.Text.Trim(),
                    TelephonePersonne = txtTelephone.Text.Trim(),
                    ProfessionClient = txtProfession.Text.Trim()
                };

                _context.Clients.Add(client);
                _context.SaveChanges();

                // Log de l'action
                LogHelper.WriteAction("Admin", "Nouveau client ajouté : " + client.NomPersonne);

                MessageBox.Show("Client ajouté avec succès !",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                ChargerClients();
            }
            catch (Exception ex)
            {
                LogHelper.WriteFileError("frmClient.btnAjouter_Click : " + ex.ToString());
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modifie le client sélectionné dans la base de données.
        /// </summary>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (_idClientSelectionne == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client.",
                    "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValiderChamps()) return;

            try
            {
                var client = _context.Clients.Find(_idClientSelectionne);
                if (client != null)
                {
                    // Sépare le nom et le prénom
                    client.NomPersonne = txtNom.Text.Trim(); ;
                    client.PrenomPersonne = txtPrenom.Text.Trim();
                    client.AdresseClient = txtAdresse.Text.Trim();
                    client.EmailPersonne = txtEmail.Text.Trim();
                    client.TelephonePersonne = txtTelephone.Text.Trim();
                    client.ProfessionClient = txtProfession.Text.Trim();

                    _context.SaveChanges();

                    // Log de l'action
                    LogHelper.WriteAction("Admin", "Client modifié : " + client.NomPersonne);

                    MessageBox.Show("Client modifié avec succès !",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetForm();
                    ChargerClients();
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteFileError("frmClient.btnModifier_Click : " + ex.ToString());
                MessageBox.Show("Erreur lors de la modification : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Supprime le client sélectionné de la base de données.
        /// </summary>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (_idClientSelectionne == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client.",
                    "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Demande confirmation avant suppression
            DialogResult confirm = MessageBox.Show(
                "Voulez-vous vraiment supprimer ce client ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var client = _context.Clients.Find(_idClientSelectionne);
                    if (client != null)
                    {
                        string nom = client.NomPersonne;
                        _context.Clients.Remove(client);
                        _context.SaveChanges();

                        // Log de l'action
                        LogHelper.WriteAction("Admin", "Client supprimé : " + nom);

                        MessageBox.Show("Client supprimé avec succès !",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetForm();
                        ChargerClients();
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.WriteFileError("frmClient.btnSupprimer_Click : " + ex.ToString());
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Valide les champs obligatoires du formulaire.
        /// </summary>
        private bool ValiderChamps()
        {
            if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPrenom.Text) ||
                string.IsNullOrEmpty(txtTelephone.Text))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires.",
                    "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblNomPrenom_Click(object sender, EventArgs e)
        {

        }
    }
}