namespace AppSenAgriculture
{
    partial class frmConnexion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblDecorIcon = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubWelcome = new System.Windows.Forms.Label();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.lblIdIcon = new System.Windows.Forms.Label();
            this.lblPwIcon = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panelAccentTop = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(71, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtIdentifiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentifiant.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.txtIdentifiant.Location = new System.Drawing.Point(44, 160);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(409, 32);
            this.txtIdentifiant.TabIndex = 1;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.txtMotDePasse.Location = new System.Drawing.Point(44, 232);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(409, 32);
            this.txtMotDePasse.TabIndex = 2;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(71, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(40)))));
            this.BtnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnexion.FlatAppearance.BorderSize = 0;
            this.BtnConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(32)))));
            this.BtnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnexion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnConnexion.ForeColor = System.Drawing.Color.White;
            this.BtnConnexion.Location = new System.Drawing.Point(258, 294);
            this.BtnConnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(196, 38);
            this.BtnConnexion.TabIndex = 3;
            this.BtnConnexion.Text = "✔  Se connecter";
            this.BtnConnexion.UseVisualStyleBackColor = false;
            this.BtnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(210)))));
            this.BtnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(195)))), ((int)(((byte)(160)))));
            this.BtnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.BtnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.BtnQuitter.Location = new System.Drawing.Point(44, 294);
            this.BtnQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(160, 38);
            this.BtnQuitter.TabIndex = 4;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = false;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(40)))));
            this.panelLeft.Controls.Add(this.lblDecorIcon);
            this.panelLeft.Controls.Add(this.lblAppName);
            this.panelLeft.Controls.Add(this.lblSlogan);
            this.panelLeft.Location = new System.Drawing.Point(0, 5);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(302, 411);
            this.panelLeft.TabIndex = 1;
            // 
            // lblDecorIcon
            // 
            this.lblDecorIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblDecorIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 72F);
            this.lblDecorIcon.ForeColor = System.Drawing.Color.White;
            this.lblDecorIcon.Location = new System.Drawing.Point(12, 63);
            this.lblDecorIcon.Name = "lblDecorIcon";
            this.lblDecorIcon.Size = new System.Drawing.Size(290, 104);
            this.lblDecorIcon.TabIndex = 98;
            this.lblDecorIcon.Text = "🌾";
            this.lblDecorIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(12, 172);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(284, 97);
            this.lblAppName.TabIndex = 99;
            this.lblAppName.Text = "Sen Agriculture";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAppName.Click += new System.EventHandler(this.lblAppName_Click);
            // 
            // lblSlogan
            // 
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            this.lblSlogan.Location = new System.Drawing.Point(12, 273);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(284, 48);
            this.lblSlogan.TabIndex = 100;
            this.lblSlogan.Text = "Cultiver l\'avenir,\nnourrir la nation 🇸🇳";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.panelRight.Controls.Add(this.lblWelcome);
            this.panelRight.Controls.Add(this.lblSubWelcome);
            this.panelRight.Controls.Add(this.panelSeparator);
            this.panelRight.Controls.Add(this.lblIdIcon);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.txtIdentifiant);
            this.panelRight.Controls.Add(this.lblPwIcon);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.txtMotDePasse);
            this.panelRight.Controls.Add(this.BtnConnexion);
            this.panelRight.Controls.Add(this.BtnQuitter);
            this.panelRight.Controls.Add(this.lblFooter);
            this.panelRight.Location = new System.Drawing.Point(302, 5);
            this.panelRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(498, 411);
            this.panelRight.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(20)))));
            this.lblWelcome.Location = new System.Drawing.Point(44, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(409, 44);
            this.lblWelcome.TabIndex = 98;
            this.lblWelcome.Text = "Bienvenue !";
            // 
            // lblSubWelcome
            // 
            this.lblSubWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblSubWelcome.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(110)))), ((int)(((byte)(75)))));
            this.lblSubWelcome.Location = new System.Drawing.Point(44, 80);
            this.lblSubWelcome.Name = "lblSubWelcome";
            this.lblSubWelcome.Size = new System.Drawing.Size(409, 21);
            this.lblSubWelcome.TabIndex = 99;
            this.lblSubWelcome.Text = "Connectez-vous à votre espace de gestion agricole";
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(168)))), ((int)(((byte)(60)))));
            this.panelSeparator.Location = new System.Drawing.Point(44, 112);
            this.panelSeparator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(53, 3);
            this.panelSeparator.TabIndex = 100;
            // 
            // lblIdIcon
            // 
            this.lblIdIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblIdIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.lblIdIcon.Location = new System.Drawing.Point(41, 133);
            this.lblIdIcon.Name = "lblIdIcon";
            this.lblIdIcon.Size = new System.Drawing.Size(30, 23);
            this.lblIdIcon.TabIndex = 97;
            this.lblIdIcon.Text = "👤";
            this.lblIdIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPwIcon
            // 
            this.lblPwIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblPwIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.lblPwIcon.Location = new System.Drawing.Point(38, 201);
            this.lblPwIcon.Name = "lblPwIcon";
            this.lblPwIcon.Size = new System.Drawing.Size(33, 29);
            this.lblPwIcon.TabIndex = 97;
            this.lblPwIcon.Text = "🔒";
            this.lblPwIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.Transparent;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(130)))));
            this.lblFooter.Location = new System.Drawing.Point(44, 368);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(409, 18);
            this.lblFooter.TabIndex = 200;
            this.lblFooter.Text = "© 2025 Sen Agriculture — Système de gestion agricole";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAccentTop
            // 
            this.panelAccentTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(168)))), ((int)(((byte)(60)))));
            this.panelAccentTop.Location = new System.Drawing.Point(0, 0);
            this.panelAccentTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAccentTop.Name = "panelAccentTop";
            this.panelAccentTop.Size = new System.Drawing.Size(800, 5);
            this.panelAccentTop.TabIndex = 0;
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.ControlBox = false;
            this.Controls.Add(this.panelAccentTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sen Agriculture :: Connexion";
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Contrôles originaux — noms et events INCHANGÉS ───────────────────
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConnexion;
        private System.Windows.Forms.Button BtnQuitter;

        // ── Nouveaux contrôles décoratifs ─────────────────────────────────────
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.Panel panelAccentTop;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblDecorIcon;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubWelcome;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblIdIcon;
        private System.Windows.Forms.Label lblPwIcon;
    }
}