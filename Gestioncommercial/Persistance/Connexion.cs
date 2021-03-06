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
using MySql.Data.MySqlClient;
using System.Configuration;
using Utilitaires;

namespace Persistance
{
    public class Connexion
    {
        private static MySql.Data.MySqlClient.MySqlConnection macnx;
        private static Connexion instance;
        /// <summary>
        /// Constructeur privé
        /// </summary>
        private Connexion() { }
        /// <summary>
        /// Connexion à MySql
        /// </summary>
        /// <returns>MysqlConnexion</returns>
        public MySqlConnection getConnexion()
        {
            try
            {
                string bddCourante = ConfigurationManager.AppSettings["bddCourante"];
                string strConnexion = ConfigurationManager.AppSettings[bddCourante];
                macnx = new MySqlConnection(strConnexion);
                macnx.Open();
                return macnx;
            }
            catch (MySqlException err)
            {
                throw new MonException("", "Erreur d'acces à la base.", err.Message);
            }
        }

        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static Connexion getInstance()
        {
            if (Connexion.instance == null)
                Connexion.instance = new Connexion();
            return Connexion.instance;
        }

        /// <summary>
        /// Fermer la connexion si elle est ouverte
        /// </summary>
        public static void closeConnexion()
        {
            if(instance != null && macnx != null)
                macnx.Close();
        }

    }

}
