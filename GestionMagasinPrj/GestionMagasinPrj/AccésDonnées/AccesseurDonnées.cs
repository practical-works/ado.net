using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GestionMagasinPrj.AccésDonnées
{
    class AccesseurDonnées
    {
        private SqlConnection CONNEXION;
        private string TEXTE_COMMANDE;
        private SqlDataAdapter ADAPTEUR;
        private SqlCommandBuilder GENERATEUR_COMMANDES;
        public DataSet SET_DONNEES;      

        public AccesseurDonnées()
        {
            CONNEXION = new SqlConnection(Program.CHAINE_CONNEXION);
            ADAPTEUR = new SqlDataAdapter("", CONNEXION);
            GENERATEUR_COMMANDES = new SqlCommandBuilder(ADAPTEUR);
            SET_DONNEES = new DataSet();
        }

        public DataTable Charger(string TexteCommande, string NomTable)
        {
            TEXTE_COMMANDE = TexteCommande;
            ADAPTEUR.SelectCommand.CommandText = TexteCommande;
            ADAPTEUR.Fill(SET_DONNEES, NomTable);
            return SET_DONNEES.Tables[NomTable];
        }

        public int Enregistrer(string NomTable)
        {
            int NombreLignesAffectées = ADAPTEUR.Update(SET_DONNEES, NomTable);
            return NombreLignesAffectées;
        }
    }
}
