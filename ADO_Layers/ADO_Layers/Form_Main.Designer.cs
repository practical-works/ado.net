namespace ADO_Layers
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_decroissant = new System.Windows.Forms.CheckBox();
            this.button_dernier = new System.Windows.Forms.Button();
            this.comboBox_trier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_rechercher = new System.Windows.Forms.TextBox();
            this.button_premier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button_suivant = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_precedent = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.groupBox_mise_a_jour = new System.Windows.Forms.GroupBox();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.groupBox_navigation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_groupBox_formulaire = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_grille = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox_mise_a_jour.SuspendLayout();
            this.groupBox_navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            this.groupBox_groupBox_formulaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.groupBox_grille.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_decroissant
            // 
            this.checkBox_decroissant.AutoSize = true;
            this.checkBox_decroissant.Location = new System.Drawing.Point(478, 23);
            this.checkBox_decroissant.Name = "checkBox_decroissant";
            this.checkBox_decroissant.Size = new System.Drawing.Size(82, 17);
            this.checkBox_decroissant.TabIndex = 22;
            this.checkBox_decroissant.Text = "Décroissant";
            this.checkBox_decroissant.UseVisualStyleBackColor = true;
            // 
            // button_dernier
            // 
            this.button_dernier.Location = new System.Drawing.Point(178, 14);
            this.button_dernier.Name = "button_dernier";
            this.button_dernier.Size = new System.Drawing.Size(44, 32);
            this.button_dernier.TabIndex = 22;
            this.button_dernier.Text = ">>";
            this.button_dernier.UseVisualStyleBackColor = true;
            // 
            // comboBox_trier
            // 
            this.comboBox_trier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_trier.FormattingEnabled = true;
            this.comboBox_trier.Items.AddRange(new object[] {
            "(Aucun)",
            "ID",
            "Nom"});
            this.comboBox_trier.Location = new System.Drawing.Point(359, 19);
            this.comboBox_trier.Name = "comboBox_trier";
            this.comboBox_trier.Size = new System.Drawing.Size(113, 21);
            this.comboBox_trier.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Trier :";
            // 
            // textBox_rechercher
            // 
            this.textBox_rechercher.Location = new System.Drawing.Point(83, 19);
            this.textBox_rechercher.Name = "textBox_rechercher";
            this.textBox_rechercher.Size = new System.Drawing.Size(206, 20);
            this.textBox_rechercher.TabIndex = 16;
            // 
            // button_premier
            // 
            this.button_premier.Location = new System.Drawing.Point(28, 14);
            this.button_premier.Name = "button_premier";
            this.button_premier.Size = new System.Drawing.Size(44, 32);
            this.button_premier.TabIndex = 23;
            this.button_premier.Text = "<<";
            this.button_premier.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 50);
            this.panel1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "Clients [DS]";
            // 
            // button_suivant
            // 
            this.button_suivant.Location = new System.Drawing.Point(128, 14);
            this.button_suivant.Name = "button_suivant";
            this.button_suivant.Size = new System.Drawing.Size(44, 32);
            this.button_suivant.TabIndex = 21;
            this.button_suivant.Text = ">";
            this.button_suivant.UseVisualStyleBackColor = true;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(173, 13);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(95, 23);
            this.button_ajouter.TabIndex = 10;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(301, 13);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(95, 23);
            this.button_modifier.TabIndex = 10;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            // 
            // button_precedent
            // 
            this.button_precedent.Location = new System.Drawing.Point(78, 14);
            this.button_precedent.Name = "button_precedent";
            this.button_precedent.Size = new System.Drawing.Size(44, 32);
            this.button_precedent.TabIndex = 24;
            this.button_precedent.Text = "<";
            this.button_precedent.UseVisualStyleBackColor = true;
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(429, 13);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(95, 23);
            this.button_supprimer.TabIndex = 10;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            // 
            // groupBox_mise_a_jour
            // 
            this.groupBox_mise_a_jour.Controls.Add(this.button_ajouter);
            this.groupBox_mise_a_jour.Controls.Add(this.button_modifier);
            this.groupBox_mise_a_jour.Controls.Add(this.button_supprimer);
            this.groupBox_mise_a_jour.Controls.Add(this.button_nouveau);
            this.groupBox_mise_a_jour.Location = new System.Drawing.Point(264, 9);
            this.groupBox_mise_a_jour.Name = "groupBox_mise_a_jour";
            this.groupBox_mise_a_jour.Size = new System.Drawing.Size(569, 48);
            this.groupBox_mise_a_jour.TabIndex = 29;
            this.groupBox_mise_a_jour.TabStop = false;
            this.groupBox_mise_a_jour.Text = "Mise à jour";
            // 
            // button_nouveau
            // 
            this.button_nouveau.Location = new System.Drawing.Point(45, 13);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(95, 23);
            this.button_nouveau.TabIndex = 10;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            // 
            // groupBox_navigation
            // 
            this.groupBox_navigation.Controls.Add(this.button_dernier);
            this.groupBox_navigation.Controls.Add(this.button_premier);
            this.groupBox_navigation.Controls.Add(this.button_suivant);
            this.groupBox_navigation.Controls.Add(this.button_precedent);
            this.groupBox_navigation.Location = new System.Drawing.Point(7, 310);
            this.groupBox_navigation.Name = "groupBox_navigation";
            this.groupBox_navigation.Size = new System.Drawing.Size(251, 61);
            this.groupBox_navigation.TabIndex = 28;
            this.groupBox_navigation.TabStop = false;
            this.groupBox_navigation.Text = "Navigation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID :";
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_clients.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Location = new System.Drawing.Point(12, 47);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.Size = new System.Drawing.Size(548, 246);
            this.dataGridView_clients.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom :";
            // 
            // groupBox_groupBox_formulaire
            // 
            this.groupBox_groupBox_formulaire.Controls.Add(this.label2);
            this.groupBox_groupBox_formulaire.Controls.Add(this.label3);
            this.groupBox_groupBox_formulaire.Controls.Add(this.label4);
            this.groupBox_groupBox_formulaire.Controls.Add(this.numericUpDown_id);
            this.groupBox_groupBox_formulaire.Controls.Add(this.textBox_nom);
            this.groupBox_groupBox_formulaire.Controls.Add(this.pictureBox_photo);
            this.groupBox_groupBox_formulaire.Location = new System.Drawing.Point(7, 63);
            this.groupBox_groupBox_formulaire.Name = "groupBox_groupBox_formulaire";
            this.groupBox_groupBox_formulaire.Size = new System.Drawing.Size(251, 241);
            this.groupBox_groupBox_formulaire.TabIndex = 26;
            this.groupBox_groupBox_formulaire.TabStop = false;
            this.groupBox_groupBox_formulaire.Text = "Formulaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Photo :";
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.Location = new System.Drawing.Point(57, 18);
            this.numericUpDown_id.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_id.Name = "numericUpDown_id";
            this.numericUpDown_id.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_id.TabIndex = 6;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(57, 44);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(135, 20);
            this.textBox_nom.TabIndex = 7;
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_photo.Location = new System.Drawing.Point(57, 70);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(177, 152);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_photo.TabIndex = 8;
            this.pictureBox_photo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rechercher :";
            // 
            // groupBox_grille
            // 
            this.groupBox_grille.Controls.Add(this.checkBox_decroissant);
            this.groupBox_grille.Controls.Add(this.comboBox_trier);
            this.groupBox_grille.Controls.Add(this.label6);
            this.groupBox_grille.Controls.Add(this.textBox_rechercher);
            this.groupBox_grille.Controls.Add(this.label1);
            this.groupBox_grille.Controls.Add(this.dataGridView_clients);
            this.groupBox_grille.Location = new System.Drawing.Point(264, 63);
            this.groupBox_grille.Name = "groupBox_grille";
            this.groupBox_grille.Size = new System.Drawing.Size(569, 308);
            this.groupBox_grille.TabIndex = 27;
            this.groupBox_grille.TabStop = false;
            this.groupBox_grille.Text = "Grille";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_mise_a_jour);
            this.Controls.Add(this.groupBox_navigation);
            this.Controls.Add(this.groupBox_groupBox_formulaire);
            this.Controls.Add(this.groupBox_grille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients (ADO Layers)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_mise_a_jour.ResumeLayout(false);
            this.groupBox_navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            this.groupBox_groupBox_formulaire.ResumeLayout(false);
            this.groupBox_groupBox_formulaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.groupBox_grille.ResumeLayout(false);
            this.groupBox_grille.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_decroissant;
        private System.Windows.Forms.Button button_dernier;
        private System.Windows.Forms.ComboBox comboBox_trier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_rechercher;
        private System.Windows.Forms.Button button_premier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_suivant;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_precedent;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.GroupBox groupBox_mise_a_jour;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.GroupBox groupBox_navigation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_clients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_groupBox_formulaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_id;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_grille;

    }
}