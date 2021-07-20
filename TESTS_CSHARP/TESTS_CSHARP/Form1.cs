using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TESTS_CSHARP
{
    public partial class Form1 : Form
    {
        private SqlConnection Connexion;
        private SqlDataAdapter Adapteur;
        private DataTable Table;

        public Form1()
        {
            InitializeComponent();

            Connexion = new SqlConnection(@"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;Initial Catalog=ClientsDb;Integrated Security=True");
            Adapteur = new SqlDataAdapter("select * from Client", Connexion);
            Table = new DataTable();
            
            Adapteur.Fill(Table);

            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox1.DataSource = Table;
            comboBox1.DisplayMember = "Nom";
        }
    }
}
