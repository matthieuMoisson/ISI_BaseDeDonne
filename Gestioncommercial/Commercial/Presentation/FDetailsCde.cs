/*
 * THIBAULT LAZERT P1003011
 * UE ISI Polytech'Lyon
 * semestre automne 2012
 * 
 * Application gestion commerciale
 */
using System.Collections;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Metier;
using Utilitaires;
using System.Globalization;

namespace Commercial.Presentation
{
    public partial class FDetailsCde : Form
    {

        string numCommande;

        /// <summary>
        /// Initialisation
        /// </summary>
        public FDetailsCde()
        {
            InitializeComponent();

        }

        public FDetailsCde(string numCommande)
        {

            InitializeComponent();

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            lvart.Items.Clear();
            lvart.View = View.Details;
            lvart.Columns.Add("Numéro", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Libellé", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Ville", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Prix Unité", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Qté", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Prix totale", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Livré", 100, HorizontalAlignment.Left);
            this.numCommande = numCommande;
            AfficherListe();
        }

        private void AfficherListe()
        {
            float s = 0;
            DetailsCde unDetail = new DetailsCde();
            List<DetailsCde> mesDetails;
            string numero, libelle, ville, prixUnitaire, qte, prixTotal, livre;
            ListViewItem lvitem_cde;
            try
            {
                mesDetails = unDetail.getDetailsCde(numCommande);

                foreach (DetailsCde d in mesDetails)
                {
                    numero = d.Art.No_article;
                    libelle = d.Art.Lib_article;
                    ville = d.Art.Ville_art;
                    prixUnitaire = d.Art.Prix_art;
                    qte = d.Qte_cdee;
                    prixTotal = d.Total;
                    livre = d.Livree;
                    lvitem_cde = new ListViewItem(new string[] { numero, libelle, ville, prixUnitaire, qte, prixTotal, livre }, -1, Color.Black, Color.LightGray, null);
                    lvart.Items.Add(lvitem_cde);
                    s=s + float.Parse(prixTotal);
                }
                this.HT.Text += " " + s;
                s = s * ((float)12/10) ;
                this.TTC.Text += " " + s;
                lvart.FullRowSelect = true;
                lvart.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (MonException erreur)
            {
                MessageBox.Show(erreur.MessageSysteme(), "Erreur de modification");
            }
        }

    }
}
