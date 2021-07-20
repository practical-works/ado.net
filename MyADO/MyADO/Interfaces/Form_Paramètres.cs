using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;
using MyADO.Données;

namespace MyADO.Interfaces
{
    public partial class Form_Paramètres : Form
    {
        public Form_Paramètres()
        {
            InitializeComponent();
        }

        private void Form_Paramètres_Load(object sender, EventArgs e)
        {
            string TexteParamètres = "";
            TexteParamètres = ConfigurationManager.GetSection("Paramètre").ToString();
            textBox1.Text = TexteParamètres;
        }
    }
}
