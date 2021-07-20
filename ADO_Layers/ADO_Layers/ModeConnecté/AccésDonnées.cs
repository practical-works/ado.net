using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Layers.ModeConnecté
{
    class AccésDonnées // Mode Connecté
    {
        private SqlConnection CONNEXION;
        private SqlCommand COMMANDE;
        private SqlDataAdapter ADAPTEUR;

        public AccésDonnées()
        {
            CONNEXION = new SqlConnection(Configuration.CHAINE_CONNEXION);
            COMMANDE = new SqlCommand("", CONNEXION);
            ADAPTEUR = new SqlDataAdapter(COMMANDE);
        }

        public void Connecter()
        {
            if (CONNEXION.State != ConnectionState.Open) CONNEXION.Open();
        }
        public void Déconnecter()
        {
            if (CONNEXION.State != ConnectionState.Closed) CONNEXION.Close();
        }

        public DataTable Recevoir(string TexteCommande)
        {
            COMMANDE.CommandText = TexteCommande;
            DataTable Table = new DataTable();
            ADAPTEUR.Fill(Table);
            return Table;
        }
        public int Envoyer(string TexteCommande)
        {
            COMMANDE.CommandText = TexteCommande;
            Connecter();
            int NombreLignesAffectées = COMMANDE.ExecuteNonQuery();
            Déconnecter();
            return NombreLignesAffectées;
        }
    }
}
