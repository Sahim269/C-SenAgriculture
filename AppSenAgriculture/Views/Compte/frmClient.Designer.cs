namespace AppSenAgriculture.Views.Account
{
    partial class frmClient
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();

            // Configuration du formulaire
            this.Text = "Gestion des Clients";
            this.Size = new System.Drawing.Size(950, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmClient_Load);

            // Panneau gauche - Formulaire
            int xLabel = 20;
            int xInput = 130;
            int yStart = 30;
            int espacement = 60;

            // Nom Prénom
            AjouterLabel("Nom Prénom", xLabel, yStart);
            txtNomPrenom.Location = new System.Drawing.Point(xInput, yStart);
            txtNomPrenom.Size = new System.Drawing.Size(250, 25);

            // Adresse
            AjouterLabel("Adresse", xLabel, yStart + espacement);
            txtAdresse.Location = new System.Drawing.Point(xInput, yStart + espacement);
            txtAdresse.Size = new System.Drawing.Size(250, 25);

            // Email
            AjouterLabel("Email", xLabel, yStart + espacement * 2);
            txtEmail.Location = new System.Drawing.Point(xInput, yStart + espacement * 2);
            txtEmail.Size = new System.Drawing.Size(250, 25);

            // Téléphone
            AjouterLabel("Telephone", xLabel, yStart + espacement * 3);
            txtTelephone.Location = new System.Drawing.Point(xInput, yStart + espacement * 3);
            txtTelephone.Size = new System.Drawing.Size(250, 25);

            // Identifiant
            AjouterLabel("Identifiant", xLabel, yStart + espacement * 4);
            txtIdentifiant.Location = new System.Drawing.Point(xInput, yStart + espacement * 4);
            txtIdentifiant.Size = new System.Drawing.Size(250, 25);

            // Profession
            AjouterLabel("Profession", xLabel, yStart + espacement * 5);
            txtProfession.Location = new System.Drawing.Point(xInput, yStart + espacement * 5);
            txtProfession.Size = new System.Drawing.Size(250, 25);

            // Boutons
            int yBtn = yStart + espacement * 6 + 10;
            btnAjouter.Text = "Ajouter";
            btnAjouter.Location = new System.Drawing.Point(xLabel, yBtn);
            btnAjouter.Size = new System.Drawing.Size(100, 35);
            btnAjouter.BackColor = System.Drawing.Color.Green;
            btnAjouter.ForeColor = System.Drawing.Color.White;
            btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            btnModifier.Text = "Modifier";
            btnModifier.Location = new System.Drawing.Point(xLabel + 110, yBtn);
            btnModifier.Size = new System.Drawing.Size(100, 35);
            btnModifier.BackColor = System.Drawing.Color.Orange;
            btnModifier.ForeColor = System.Drawing.Color.White;
            btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            btnSupprimer.Text = "Supprimer";
            btnSupprimer.Location = new System.Drawing.Point(xLabel + 220, yBtn);
            btnSupprimer.Size = new System.Drawing.Size(100, 35);
            btnSupprimer.BackColor = System.Drawing.Color.Red;
            btnSupprimer.ForeColor = System.Drawing.Color.White;
            btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            // DataGridView - Panneau droit
            this.dgvClients.Location = new System.Drawing.Point(420, 10);
            this.dgvClients.Size = new System.Drawing.Size(500, 530);
            this.dgvClients.ReadOnly = true;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            this.dgvClients.Columns.Add("Id", "ID");
            this.dgvClients.Columns.Add("Nom", "Nom");
            this.dgvClients.Columns.Add("Prenom", "Prénom");
            this.dgvClients.Columns.Add("Adresse", "Adresse");
            this.dgvClients.Columns.Add("Email", "Email");
            this.dgvClients.Columns.Add("Telephone", "Téléphone");
            this.dgvClients.Columns.Add("Profession", "Profession");

            // Ajoute les contrôles au formulaire
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                dgvClients,
                txtNomPrenom, txtAdresse, txtEmail,
                txtTelephone, txtIdentifiant, txtProfession,
                btnAjouter, btnModifier, btnSupprimer
            });
        }

        /// <summary>
        /// Ajoute un label au formulaire.
        /// </summary>
        private void AjouterLabel(string texte, int x, int y)
        {
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            lbl.Text = texte;
            lbl.Location = new System.Drawing.Point(x, y + 3);
            lbl.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(lbl);
        }

        // Déclaration des contrôles
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
    }
}