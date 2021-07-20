//TP: naviguer entre les données en mode connecté.
//Auteur: CHAOULID
//Copyright : Exelib.net
//****D'autres solutions sont possibles****
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        private SqlConnection cn = new SqlConnection("Data Source=MYPC; initial catalog=Clients; integrated security=true");
        

       

        private void actualiser()   //procédure qui permet de charger le contenu de la table client dans le Datagridview
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from client", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            dr.Close();
            cn.Close();
        }

        private int nombre_total() // fonction qui retourne le nombre de clients
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select count(cin) from client", cn);
            int c = int.Parse(cmd.ExecuteScalar().ToString());
            cn.Close();
            return c;
        }


        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            actualiser(); //charger le contenu de la table client dans le datagridwiew au démarrage du formulaire
            lbl_tot.Text = nombre_total().ToString(); //afficher le nombre total des clients au démarrage du formulaire puisque il n'y aura pas un changement de leur nombre aprés.
        }

        

        

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_premier_Click(object sender, EventArgs e)
        {
            int cpt = 0; //compteur qui détermine l'order du client dans la table
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from client", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) //pointer sur le prmier client s'il existe
            {
                txt_cin.Text = dr[0].ToString();
                txt_nom.Text = dr[1].ToString();
                txt_prenom.Text = dr[2].ToString();
                txt_ville.Text = dr[3].ToString();
                txt_tel.Text = dr[4].ToString();
                cpt++;
                lbl_num.Text = cpt.ToString();
                dataGridView1.ClearSelection();
                dataGridView1.Rows[cpt - 1].Selected = true; //sélectionner le client chargé dans le DATAGRIDVIEW
                
            }
            
            dr.Close();
            cn.Close();
        }

        private void btn_dernier_Click(object sender, EventArgs e)
        {
            int cpt = 0;
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from client", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) //parcourir les clients jusqu'à le dernier
            {
                txt_cin.Text = dr[0].ToString();
                txt_nom.Text = dr[1].ToString();
                txt_prenom.Text = dr[2].ToString();
                txt_ville.Text = dr[3].ToString();
                txt_tel.Text = dr[4].ToString();
                cpt++;
                lbl_num.Text = cpt.ToString();
                dataGridView1.ClearSelection();
                dataGridView1.Rows[cpt - 1].Selected = true;
            }
            
            dr.Close();
            cn.Close();

        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            int cpt = 0;
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from client", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) //parcourir la table
            {
                cpt++;
                if (dr[0].ToString() == txt_cin.Text) //trouver le client chargé
                {

                    if (dr.Read()) //pointer sur le client suivant
                    {

                        txt_cin.Text = dr[0].ToString();
                        txt_nom.Text = dr[1].ToString();
                        txt_prenom.Text = dr[2].ToString();
                        txt_ville.Text = dr[3].ToString();
                        txt_tel.Text = dr[4].ToString();
                        cpt++;
                        lbl_num.Text = cpt.ToString();
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[cpt - 1].Selected = true;
                    }
                    break;

                }
            }
            
            dr.Close();
            cn.Close();

        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            int cpt = 0;
            cn.Open();
            string c = txt_cin.Text; //parceque le CIN s'écrase au fur et à mesure du parcours
            SqlCommand cmd = new SqlCommand("select * from client", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) //parcourir la table
            {
                if (dr[0].ToString() != c) // écraser tous le clients différents du client chargé
                {
                    txt_cin.Text = dr[0].ToString();
                    txt_nom.Text = dr[1].ToString();
                    txt_prenom.Text = dr[2].ToString();
                    txt_ville.Text = dr[3].ToString();
                    txt_tel.Text = dr[4].ToString();
                    cpt++;
                    lbl_num.Text = cpt.ToString();
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[cpt - 1].Selected = true;
                }
                else
                    break; //arreter le parcours donc les zones de texte restent contenir les infos du client précédent du client déja chargé.
                
                
                
            }
            
            dr.Close();
            cn.Close();
        }

        
    }
}
//Source : www.exelib.net