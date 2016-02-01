/*
 * THIBAULT LAZERT P1003011
 * UE ISI Polytech'Lyon
 * semestre automne 2012
 * 
 * Application gestion commerciale
 */
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
    public partial class FListeCdes : Form
    {

        private string trieur;
        private string organise;
        /// <summary>
        /// Initialisation
        /// </summary>
        /// <param name="choix">Option pour l'initialisation : affichage d'un message ou ouverture d'une fenêtre d'ajout</param>
        public FListeCdes()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            // Affiche l'entête du tableau
            trieur = "NO_COMMAND";
            organise = "ASC";
            menu_asc.Checked = true;
            menu_tri_no.Checked = true;
            Numcheck.Checked = true;
            NumVencheck.Checked = true;
            NumClicheck.Checked = true;
            Datecheck.Checked = true;
            Facturecheck.Checked = true;
            TestAccesMenu();
            AfficherListe();
        }



        // tester l'activation des menus en fonction de la sélection
        private void lvcdes_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestAccesMenu();
        }

        /// <summary>
        /// Tester l'accès au menus en fonction de la sélection
        /// </summary>
        private void TestAccesMenu()
        {
            if (lvcdes.SelectedIndices.Count == 1) // une ligne sélectionnée
            {
                commandeSélectionnéeToolStripMenuItem.Text = "Commande sélectionnée";
                commandeSélectionnéeToolStripMenuItem.Enabled = true;
                détailsToolStripMenuItem.Enabled = true;
                modifierToolStripMenuItem.Enabled = true;
                supprimerToolStripMenuItem.Enabled = true;
            }
            else if (lvcdes.SelectedIndices.Count == 0) // aucune ligne sélectionnée
            {
                commandeSélectionnéeToolStripMenuItem.Text = "Commande sélectionnée";
                commandeSélectionnéeToolStripMenuItem.Enabled = false;
            }
            else // plusieurs lignes sélectionnées
            {
                commandeSélectionnéeToolStripMenuItem.Text = "Commandes sélectionnées";
                commandeSélectionnéeToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Adapter la listeView à la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FListeCdes_Resize(object sender, EventArgs e)
        {
            lvcdes.Width = this.Width+100;
            lvcdes.Height = this.Height;
            lvcdes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

       

        /// <summary>
        /// Lien du menu pour ajouter une commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Affiche la liste des commandes
        /// </summary>
        private void AfficherListe()
        {
            lvcdes.Columns.Clear();
            lvcdes.Items.Clear();
            lvcdes.View = View.Details;
            lvcdes.Columns.Add("1", "Numero", 100, HorizontalAlignment.Left, 0);
            lvcdes.Columns.Add("2", "Numéro Vendeur", 100, HorizontalAlignment.Left, 0);
            lvcdes.Columns.Add("3", "Numéro Client", 100, HorizontalAlignment.Left, 0);
            lvcdes.Columns.Add("4", "Date Commande", 100, HorizontalAlignment.Left, 0);
            lvcdes.Columns.Add("5", "Facture", 100, HorizontalAlignment.Left, 0);

            Commande unecommande = new Commande();
            List<Commande> mesCommandes;
            string numCde, numVend, NumCli, facture, datecde;
            ListViewItem lvitem_cde;

            try
            {
                mesCommandes = unecommande.getLesCommandes(this.trieur, this.organise);

                foreach (Commande c in mesCommandes)
                {

                    numCde = c.NoCommande;
                    // On récupère la property NoVendeur
                    numVend = c.Vendeur.NoVendeur;
                    NumCli = c.Client.NoCl;
                    datecde = c.DateCommande.ToShortDateString();
                    facture = c.Facture;
                    lvitem_cde = new ListViewItem(new string[] { numCde, numVend, NumCli, datecde, facture }, -1, Color.Black, Color.LightGray, null);
                    lvcdes.Items.Add(lvitem_cde);
                }

                if (!Numcheck.Checked) lvcdes.Columns.RemoveByKey("1");
                if (!NumVencheck.Checked) lvcdes.Columns.RemoveByKey("2");
                if (!NumClicheck.Checked) lvcdes.Columns.RemoveByKey("3");
                if (!Datecheck.Checked) lvcdes.Columns.RemoveByKey("4");
                if (!Facturecheck.Checked) lvcdes.Columns.RemoveByKey("5");
                lvcdes.FullRowSelect = true;
                lvcdes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        private void ajouterUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commande cmd = new Commande();
            FajouteCdes newCmd = new FajouteCdes(cmd, true);
            DialogResult res = newCmd.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    cmd.ajouterCommande();
                    MessageBox.Show("Commande ajouté avec succès.");
                    AfficherListe();
                }
                catch (MonException excep)
                {
                    MessageBox.Show(excep.MessageSysteme(), "Erreur d'ajout");
                }
            }
        }


        private void détailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String no_cmd = lvcdes.FocusedItem.Text;
            FDetailsCde dt = new FDetailsCde(no_cmd);
            DialogResult res = dt.ShowDialog();
        }

        private void Facturecheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
            if (Facturecheck.Checked)
                menu_tri_facture.Enabled = true;
            else
                menu_tri_facture.Enabled = false;
        }

        private void Datecheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
            if (Datecheck.Checked)
                menu_tri_date.Enabled = true;
            else
                menu_tri_date.Enabled = false;
        }

        private void NumClicheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
            if (NumClicheck.Checked)
                menu_tri_client.Enabled = true;
            else
                menu_tri_client.Enabled = false;
        }

        private void NumVencheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
            if (NumVencheck.Checked)
                menu_tri_vendeur.Enabled = true;
            else
                menu_tri_vendeur.Enabled = false;
        }

        private void Numcheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
            if (Numcheck.Checked)
                menu_tri_no.Enabled = true;
            else
                menu_tri_no.Enabled = false;
        }

        private void menu_asc_Click(object sender, EventArgs e)
        {
            menu_asc.Checked = true;
            menu_desc.Checked = false;
            organise = "ASC";
            this.AfficherListe();
        }

        private void menu_desc_Click(object sender, EventArgs e)
        {
            menu_asc.Checked = false;
            menu_desc.Checked = true;
            organise = "DESC";
            this.AfficherListe();
        }

        private void menu_tri_no_Click(object sender, EventArgs e)
        {
            menu_tri_no.Checked = true;
            menu_tri_vendeur.Checked = false;
            menu_tri_client.Checked = false;
            menu_tri_date.Checked = false;
            menu_tri_facture.Checked = false;
            trieur = "NO_COMMAND";
            this.AfficherListe();
        }

        private void menu_tri_vendeur_Click(object sender, EventArgs e)
        {
            menu_tri_no.Checked = false;
            menu_tri_vendeur.Checked = true;
            menu_tri_client.Checked = false;
            menu_tri_date.Checked = false;
            menu_tri_facture.Checked = false;
            trieur = "NO_VENDEUR";
            this.AfficherListe();
        }

        private void menu_tri_client_Click(object sender, EventArgs e)
        {
            menu_tri_no.Checked = false;
            menu_tri_vendeur.Checked = false;
            menu_tri_client.Checked = true;
            menu_tri_date.Checked = false;
            menu_tri_facture.Checked = false;
            trieur = "NO_CLIENT";
            this.AfficherListe();
        }

        private void menu_tri_date_Click(object sender, EventArgs e)
        {
            menu_tri_no.Checked = false;
            menu_tri_vendeur.Checked = false;
            menu_tri_client.Checked = false;
            menu_tri_date.Checked = true;
            menu_tri_facture.Checked = false;
            trieur = "DATE_CDE";
            this.AfficherListe();
        }

        private void menu_tri_facture_Click(object sender, EventArgs e)
        {
            menu_tri_no.Checked = false;
            menu_tri_vendeur.Checked = false;
            menu_tri_client.Checked = false;
            menu_tri_date.Checked = false;
            menu_tri_facture.Checked = true;
            trieur = "FACTURE";
            this.AfficherListe();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int suprCmd;
            if (lvcdes.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Veuillez Selction au moin une commande", "erreur");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Confirmation avant supression", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    Commande cmd = new Commande();
                    suprCmd = Convert.ToInt32(lvcdes.FocusedItem.Text);
                    try
                    {
                        cmd.supprimerCommande(suprCmd);
                        AfficherListe();
                    }
                    catch (MonException excep)
                    {
                        MessageBox.Show(excep.MessageSysteme(), "Erreur de modification");
                    }
                }
                
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commande uneCommande = new Commande();
            Commande maCommande = uneCommande;
            List<Commande> mesCommandes;
            mesCommandes = uneCommande.getLesCommandes(this.trieur, this.organise);
            String numero = lvcdes.Items[lvcdes.SelectedIndices[0]].Text;
            foreach (Commande c in mesCommandes)
            {
                if (numero == c.NoCommande)
                {
                    maCommande = c;
                }
            }
            //Si on ne trouve pas de commande équivalent a l'ajouter d'une commande
            FajouteCdes newCmd = new FajouteCdes(maCommande, false);
            DialogResult res = newCmd.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    maCommande.ajouterCommande();
                    MessageBox.Show("Succès de l'oppération.");
                    AfficherListe();
                }
                catch (MonException excep)
                {
                    MessageBox.Show(excep.MessageSysteme(), "Erreur d'ajout");
                }
            }
            
        }
        
    }
}
