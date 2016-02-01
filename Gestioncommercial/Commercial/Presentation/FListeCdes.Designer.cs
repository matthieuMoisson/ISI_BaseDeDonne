﻿namespace Commercial.Presentation
{
    public partial class FListeCdes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListeCdes));
            this.lvcdes = new System.Windows.Forms.ListView();
            this.Numcheck = new System.Windows.Forms.CheckBox();
            this.NumVencheck = new System.Windows.Forms.CheckBox();
            this.NumClicheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Datecheck = new System.Windows.Forms.CheckBox();
            this.Facturecheck = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterUneCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeSélectionnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.détailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_no = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_vendeur = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_client = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_date = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_facture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_asc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_desc = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvcdes
            // 
            this.lvcdes.Location = new System.Drawing.Point(20, 103);
            this.lvcdes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvcdes.Name = "lvcdes";
            this.lvcdes.Size = new System.Drawing.Size(744, 406);
            this.lvcdes.TabIndex = 0;
            this.lvcdes.UseCompatibleStateImageBehavior = false;
            this.lvcdes.SelectedIndexChanged += new System.EventHandler(this.lvcdes_SelectedIndexChanged);
            // 
            // Numcheck
            // 
            this.Numcheck.AutoSize = true;
            this.Numcheck.Location = new System.Drawing.Point(87, 77);
            this.Numcheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Numcheck.Name = "Numcheck";
            this.Numcheck.Size = new System.Drawing.Size(91, 24);
            this.Numcheck.TabIndex = 2;
            this.Numcheck.Text = "Numéro";
            this.Numcheck.UseVisualStyleBackColor = true;
            this.Numcheck.CheckedChanged += new System.EventHandler(this.Numcheck_CheckedChanged);
            // 
            // NumVencheck
            // 
            this.NumVencheck.AutoSize = true;
            this.NumVencheck.Location = new System.Drawing.Point(190, 77);
            this.NumVencheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumVencheck.Name = "NumVencheck";
            this.NumVencheck.Size = new System.Drawing.Size(152, 24);
            this.NumVencheck.TabIndex = 3;
            this.NumVencheck.Text = "Numéro vendeur";
            this.NumVencheck.UseVisualStyleBackColor = true;
            this.NumVencheck.CheckedChanged += new System.EventHandler(this.NumVencheck_CheckedChanged);
            // 
            // NumClicheck
            // 
            this.NumClicheck.AutoSize = true;
            this.NumClicheck.Location = new System.Drawing.Point(357, 77);
            this.NumClicheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumClicheck.Name = "NumClicheck";
            this.NumClicheck.Size = new System.Drawing.Size(132, 24);
            this.NumClicheck.TabIndex = 4;
            this.NumClicheck.Text = "Numéro client";
            this.NumClicheck.UseVisualStyleBackColor = true;
            this.NumClicheck.CheckedChanged += new System.EventHandler(this.NumClicheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtres :";
            // 
            // Datecheck
            // 
            this.Datecheck.AutoSize = true;
            this.Datecheck.Location = new System.Drawing.Point(502, 77);
            this.Datecheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Datecheck.Name = "Datecheck";
            this.Datecheck.Size = new System.Drawing.Size(153, 24);
            this.Datecheck.TabIndex = 6;
            this.Datecheck.Text = "Date commande";
            this.Datecheck.UseVisualStyleBackColor = true;
            this.Datecheck.CheckedChanged += new System.EventHandler(this.Datecheck_CheckedChanged);
            // 
            // Facturecheck
            // 
            this.Facturecheck.AutoSize = true;
            this.Facturecheck.Location = new System.Drawing.Point(668, 77);
            this.Facturecheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Facturecheck.Name = "Facturecheck";
            this.Facturecheck.Size = new System.Drawing.Size(90, 24);
            this.Facturecheck.TabIndex = 7;
            this.Facturecheck.Text = "Facture";
            this.Facturecheck.UseVisualStyleBackColor = true;
            this.Facturecheck.CheckedChanged += new System.EventHandler(this.Facturecheck_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneCommandeToolStripMenuItem,
            this.commandeSélectionnéeToolStripMenuItem,
            this.triToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(782, 35);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterUneCommandeToolStripMenuItem
            // 
            this.ajouterUneCommandeToolStripMenuItem.Name = "ajouterUneCommandeToolStripMenuItem";
            this.ajouterUneCommandeToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.ajouterUneCommandeToolStripMenuItem.Text = "Nouvelle commande";
            this.ajouterUneCommandeToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneCommandeToolStripMenuItem_Click);
            // 
            // commandeSélectionnéeToolStripMenuItem
            // 
            this.commandeSélectionnéeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.détailsToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.commandeSélectionnéeToolStripMenuItem.Name = "commandeSélectionnéeToolStripMenuItem";
            this.commandeSélectionnéeToolStripMenuItem.Size = new System.Drawing.Size(219, 29);
            this.commandeSélectionnéeToolStripMenuItem.Text = "Commande sélectionnée";
            // 
            // détailsToolStripMenuItem
            // 
            this.détailsToolStripMenuItem.Name = "détailsToolStripMenuItem";
            this.détailsToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.détailsToolStripMenuItem.Text = "Détails";
            this.détailsToolStripMenuItem.Click += new System.EventHandler(this.détailsToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // triToolStripMenuItem
            // 
            this.triToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_tri,
            this.toolStripSeparator1,
            this.menu_asc,
            this.menu_desc});
            this.triToolStripMenuItem.Name = "triToolStripMenuItem";
            this.triToolStripMenuItem.Size = new System.Drawing.Size(41, 29);
            this.triToolStripMenuItem.Text = "Tri";
            // 
            // menu_tri
            // 
            this.menu_tri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_tri_no,
            this.menu_tri_vendeur,
            this.menu_tri_client,
            this.menu_tri_date,
            this.menu_tri_facture});
            this.menu_tri.Name = "menu_tri";
            this.menu_tri.Size = new System.Drawing.Size(211, 30);
            this.menu_tri.Text = "Champ";
            // 
            // menu_tri_no
            // 
            this.menu_tri_no.Name = "menu_tri_no";
            this.menu_tri_no.Size = new System.Drawing.Size(211, 30);
            this.menu_tri_no.Text = "Numéro";
            this.menu_tri_no.Click += new System.EventHandler(this.menu_tri_no_Click);
            // 
            // menu_tri_vendeur
            // 
            this.menu_tri_vendeur.Name = "menu_tri_vendeur";
            this.menu_tri_vendeur.Size = new System.Drawing.Size(211, 30);
            this.menu_tri_vendeur.Text = "Vendeur";
            this.menu_tri_vendeur.Click += new System.EventHandler(this.menu_tri_vendeur_Click);
            // 
            // menu_tri_client
            // 
            this.menu_tri_client.Name = "menu_tri_client";
            this.menu_tri_client.Size = new System.Drawing.Size(211, 30);
            this.menu_tri_client.Text = "Client";
            this.menu_tri_client.Click += new System.EventHandler(this.menu_tri_client_Click);
            // 
            // menu_tri_date
            // 
            this.menu_tri_date.Name = "menu_tri_date";
            this.menu_tri_date.Size = new System.Drawing.Size(211, 30);
            this.menu_tri_date.Text = "Date";
            this.menu_tri_date.Click += new System.EventHandler(this.menu_tri_date_Click);
            // 
            // menu_tri_facture
            // 
            this.menu_tri_facture.Name = "menu_tri_facture";
            this.menu_tri_facture.Size = new System.Drawing.Size(211, 30);
            this.menu_tri_facture.Text = "Facture";
            this.menu_tri_facture.Click += new System.EventHandler(this.menu_tri_facture_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // menu_asc
            // 
            this.menu_asc.Name = "menu_asc";
            this.menu_asc.Size = new System.Drawing.Size(211, 30);
            this.menu_asc.Text = "Croissant";
            this.menu_asc.Click += new System.EventHandler(this.menu_asc_Click);
            // 
            // menu_desc
            // 
            this.menu_desc.Name = "menu_desc";
            this.menu_desc.Size = new System.Drawing.Size(211, 30);
            this.menu_desc.Text = "Décroissant";
            this.menu_desc.Click += new System.EventHandler(this.menu_desc_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // FListeCdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 529);
            this.Controls.Add(this.Facturecheck);
            this.Controls.Add(this.Datecheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumClicheck);
            this.Controls.Add(this.NumVencheck);
            this.Controls.Add(this.Numcheck);
            this.Controls.Add(this.lvcdes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(794, 559);
            this.Name = "FListeCdes";
            this.Text = "Liste des commandes";
            this.Resize += new System.EventHandler(this.FListeCdes_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvcdes;
        private System.Windows.Forms.CheckBox Numcheck;
        private System.Windows.Forms.CheckBox NumVencheck;
        private System.Windows.Forms.CheckBox NumClicheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Datecheck;
        private System.Windows.Forms.CheckBox Facturecheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeSélectionnéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem détailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_tri;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_no;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_vendeur;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_client;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_date;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_facture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_asc;
        private System.Windows.Forms.ToolStripMenuItem menu_desc;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
    }
}