using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ADO_DataBindings_Code
{
    public partial class Form_main : Form
    {
        public GestionClients GESTION_CLIENTS;
        public BindingSource SOURCE_LIAISON;

        public Form_main()
        {
            InitializeComponent();

            // Initialiser les attributs et composants
            GESTION_CLIENTS = new GestionClients();
            SOURCE_LIAISON = new BindingSource();
            SOURCE_LIAISON.DataSource = GESTION_CLIENTS.Table;
            
            // Lier les contrôles
            dataGridView_clients.DataSource = SOURCE_LIAISON;
            numericUpDown_id.DataBindings.Add("Value", SOURCE_LIAISON, "id");
            textBox_nom.DataBindings.Add("Text", SOURCE_LIAISON, "nom");
            pictureBox_photo.DataBindings.Add("Image", SOURCE_LIAISON, "photo", true);
            AfficherPosition();

            // Ajouter les colonnes spéciaux
            AjouterColonne();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            // ...
        }

        #region Recherche et Tri
        private void textBox_rechercher_TextChanged(object sender, EventArgs e)
        {
            if (textBox_rechercher.Text.Trim() == "")
            {
                SOURCE_LIAISON.DataSource = GESTION_CLIENTS.Table;
                GESTION_CLIENTS.Filtrer("");
            }
            else
            {
                SOURCE_LIAISON.DataSource = GESTION_CLIENTS.Filtrer(textBox_rechercher.Text.Trim());
            }
        }
        private void comboBox_trier_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool Croissant = true;
            if (checkBox_decroissant.Checked) Croissant = false;
            if (comboBox_trier.SelectedIndex == 0 || comboBox_trier.SelectedIndex == -1)
            {
                SOURCE_LIAISON.DataSource = GESTION_CLIENTS.Trier(Croissant, "");
            }
            if (comboBox_trier.SelectedIndex == 1)
	        {
                SOURCE_LIAISON.DataSource = GESTION_CLIENTS.Trier(Croissant, "id");
	        }
            if (comboBox_trier.SelectedIndex == 2)
	        {
                SOURCE_LIAISON.DataSource = GESTION_CLIENTS.Trier(Croissant, "nom");
	        }  
        }
        private void checkBox_decroissant_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_trier_SelectedIndexChanged(sender, e);
        }
        #endregion

        #region Mise à jour
        private void button_nouveau_Click(object sender, EventArgs e)
        {
            numericUpDown_id.Value = 0;
            textBox_nom.Clear();
            pictureBox_photo.Image = null;
            numericUpDown_id.Focus();
            //SOURCE_LIAISON.AddNew();
        }
        private void pictureBox_photo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Explorateur = new OpenFileDialog();
                Explorateur.Filter = "Fichiers Image | *.jpg; *.jpeg; *.png; *.bmp; *.gif; | Tous les fichiers | *.*";
                Explorateur.AddExtension = true;
                if (Explorateur.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_photo.Image = Image.FromFile(Explorateur.FileName);
                }
            }
            catch (Exception EXCEPTION)
            {
                MessageBox.Show(EXCEPTION.Message);
            }
        }
        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (pictureBox_photo.Image == null)
            {
                if (!GESTION_CLIENTS.Ajouter(numericUpDown_id.Value, textBox_nom.Text, null))
                {
                    MessageBox.Show("Existe déjà!");
                }
            }
            else
            {
                MemoryStream FluxMemoire = new MemoryStream();
                pictureBox_photo.Image.Save(FluxMemoire, pictureBox_photo.Image.RawFormat);
                byte[] PhotoOctets = FluxMemoire.ToArray();
                if (!GESTION_CLIENTS.Ajouter(numericUpDown_id.Value, textBox_nom.Text, PhotoOctets))
                {
                    MessageBox.Show("Existe déjà!");
                }
            }       
            GESTION_CLIENTS.Enregistrer();
        }
        private void button_modifier_Click(object sender, EventArgs e)
        {
            SOURCE_LIAISON.EndEdit();
            if (pictureBox_photo.Image == null)
            {
                if (!GESTION_CLIENTS.Modifier(numericUpDown_id.Value, textBox_nom.Text, null))
                {
                    MessageBox.Show("N'existe pas!");
                }
            }
            else
            {
                MemoryStream FluxMemoire = new MemoryStream();
                pictureBox_photo.Image.Save(FluxMemoire, pictureBox_photo.Image.RawFormat);
                byte[] PhotoOctets = FluxMemoire.ToArray();
                if (!GESTION_CLIENTS.Modifier(numericUpDown_id.Value, textBox_nom.Text, PhotoOctets))
                {
                    MessageBox.Show("N'existe pas!");
                }
            }
            GESTION_CLIENTS.Enregistrer();
        }
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            if (!GESTION_CLIENTS.Supprimer(numericUpDown_id.Value))
            {
                MessageBox.Show("N'existe pas!");
            }
        }
        private void button_extra_Click(object sender, EventArgs e)
        {
            SOURCE_LIAISON.EndEdit();
            GESTION_CLIENTS.Enregistrer();
        }
        #endregion
       
        #region Navigation
        private void AfficherPosition()
        {
            groupBox_navigation.Text = string.Format("Navigation ({0}/{1})", SOURCE_LIAISON.Position + 1, SOURCE_LIAISON.Count);
        }
        private void button_premier_Click(object sender, EventArgs e)
        {
            SOURCE_LIAISON.MoveFirst();
            AfficherPosition();
        }        
        private void button_precedent_Click(object sender, EventArgs e)
        {
            SOURCE_LIAISON.MovePrevious();
            AfficherPosition();
        }
        private void button_suivant_Click(object sender, EventArgs e)
        {
            SOURCE_LIAISON.MoveNext();
            AfficherPosition();
        }
        private void button_dernier_Click(object sender, EventArgs e)
        {
            SOURCE_LIAISON.MoveLast();
            AfficherPosition();
        }
        #endregion

        #region Opérations Avec Colonnes Spéciaux
        private void button_suppr_select_Click(object sender, EventArgs e)
        {
            DataGridViewRow Ligne = new DataGridViewRow();
            for (int i = 0; i < dataGridView_clients.Rows.Count; i++)
            {
                Ligne = dataGridView_clients.Rows[i];
                if (Convert.ToBoolean(Ligne.Cells[0].Value))
                {
                    //dataGridView_clients.Rows.Remove(Ligne);
                    //GESTION_CLIENTS.Supprimer(Ligne.Cells[0].Value);
                    SOURCE_LIAISON.RemoveAt(i);
                    i--;
                }
            }  
        }
        private void dataGridView_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
            if (dataGridView_clients.CurrentCell.OwningColumn.Name == "ColonneSelection")
            {
                bool ValeurColonne = Convert.ToBoolean(dataGridView_clients.CurrentCell.Value);
                if (ValeurColonne)
                {
                    dataGridView_clients.CurrentRow.DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                {
                    dataGridView_clients.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
        private void AjouterColonne()
        {
            DataGridViewCheckBoxColumn ColonneSelectionner = new DataGridViewCheckBoxColumn();
            ColonneSelectionner.Name = "ColonneSelection";
            ColonneSelectionner.HeaderText = "Sélectionner";
            dataGridView_clients.Columns.Add(ColonneSelectionner);
        }
        #endregion

        private void dataGridView_clients_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string txt = dataGridView_clients.EditingControl.Text;
            MessageBox.Show(e.Exception.Message + "\n" + txt);
        }

        private void button_tous_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Ligne in dataGridView_clients.Rows)
            {
                Ligne.Cells["ColonneSelection"].Value = true;
            }
        }
    }
}
