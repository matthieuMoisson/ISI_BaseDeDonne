﻿/*
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

namespace Commercial.Presentation
{
    public partial class FListeCdes : Form
    {
       

        /// <summary>
        /// Initialisation
        /// </summary>
        /// <param name="choix">Option pour l'initialisation : affichage d'un message ou ouverture d'une fenêtre d'ajout</param>
     

      

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
                commandeSélectionnéeToolStripMenuItem.Enabled = true;
                détailsToolStripMenuItem.Enabled = false;
                modifierToolStripMenuItem.Enabled = false;
                supprimerToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// Adapter la listeView à la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FListeCdes_Resize(object sender, EventArgs e)
        {
            lvcdes.Width = this.Width - 40;
            lvcdes.Height = this.Height - 120;
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
    }
}
