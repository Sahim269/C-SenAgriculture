namespace AppSenAgriculture
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAccentTop = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblAppLogo = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.panelStatusBar = new System.Windows.Forms.Panel();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblStatusDate = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.panelStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.parametresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 78);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(754, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.seDeconnecterToolStripMenuItem.Text = "🔓  &Se deconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.quitterToolStripMenuItem.Text = "✖  &Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // parametresToolStripMenuItem
            // 
            this.parametresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitsToolStripMenuItem,
            this.categorieToolStripMenuItem,
            this.lieuToolStripMenuItem,
            this.ClientToolStripMenuItem});
            this.parametresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            this.parametresToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.parametresToolStripMenuItem.Text = "Parametre";
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.produitsToolStripMenuItem.Text = "🌱  &Produit";
            this.produitsToolStripMenuItem.Click += new System.EventHandler(this.produitsToolStripMenuItem_Click);
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.categorieToolStripMenuItem.Text = "📂  &Categorie";
            this.categorieToolStripMenuItem.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click);
            // 
            // lieuToolStripMenuItem
            // 
            this.lieuToolStripMenuItem.Name = "lieuToolStripMenuItem";
            this.lieuToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.lieuToolStripMenuItem.Text = "📍  Lieu";


             // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.ClientToolStripMenuItem.Text = "👤  Client";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // panelAccentTop
            // 
            this.panelAccentTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(168)))), ((int)(((byte)(60)))));
            this.panelAccentTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccentTop.Location = new System.Drawing.Point(0, 0);
            this.panelAccentTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAccentTop.Name = "panelAccentTop";
            this.panelAccentTop.Size = new System.Drawing.Size(754, 5);
            this.panelAccentTop.TabIndex = 3;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(40)))));
            this.panelTopBar.Controls.Add(this.lblAppLogo);
            this.panelTopBar.Controls.Add(this.lblAppTitle);
            this.panelTopBar.Controls.Add(this.lblAppSubtitle);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 5);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(754, 73);
            this.panelTopBar.TabIndex = 2;
            // 
            // lblAppLogo
            // 
            this.lblAppLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblAppLogo.Font = new System.Drawing.Font("Segoe UI Emoji", 30F);
            this.lblAppLogo.ForeColor = System.Drawing.Color.White;
            this.lblAppLogo.Location = new System.Drawing.Point(3, 6);
            this.lblAppLogo.Name = "lblAppLogo";
            this.lblAppLogo.Size = new System.Drawing.Size(73, 56);
            this.lblAppLogo.TabIndex = 98;
            this.lblAppLogo.Text = "🌾";
            this.lblAppLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppTitle.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(71, 8);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(444, 43);
            this.lblAppTitle.TabIndex = 99;
            this.lblAppTitle.Text = "Sen Agriculture";
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(73, 51);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(444, 22);
            this.lblAppSubtitle.TabIndex = 100;
            this.lblAppSubtitle.Text = "Système de gestion agricole";
            // 
            // panelStatusBar
            // 
            this.panelStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(30)))));
            this.panelStatusBar.Controls.Add(this.lblStatusText);
            this.panelStatusBar.Controls.Add(this.lblStatusDate);
            this.panelStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatusBar.Location = new System.Drawing.Point(0, 336);
            this.panelStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelStatusBar.Name = "panelStatusBar";
            this.panelStatusBar.Size = new System.Drawing.Size(754, 40);
            this.panelStatusBar.TabIndex = 1;
            // 
            // lblStatusText
            // 
            this.lblStatusText.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            this.lblStatusText.Location = new System.Drawing.Point(3, 10);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(356, 21);
            this.lblStatusText.TabIndex = 201;
            this.lblStatusText.Text = "🟢  Connecté — Sen Agriculture";
            // 
            // lblStatusDate
            // 
            this.lblStatusDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatusDate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.lblStatusDate.Location = new System.Drawing.Point(505, 0);
            this.lblStatusDate.Name = "lblStatusDate";
            this.lblStatusDate.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.lblStatusDate.Size = new System.Drawing.Size(249, 40);
            this.lblStatusDate.TabIndex = 202;
            this.lblStatusDate.Text = "Tuesday 03 March 2026  12:30";
            this.lblStatusDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(754, 376);
            this.ControlBox = false;
            this.Controls.Add(this.panelStatusBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelAccentTop);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMDI";
            this.Text = "Sen Agriculture ::";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.panelStatusBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;

        // ──contrôles décoratifs ─────────────────────────────────────
        private System.Windows.Forms.Panel panelAccentTop;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblAppLogo;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Panel panelStatusBar;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblStatusDate;
    }
}