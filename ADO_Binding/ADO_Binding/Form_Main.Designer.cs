namespace ADO_Binding
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.groupBox_navigation = new System.Windows.Forms.GroupBox();
            this.button_dernier = new System.Windows.Forms.Button();
            this.button_premier = new System.Windows.Forms.Button();
            this.button_suivant = new System.Windows.Forms.Button();
            this.button_precedent = new System.Windows.Forms.Button();
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_decroissant = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_groupBox_formulaire = new System.Windows.Forms.GroupBox();
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_mise_a_jour = new System.Windows.Forms.GroupBox();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_trier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_rechercher = new System.Windows.Forms.TextBox();
            this.groupBox_grille = new System.Windows.Forms.GroupBox();
            this.NAVIGATEUR = new System.Windows.Forms.BindingNavigator(this.components);
            this.NAVIGATEUR_nouveau = new System.Windows.Forms.ToolStripButton();
            this.NAVIGATEUR_compte = new System.Windows.Forms.ToolStripLabel();
            this.NAVIGATEUR_supprimer = new System.Windows.Forms.ToolStripButton();
            this.NAVIGATEUR_premier = new System.Windows.Forms.ToolStripButton();
            this.NAVIGATEUR_precedent = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.NAVIGATEUR_position = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NAVIGATEUR_suivant = new System.Windows.Forms.ToolStripButton();
            this.NAVIGATEUR_dernier = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NAVIGATEUR_enregistrer = new System.Windows.Forms.ToolStripButton();
            this.groupBox_navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            this.groupBox_groupBox_formulaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.groupBox_mise_a_jour.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_grille.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NAVIGATEUR)).BeginInit();
            this.NAVIGATEUR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_navigation
            // 
            this.groupBox_navigation.Controls.Add(this.button_dernier);
            this.groupBox_navigation.Controls.Add(this.button_premier);
            this.groupBox_navigation.Controls.Add(this.button_suivant);
            this.groupBox_navigation.Controls.Add(this.button_precedent);
            this.groupBox_navigation.Enabled = false;
            this.groupBox_navigation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox_navigation.Location = new System.Drawing.Point(8, 316);
            this.groupBox_navigation.Name = "groupBox_navigation";
            this.groupBox_navigation.Size = new System.Drawing.Size(251, 66);
            this.groupBox_navigation.TabIndex = 33;
            this.groupBox_navigation.TabStop = false;
            this.groupBox_navigation.Text = "Navigation";
            // 
            // button_dernier
            // 
            this.button_dernier.Location = new System.Drawing.Point(178, 16);
            this.button_dernier.Name = "button_dernier";
            this.button_dernier.Size = new System.Drawing.Size(44, 34);
            this.button_dernier.TabIndex = 22;
            this.button_dernier.Text = ">>";
            this.button_dernier.UseVisualStyleBackColor = true;
            // 
            // button_premier
            // 
            this.button_premier.Location = new System.Drawing.Point(28, 16);
            this.button_premier.Name = "button_premier";
            this.button_premier.Size = new System.Drawing.Size(44, 34);
            this.button_premier.TabIndex = 23;
            this.button_premier.Text = "<<";
            this.button_premier.UseVisualStyleBackColor = true;
            // 
            // button_suivant
            // 
            this.button_suivant.Location = new System.Drawing.Point(128, 16);
            this.button_suivant.Name = "button_suivant";
            this.button_suivant.Size = new System.Drawing.Size(44, 34);
            this.button_suivant.TabIndex = 21;
            this.button_suivant.Text = ">";
            this.button_suivant.UseVisualStyleBackColor = true;
            // 
            // button_precedent
            // 
            this.button_precedent.Location = new System.Drawing.Point(78, 16);
            this.button_precedent.Name = "button_precedent";
            this.button_precedent.Size = new System.Drawing.Size(44, 34);
            this.button_precedent.TabIndex = 24;
            this.button_precedent.Text = "<";
            this.button_precedent.UseVisualStyleBackColor = true;
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_clients.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Location = new System.Drawing.Point(12, 46);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.Size = new System.Drawing.Size(512, 224);
            this.dataGridView_clients.TabIndex = 13;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Enabled = false;
            this.button_ajouter.Location = new System.Drawing.Point(160, 14);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(95, 25);
            this.button_ajouter.TabIndex = 10;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            // 
            // button_modifier
            // 
            this.button_modifier.Enabled = false;
            this.button_modifier.Location = new System.Drawing.Point(280, 14);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(95, 25);
            this.button_modifier.TabIndex = 10;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID :";
            // 
            // checkBox_decroissant
            // 
            this.checkBox_decroissant.AutoSize = true;
            this.checkBox_decroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_decroissant.Location = new System.Drawing.Point(439, 20);
            this.checkBox_decroissant.Name = "checkBox_decroissant";
            this.checkBox_decroissant.Size = new System.Drawing.Size(83, 18);
            this.checkBox_decroissant.TabIndex = 22;
            this.checkBox_decroissant.Text = "Décroissant";
            this.checkBox_decroissant.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Photo :";
            // 
            // groupBox_groupBox_formulaire
            // 
            this.groupBox_groupBox_formulaire.Controls.Add(this.label2);
            this.groupBox_groupBox_formulaire.Controls.Add(this.label3);
            this.groupBox_groupBox_formulaire.Controls.Add(this.label4);
            this.groupBox_groupBox_formulaire.Controls.Add(this.numericUpDown_id);
            this.groupBox_groupBox_formulaire.Controls.Add(this.textBox_nom);
            this.groupBox_groupBox_formulaire.Controls.Add(this.pictureBox_photo);
            this.groupBox_groupBox_formulaire.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox_groupBox_formulaire.Location = new System.Drawing.Point(8, 95);
            this.groupBox_groupBox_formulaire.Name = "groupBox_groupBox_formulaire";
            this.groupBox_groupBox_formulaire.Size = new System.Drawing.Size(251, 214);
            this.groupBox_groupBox_formulaire.TabIndex = 31;
            this.groupBox_groupBox_formulaire.TabStop = false;
            this.groupBox_groupBox_formulaire.Text = "Formulaire";
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_id.ForeColor = System.Drawing.Color.MidnightBlue;
            this.numericUpDown_id.Location = new System.Drawing.Point(80, 20);
            this.numericUpDown_id.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_id.Name = "numericUpDown_id";
            this.numericUpDown_id.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown_id.TabIndex = 6;
            // 
            // textBox_nom
            // 
            this.textBox_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox_nom.Location = new System.Drawing.Point(80, 48);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(99, 21);
            this.textBox_nom.TabIndex = 7;
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_photo.Location = new System.Drawing.Point(80, 76);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(139, 119);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_photo.TabIndex = 8;
            this.pictureBox_photo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rechercher :";
            // 
            // groupBox_mise_a_jour
            // 
            this.groupBox_mise_a_jour.Controls.Add(this.button_ajouter);
            this.groupBox_mise_a_jour.Controls.Add(this.button_modifier);
            this.groupBox_mise_a_jour.Controls.Add(this.button_supprimer);
            this.groupBox_mise_a_jour.Controls.Add(this.button_nouveau);
            this.groupBox_mise_a_jour.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox_mise_a_jour.Location = new System.Drawing.Point(265, 37);
            this.groupBox_mise_a_jour.Name = "groupBox_mise_a_jour";
            this.groupBox_mise_a_jour.Size = new System.Drawing.Size(535, 52);
            this.groupBox_mise_a_jour.TabIndex = 34;
            this.groupBox_mise_a_jour.TabStop = false;
            this.groupBox_mise_a_jour.Text = "Mise à jour";
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(400, 14);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(95, 25);
            this.button_supprimer.TabIndex = 10;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            // 
            // button_nouveau
            // 
            this.button_nouveau.Location = new System.Drawing.Point(40, 14);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(95, 25);
            this.button_nouveau.TabIndex = 10;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(8, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 54);
            this.panel1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(20, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Clients [BS]";
            // 
            // comboBox_trier
            // 
            this.comboBox_trier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_trier.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox_trier.FormattingEnabled = true;
            this.comboBox_trier.Items.AddRange(new object[] {
            "(Aucun)",
            "ID",
            "Nom"});
            this.comboBox_trier.Location = new System.Drawing.Point(336, 16);
            this.comboBox_trier.Name = "comboBox_trier";
            this.comboBox_trier.Size = new System.Drawing.Size(96, 22);
            this.comboBox_trier.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Trier :";
            // 
            // textBox_rechercher
            // 
            this.textBox_rechercher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_rechercher.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox_rechercher.Location = new System.Drawing.Point(83, 16);
            this.textBox_rechercher.Name = "textBox_rechercher";
            this.textBox_rechercher.Size = new System.Drawing.Size(119, 21);
            this.textBox_rechercher.TabIndex = 16;
            // 
            // groupBox_grille
            // 
            this.groupBox_grille.Controls.Add(this.checkBox_decroissant);
            this.groupBox_grille.Controls.Add(this.comboBox_trier);
            this.groupBox_grille.Controls.Add(this.label6);
            this.groupBox_grille.Controls.Add(this.textBox_rechercher);
            this.groupBox_grille.Controls.Add(this.label1);
            this.groupBox_grille.Controls.Add(this.dataGridView_clients);
            this.groupBox_grille.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox_grille.Location = new System.Drawing.Point(265, 95);
            this.groupBox_grille.Name = "groupBox_grille";
            this.groupBox_grille.Size = new System.Drawing.Size(535, 286);
            this.groupBox_grille.TabIndex = 32;
            this.groupBox_grille.TabStop = false;
            this.groupBox_grille.Text = "Grille";
            // 
            // NAVIGATEUR
            // 
            this.NAVIGATEUR.AddNewItem = this.NAVIGATEUR_nouveau;
            this.NAVIGATEUR.CountItem = this.NAVIGATEUR_compte;
            this.NAVIGATEUR.DeleteItem = this.NAVIGATEUR_supprimer;
            this.NAVIGATEUR.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.NAVIGATEUR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NAVIGATEUR_premier,
            this.NAVIGATEUR_precedent,
            this.bindingNavigatorSeparator,
            this.NAVIGATEUR_position,
            this.NAVIGATEUR_compte,
            this.bindingNavigatorSeparator1,
            this.NAVIGATEUR_suivant,
            this.NAVIGATEUR_dernier,
            this.bindingNavigatorSeparator2,
            this.NAVIGATEUR_nouveau,
            this.NAVIGATEUR_supprimer,
            this.NAVIGATEUR_enregistrer});
            this.NAVIGATEUR.Location = new System.Drawing.Point(0, 0);
            this.NAVIGATEUR.MoveFirstItem = this.NAVIGATEUR_premier;
            this.NAVIGATEUR.MoveLastItem = this.NAVIGATEUR_dernier;
            this.NAVIGATEUR.MoveNextItem = this.NAVIGATEUR_suivant;
            this.NAVIGATEUR.MovePreviousItem = this.NAVIGATEUR_precedent;
            this.NAVIGATEUR.Name = "NAVIGATEUR";
            this.NAVIGATEUR.PositionItem = this.NAVIGATEUR_position;
            this.NAVIGATEUR.Size = new System.Drawing.Size(809, 25);
            this.NAVIGATEUR.TabIndex = 36;
            // 
            // NAVIGATEUR_nouveau
            // 
            this.NAVIGATEUR_nouveau.Image = ((System.Drawing.Image)(resources.GetObject("NAVIGATEUR_nouveau.Image")));
            this.NAVIGATEUR_nouveau.Name = "NAVIGATEUR_nouveau";
            this.NAVIGATEUR_nouveau.RightToLeftAutoMirrorImage = true;
            this.NAVIGATEUR_nouveau.Size = new System.Drawing.Size(75, 22);
            this.NAVIGATEUR_nouveau.Text = "Nouveau";
            // 
            // NAVIGATEUR_compte
            // 
            this.NAVIGATEUR_compte.Name = "NAVIGATEUR_compte";
            this.NAVIGATEUR_compte.Size = new System.Drawing.Size(37, 22);
            this.NAVIGATEUR_compte.Text = "de {0}";
            this.NAVIGATEUR_compte.ToolTipText = "Nombre total d\'éléments";
            // 
            // NAVIGATEUR_supprimer
            // 
            this.NAVIGATEUR_supprimer.Image = ((System.Drawing.Image)(resources.GetObject("NAVIGATEUR_supprimer.Image")));
            this.NAVIGATEUR_supprimer.Name = "NAVIGATEUR_supprimer";
            this.NAVIGATEUR_supprimer.RightToLeftAutoMirrorImage = true;
            this.NAVIGATEUR_supprimer.Size = new System.Drawing.Size(82, 22);
            this.NAVIGATEUR_supprimer.Text = "Supprimer";
            // 
            // NAVIGATEUR_premier
            // 
            this.NAVIGATEUR_premier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NAVIGATEUR_premier.Image = ((System.Drawing.Image)(resources.GetObject("NAVIGATEUR_premier.Image")));
            this.NAVIGATEUR_premier.Name = "NAVIGATEUR_premier";
            this.NAVIGATEUR_premier.RightToLeftAutoMirrorImage = true;
            this.NAVIGATEUR_premier.Size = new System.Drawing.Size(23, 22);
            this.NAVIGATEUR_premier.Text = "Placer en premier";
            // 
            // NAVIGATEUR_precedent
            // 
            this.NAVIGATEUR_precedent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NAVIGATEUR_precedent.Image = ((System.Drawing.Image)(resources.GetObject("NAVIGATEUR_precedent.Image")));
            this.NAVIGATEUR_precedent.Name = "NAVIGATEUR_precedent";
            this.NAVIGATEUR_precedent.RightToLeftAutoMirrorImage = true;
            this.NAVIGATEUR_precedent.Size = new System.Drawing.Size(23, 22);
            this.NAVIGATEUR_precedent.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // NAVIGATEUR_position
            // 
            this.NAVIGATEUR_position.AccessibleName = "Position";
            this.NAVIGATEUR_position.AutoSize = false;
            this.NAVIGATEUR_position.Name = "NAVIGATEUR_position";
            this.NAVIGATEUR_position.Size = new System.Drawing.Size(50, 23);
            this.NAVIGATEUR_position.Text = "0";
            this.NAVIGATEUR_position.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // NAVIGATEUR_suivant
            // 
            this.NAVIGATEUR_suivant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NAVIGATEUR_suivant.Image = ((System.Drawing.Image)(resources.GetObject("NAVIGATEUR_suivant.Image")));
            this.NAVIGATEUR_suivant.Name = "NAVIGATEUR_suivant";
            this.NAVIGATEUR_suivant.RightToLeftAutoMirrorImage = true;
            this.NAVIGATEUR_suivant.Size = new System.Drawing.Size(23, 22);
            this.NAVIGATEUR_suivant.Text = "Déplacer vers le bas";
            // 
            // NAVIGATEUR_dernier
            // 
            this.NAVIGATEUR_dernier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NAVIGATEUR_dernier.Image = ((System.Drawing.Image)(resources.GetObject("NAVIGATEUR_dernier.Image")));
            this.NAVIGATEUR_dernier.Name = "NAVIGATEUR_dernier";
            this.NAVIGATEUR_dernier.RightToLeftAutoMirrorImage = true;
            this.NAVIGATEUR_dernier.Size = new System.Drawing.Size(23, 22);
            this.NAVIGATEUR_dernier.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // NAVIGATEUR_enregistrer
            // 
            this.NAVIGATEUR_enregistrer.Image = global::ADO_Binding.Properties.Resources.diskette;
            this.NAVIGATEUR_enregistrer.ImageTransparentColor = System.Drawing.Color.White;
            this.NAVIGATEUR_enregistrer.Name = "NAVIGATEUR_enregistrer";
            this.NAVIGATEUR_enregistrer.Size = new System.Drawing.Size(83, 22);
            this.NAVIGATEUR_enregistrer.Text = "Enregistrer";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 393);
            this.Controls.Add(this.NAVIGATEUR);
            this.Controls.Add(this.groupBox_navigation);
            this.Controls.Add(this.groupBox_groupBox_formulaire);
            this.Controls.Add(this.groupBox_mise_a_jour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_grille);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients (ADO Data Bindings)";
            this.groupBox_navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            this.groupBox_groupBox_formulaire.ResumeLayout(false);
            this.groupBox_groupBox_formulaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.groupBox_mise_a_jour.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_grille.ResumeLayout(false);
            this.groupBox_grille.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NAVIGATEUR)).EndInit();
            this.NAVIGATEUR.ResumeLayout(false);
            this.NAVIGATEUR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_navigation;
        private System.Windows.Forms.Button button_dernier;
        private System.Windows.Forms.Button button_premier;
        private System.Windows.Forms.Button button_suivant;
        private System.Windows.Forms.Button button_precedent;
        private System.Windows.Forms.DataGridView dataGridView_clients;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_decroissant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_groupBox_formulaire;
        private System.Windows.Forms.NumericUpDown numericUpDown_id;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_mise_a_jour;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_trier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_rechercher;
        private System.Windows.Forms.GroupBox groupBox_grille;
        private System.Windows.Forms.BindingNavigator NAVIGATEUR;
        private System.Windows.Forms.ToolStripButton NAVIGATEUR_nouveau;
        private System.Windows.Forms.ToolStripLabel NAVIGATEUR_compte;
        private System.Windows.Forms.ToolStripButton NAVIGATEUR_supprimer;
        private System.Windows.Forms.ToolStripButton NAVIGATEUR_premier;
        private System.Windows.Forms.ToolStripButton NAVIGATEUR_precedent;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox NAVIGATEUR_position;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton NAVIGATEUR_suivant;
        private System.Windows.Forms.ToolStripButton NAVIGATEUR_dernier;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton NAVIGATEUR_enregistrer;
    }
}