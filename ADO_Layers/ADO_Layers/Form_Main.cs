using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADO_Layers.ModeDéconnecté; // Mode Déconnecté

namespace ADO_Layers
{
    public partial class Form_Main : Form
    {
        private GestionDonnées GESTION_CLIENTS;
        private GestionDonnées GESTION_PRODUITS;
        private GestionDonnées GESTION_COMMANDES;
        private GestionDonnées GESTION_JOINTURE;

        public Form_Main()
        {
            InitializeComponent();
            
            GESTION_CLIENTS = new GestionDonnées(Configuration.INFOS_TABLES.Client);
            GESTION_PRODUITS = new GestionDonnées(Configuration.INFOS_TABLES.Produit);
            GESTION_COMMANDES = new GestionDonnées(Configuration.INFOS_TABLES.Commande);
            GESTION_JOINTURE = new GestionDonnées(Configuration.INFOS_TABLES.CommandeClientProduit);
            
            dataGridView_clients.DataSource = GESTION_JOINTURE.Table;
        }
    }
}
