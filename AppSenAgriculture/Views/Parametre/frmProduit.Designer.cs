namespace AppSenAgriculture.Views.Parametre
{
    partial class frmProduit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrixUnitaireMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrixUnitaireMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbUniteMesure = new System.Windows.Forms.ComboBox();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.dgProduits = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRLibelle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRPrixMin = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.panelAccentTop = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblPageIcon = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelGoldBar = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libelle";
            // 
            // txtLibelle
            // 
            this.txtLibelle.BackColor = System.Drawing.Color.White;
            this.txtLibelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibelle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLibelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.txtLibelle.Location = new System.Drawing.Point(12, 69);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(249, 30);
            this.txtLibelle.TabIndex = 1;
            this.txtLibelle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.txtDescription.Location = new System.Drawing.Point(11, 130);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(249, 30);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(8, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPrixUnitaireMin
            // 
            this.txtPrixUnitaireMin.BackColor = System.Drawing.Color.White;
            this.txtPrixUnitaireMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrixUnitaireMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrixUnitaireMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.txtPrixUnitaireMin.Location = new System.Drawing.Point(12, 198);
            this.txtPrixUnitaireMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrixUnitaireMin.Name = "txtPrixUnitaireMin";
            this.txtPrixUnitaireMin.Size = new System.Drawing.Size(249, 30);
            this.txtPrixUnitaireMin.TabIndex = 5;
            this.txtPrixUnitaireMin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label3.Location = new System.Drawing.Point(10, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prix Unitaire Minimale";
            // 
            // txtPrixUnitaireMax
            // 
            this.txtPrixUnitaireMax.BackColor = System.Drawing.Color.White;
            this.txtPrixUnitaireMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrixUnitaireMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrixUnitaireMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.txtPrixUnitaireMax.Location = new System.Drawing.Point(12, 263);
            this.txtPrixUnitaireMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrixUnitaireMax.Name = "txtPrixUnitaireMax";
            this.txtPrixUnitaireMax.Size = new System.Drawing.Size(249, 30);
            this.txtPrixUnitaireMax.TabIndex = 7;
            this.txtPrixUnitaireMax.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label4.Location = new System.Drawing.Point(11, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix Unitaire Maximale";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label5.Location = new System.Drawing.Point(11, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unite de Mesure";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label6.Location = new System.Drawing.Point(14, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categorie";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbUniteMesure
            // 
            this.cbbUniteMesure.BackColor = System.Drawing.Color.White;
            this.cbbUniteMesure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbUniteMesure.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbUniteMesure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.cbbUniteMesure.FormattingEnabled = true;
            this.cbbUniteMesure.Location = new System.Drawing.Point(12, 328);
            this.cbbUniteMesure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbUniteMesure.Name = "cbbUniteMesure";
            this.cbbUniteMesure.Size = new System.Drawing.Size(249, 31);
            this.cbbUniteMesure.TabIndex = 12;
            this.cbbUniteMesure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.BackColor = System.Drawing.Color.White;
            this.cbbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCategorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Location = new System.Drawing.Point(12, 390);
            this.cbbCategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(249, 31);
            this.cbbCategorie.TabIndex = 13;
            this.cbbCategorie.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(40)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(32)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(12, 467);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(249, 38);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(55)))), ((int)(((byte)(40)))));
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(40)))), ((int)(((byte)(28)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(12, 556);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(249, 38);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(135)))), ((int)(((byte)(30)))));
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(110)))), ((int)(((byte)(20)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(12, 511);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(249, 38);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.btnSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelection.FlatAppearance.BorderSize = 0;
            this.btnSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(32)))));
            this.btnSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelection.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnSelection.ForeColor = System.Drawing.Color.White;
            this.btnSelection.Location = new System.Drawing.Point(12, 10);
            this.btnSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(249, 29);
            this.btnSelection.TabIndex = 17;
            this.btnSelection.Text = "Selectionner";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // dgProduits
            // 
            this.dgProduits.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.dgProduits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProduits.BackgroundColor = System.Drawing.Color.White;
            this.dgProduits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProduits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProduits.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProduits.EnableHeadersVisualStyles = false;
            this.dgProduits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(195)))), ((int)(((byte)(160)))));
            this.dgProduits.Location = new System.Drawing.Point(8, 6);
            this.dgProduits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgProduits.Name = "dgProduits";
            this.dgProduits.RowHeadersVisible = false;
            this.dgProduits.RowHeadersWidth = 40;
            this.dgProduits.RowTemplate.Height = 28;
            this.dgProduits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduits.Size = new System.Drawing.Size(966, 556);
            this.dgProduits.TabIndex = 18;
            this.dgProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduits_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRLibelle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRDescription);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRPrixMin);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(968, 84);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label7.Location = new System.Drawing.Point(8, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Libelle";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtRLibelle
            // 
            this.txtRLibelle.BackColor = System.Drawing.Color.White;
            this.txtRLibelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRLibelle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRLibelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.txtRLibelle.Location = new System.Drawing.Point(10, 50);
            this.txtRLibelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRLibelle.Name = "txtRLibelle";
            this.txtRLibelle.Size = new System.Drawing.Size(191, 30);
            this.txtRLibelle.TabIndex = 21;
            this.txtRLibelle.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label8.Location = new System.Drawing.Point(217, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Description";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRDescription
            // 
            this.txtRDescription.BackColor = System.Drawing.Color.White;
            this.txtRDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.txtRDescription.Location = new System.Drawing.Point(219, 50);
            this.txtRDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRDescription.Name = "txtRDescription";
            this.txtRDescription.Size = new System.Drawing.Size(234, 30);
            this.txtRDescription.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.label9.Location = new System.Drawing.Point(465, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Prix Unitaire Min.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRPrixMin
            // 
            this.txtRPrixMin.BackColor = System.Drawing.Color.White;
            this.txtRPrixMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRPrixMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRPrixMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.txtRPrixMin.Location = new System.Drawing.Point(467, 50);
            this.txtRPrixMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRPrixMin.Name = "txtRPrixMin";
            this.txtRPrixMin.Size = new System.Drawing.Size(125, 30);
            this.txtRPrixMin.TabIndex = 25;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.FlatAppearance.BorderSize = 0;
            this.btnRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(32)))));
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(640, 44);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(116, 34);
            this.btnRechercher.TabIndex = 20;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // panelAccentTop
            // 
            this.panelAccentTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(168)))), ((int)(((byte)(60)))));
            this.panelAccentTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccentTop.Location = new System.Drawing.Point(0, 0);
            this.panelAccentTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAccentTop.Name = "panelAccentTop";
            this.panelAccentTop.Size = new System.Drawing.Size(1258, 4);
            this.panelAccentTop.TabIndex = 50;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.panelTitleBar.Controls.Add(this.lblPageIcon);
            this.panelTitleBar.Controls.Add(this.lblPageTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 4);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1258, 52);
            this.panelTitleBar.TabIndex = 49;
            // 
            // lblPageIcon
            // 
            this.lblPageIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblPageIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.lblPageIcon.ForeColor = System.Drawing.Color.White;
            this.lblPageIcon.Location = new System.Drawing.Point(10, 8);
            this.lblPageIcon.Name = "lblPageIcon";
            this.lblPageIcon.Size = new System.Drawing.Size(25, 33);
            this.lblPageIcon.TabIndex = 98;
            this.lblPageIcon.Text = "🌱";
            this.lblPageIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(38, 10);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(196, 31);
            this.lblPageTitle.TabIndex = 99;
            this.lblPageTitle.Text = "Produit";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.panelLeft.Controls.Add(this.btnSelection);
            this.panelLeft.Controls.Add(this.panelGoldBar);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.txtLibelle);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.txtDescription);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.txtPrixUnitaireMin);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.txtPrixUnitaireMax);
            this.panelLeft.Controls.Add(this.label5);
            this.panelLeft.Controls.Add(this.cbbUniteMesure);
            this.panelLeft.Controls.Add(this.label6);
            this.panelLeft.Controls.Add(this.cbbCategorie);
            this.panelLeft.Controls.Add(this.btnAjouter);
            this.panelLeft.Controls.Add(this.btnModifier);
            this.panelLeft.Controls.Add(this.btnSupprimer);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 56);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(276, 662);
            this.panelLeft.TabIndex = 1;
            // 
            // panelGoldBar
            // 
            this.panelGoldBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(168)))), ((int)(((byte)(60)))));
            this.panelGoldBar.Location = new System.Drawing.Point(12, 43);
            this.panelGoldBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGoldBar.Name = "panelGoldBar";
            this.panelGoldBar.Size = new System.Drawing.Size(36, 2);
            this.panelGoldBar.TabIndex = 40;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(218)))));
            this.panelRight.Controls.Add(this.panelGrid);
            this.panelRight.Controls.Add(this.panelSearch);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(276, 56);
            this.panelRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(982, 662);
            this.panelRight.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(218)))));
            this.panelGrid.Controls.Add(this.dgProduits);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 94);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.panelGrid.Size = new System.Drawing.Size(982, 568);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.panelSearch.Controls.Add(this.groupBox1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panelSearch.Size = new System.Drawing.Size(982, 94);
            this.panelSearch.TabIndex = 20;
            // 
            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1258, 718);
            this.ControlBox = false;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelAccentTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProduit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.frmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrixUnitaireMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrixUnitaireMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbUniteMesure;
        private System.Windows.Forms.ComboBox cbbCategorie;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.DataGridView dgProduits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRLibelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRPrixMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Panel panelAccentTop;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblPageIcon;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelGoldBar;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelGrid;
    }
}