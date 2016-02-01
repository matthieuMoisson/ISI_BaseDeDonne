﻿/*
 * THIBAULT LAZERT P1003011
 * UE ISI Polytech'Lyon
 * semestre automne 2012
 * 
 * Application gestion commerciale
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Utilitaires;
using Persistance;


namespace Metier
{
    public class Commande
    {
        private Clientel client;
        private String noCommande;
        private DateTime dateCommande;
        private String facture;
        private Vendeur vendeur;


        public String NoCommande
        {
            get { return noCommande; }
            set { noCommande = value; }
        }
        public Vendeur Vendeur
        {
            get { return vendeur; }
            set { vendeur = value; }
        }
        public Clientel Client
        {
            get { return client; }
            set { client = value; }
        }
        public DateTime DateCommande
        {
            get { return dateCommande; }
            set { dateCommande = value; }
        }
        public String Facture
        {
            get { return facture; }
            set { facture = value; }
        }

        /// <summary>
        /// Initialisation
        /// </summary>
        public Commande()
        {
            noCommande = "";
            facture = "";
            vendeur = new Vendeur();
            client = new Clientel();
            dateCommande = DateTime.Today;
        }

        /// <summary>
        /// Initialisation avec les paramètres
        /// </summary>
        public Commande(String noC, DateTime dateC, String factC, Vendeur ven, Clientel cli)
        {
            noCommande = noC;
            dateCommande = dateC;
            facture = factC;
            vendeur = ven;
            client = cli;
        }

       
        
    }
}
