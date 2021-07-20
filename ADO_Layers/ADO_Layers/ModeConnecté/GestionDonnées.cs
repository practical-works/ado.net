using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Layers.ModeConnecté
{
    class GestionDonnées // Mode Connecté
    {
        private AccésDonnées ACCES_DONNEES;
        private string NOM_TABLE;

        public GestionDonnées(string NomTable)
        {
            ACCES_DONNEES = new AccésDonnées();
            NOM_TABLE = NomTable;
        }

        public DataTable Obtenir()
        {
            return new DataTable();
        }
        public DataTable Filtrer()
        {
            return new DataTable();
        }
        public DataTable Trier()
        {
            return new DataTable();
        }

        public int Ajouter()
        {
            return 0;
        }
        public int Modifier()
        {
            return 0;
        }
        public int Supprimer()
        {
            return 0;
        }
    }
}
