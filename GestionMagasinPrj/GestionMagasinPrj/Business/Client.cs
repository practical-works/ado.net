using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionMagasinPrj.AccésDonnées;
using System.Data;
using System.Data.SqlClient;

namespace GestionMagasinPrj.Business
{
    class Client
    {
        private AccesseurDonnées ACCESSEUR_DONNEES;
        public string NOM_TABLE;

        public Client()
        {
            ACCESSEUR_DONNEES = new AccesseurDonnées();
            NOM_TABLE = "Client";
        }

        public DataTable Sélectionner()
        {
            return ACCESSEUR_DONNEES.Charger("select * from " + NOM_TABLE, NOM_TABLE);
        }

        public DataView Rechercher(string Critère)
        {
            DataView Résultat = new DataView(ACCESSEUR_DONNEES.SET_DONNEES.Tables[NOM_TABLE]);
            Résultat.RowFilter = @"ID_Client+Nom_Client+Prenom_Client+Telephone_Client+Email_Client
                                  like '%" + Critère + "%'";
            return Résultat;
        }

        public void Ajouter(object[] Champs)
        {
            ACCESSEUR_DONNEES.SET_DONNEES.Tables[NOM_TABLE].Rows.Add(Champs);
        }

        public void Modifier(object[] Champs, int Index)
        {
            DataRow Ligne = ACCESSEUR_DONNEES.SET_DONNEES.Tables[NOM_TABLE].Rows[Index];
            Ligne["Nom_Client"] = Champs[1];
            Ligne["Prenom_Client"] = Champs[2];
            Ligne["Telephone_Client"] = Champs[3];
            Ligne["Email_Client"] = Champs[4];
            Ligne["Photo_Client"] = Champs[5];
        }

        public void Supprimer(object[] Champs, int Index)
        {
            ACCESSEUR_DONNEES.SET_DONNEES.Tables[NOM_TABLE].Rows[Index].Delete();
        }

        public void Enregistrer()
        {
            ACCESSEUR_DONNEES.Enregistrer(NOM_TABLE);
        }
    }
}
