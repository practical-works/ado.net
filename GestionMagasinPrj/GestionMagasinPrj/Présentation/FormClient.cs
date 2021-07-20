using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionMagasinPrj.Business;
using System.IO;

namespace GestionMagasinPrj.Présentation
{
    public partial class FormClient : Form
    {
        Client CLIENT = new Client();

        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CLIENT.Sélectionner();
        }

        private void pic_Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ExplorateurFichiers = new OpenFileDialog();
            ExplorateurFichiers.Filter = "Fichiers images|*.bmp;*.jpg;*.jpeg;*.png;";
            if (ExplorateurFichiers.ShowDialog() == DialogResult.OK)
            {
                pic_Photo.Image = Image.FromFile(ExplorateurFichiers.FileName);
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            object[] Champs = new object[6];
            // Le Champs[0] de l'ID est en auto-incrément
            Champs[1] = txt_Nom.Text;
            Champs[2] = txt_Prénom.Text;
            Champs[3] = mtxt_Téléphone.Text;
            Champs[4] = mtxt_Email.Text;
            MemoryStream FluxMémoire = new MemoryStream();
            pic_Photo.Image.Save(FluxMémoire, pic_Photo.Image.RawFormat);
            byte[] PhotoEnOctects = FluxMémoire.ToArray();
            Champs[5] = PhotoEnOctects;
            CLIENT.Ajouter(Champs);
            CLIENT.Enregistrer();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_Recherche_TextChanged(object sender, EventArgs e)
        {
            CLIENT.Rechercher(txt_Recherche.Text);
        }
    }
}
