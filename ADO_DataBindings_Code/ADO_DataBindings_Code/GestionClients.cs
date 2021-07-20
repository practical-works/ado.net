using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADO_DataBindings_Code
{
    public class GestionClients
    {
        private DataAccessLayer ACCES_DONNEES;
        private string NOM_TABLE;
        private DataTable TABLE;
        private DataView VIEW;

        public DataTable Table
        {
            get { return TABLE; }
        }       

        public GestionClients()
        {
            ACCES_DONNEES = new DataAccessLayer();
            NOM_TABLE = "Client";          
            ACCES_DONNEES.Charger("select * from " + NOM_TABLE, NOM_TABLE);
            TABLE = ACCES_DONNEES.Obtenir(NOM_TABLE);
            DataColumn[] PK = { TABLE.Columns["id"] };
            TABLE.PrimaryKey = PK;
            VIEW = new DataView(TABLE);
        }

        //public int Rechercher(int ID_Client)
        //{
        //    foreach (DataRow Ligne in TABLE.Rows)
        //    {
        //        if (ID_Client == (int)Ligne["id"])
        //        {
        //            return TABLE.Rows.IndexOf(Ligne);
        //        }
        //    }
        //    return -1;
        //}

        public DataView Trier(bool Croissant, string NomChamps)
        {
            string Mode = "ASC";
            if (!Croissant) Mode = "DESC";
            if (NomChamps == "") VIEW.Sort = "";
            else VIEW.Sort = NomChamps + " " + Mode;
            return VIEW;
        }

        public DataView Filtrer(string MotsCles)
        {
            VIEW.RowFilter = "id+nom like '%" + MotsCles + "%'";
            return VIEW;
        }

        public bool Ajouter(params object[] Champs)
        {
            DataRow LigneAjouter = TABLE.Rows.Find(Champs[0]);
            if (LigneAjouter == null)
            {
                TABLE.Rows.Add(Champs);
                return true;
            }  
            return false;
        }

        public bool Modifier(params object[] Champs)
        {
            DataRow LigneAModifier = TABLE.Rows.Find(Champs[0]);
            if (LigneAModifier != null)
            {
                LigneAModifier["nom"] = Champs[1];
                LigneAModifier["photo"] = Champs[2];
                return true;
            }
            return false;
        }

        public bool Supprimer(object ID)
        {
            DataRow LigneASupprimer = TABLE.Rows.Find(ID);
            if (LigneASupprimer != null)
            {
                LigneASupprimer.Delete();
                return true;
            }
            return false;
        }

        public void Enregistrer()
        {
            ACCES_DONNEES.Enregistrer(TABLE.TableName);
        }
    }
}
