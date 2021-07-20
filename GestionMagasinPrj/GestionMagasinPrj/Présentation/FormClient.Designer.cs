namespace GestionMagasinPrj.Présentation
{
    partial class FormClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prénom = new System.Windows.Forms.TextBox();
            this.num_ID = new System.Windows.Forms.NumericUpDown();
            this.mtxt_Téléphone = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_Email = new System.Windows.Forms.MaskedTextBox();
            this.pic_Photo = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Recherche = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Photo";
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(79, 42);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(100, 20);
            this.txt_Nom.TabIndex = 1;
            // 
            // txt_Prénom
            // 
            this.txt_Prénom.Location = new System.Drawing.Point(79, 72);
            this.txt_Prénom.Name = "txt_Prénom";
            this.txt_Prénom.Size = new System.Drawing.Size(100, 20);
            this.txt_Prénom.TabIndex = 1;
            // 
            // num_ID
            // 
            this.num_ID.Location = new System.Drawing.Point(79, 16);
            this.num_ID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_ID.Name = "num_ID";
            this.num_ID.ReadOnly = true;
            this.num_ID.Size = new System.Drawing.Size(100, 20);
            this.num_ID.TabIndex = 2;
            // 
            // mtxt_Téléphone
            // 
            this.mtxt_Téléphone.Location = new System.Drawing.Point(79, 99);
            this.mtxt_Téléphone.Mask = "\\0600000000";
            this.mtxt_Téléphone.Name = "mtxt_Téléphone";
            this.mtxt_Téléphone.Size = new System.Drawing.Size(100, 20);
            this.mtxt_Téléphone.TabIndex = 3;
            // 
            // mtxt_Email
            // 
            this.mtxt_Email.Location = new System.Drawing.Point(79, 122);
            this.mtxt_Email.Mask = "?@?.?";
            this.mtxt_Email.Name = "mtxt_Email";
            this.mtxt_Email.Size = new System.Drawing.Size(100, 20);
            this.mtxt_Email.TabIndex = 4;
            // 
            // pic_Photo
            // 
            this.pic_Photo.BackColor = System.Drawing.Color.Silver;
            this.pic_Photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Photo.Location = new System.Drawing.Point(79, 148);
            this.pic_Photo.Name = "pic_Photo";
            this.pic_Photo.Size = new System.Drawing.Size(100, 79);
            this.pic_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Photo.TabIndex = 5;
            this.pic_Photo.TabStop = false;
            this.pic_Photo.Click += new System.EventHandler(this.pic_Photo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 316);
            this.dataGridView1.TabIndex = 6;
            // 
            // txt_Recherche
            // 
            this.txt_Recherche.Location = new System.Drawing.Point(199, 13);
            this.txt_Recherche.Name = "txt_Recherche";
            this.txt_Recherche.Size = new System.Drawing.Size(532, 20);
            this.txt_Recherche.TabIndex = 7;
            this.txt_Recherche.TextChanged += new System.EventHandler(this.txt_Recherche_TextChanged);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(17, 274);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(162, 23);
            this.btn_ajouter.TabIndex = 8;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(17, 303);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(162, 23);
            this.btn_modifier.TabIndex = 9;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(17, 332);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(162, 23);
            this.btn_Supprimer.TabIndex = 10;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 369);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_Recherche);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pic_Photo);
            this.Controls.Add(this.mtxt_Email);
            this.Controls.Add(this.mtxt_Téléphone);
            this.Controls.Add(this.num_ID);
            this.Controls.Add(this.txt_Prénom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormClient";
            this.Text = "FormClientcs";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_Prénom;
        private System.Windows.Forms.NumericUpDown num_ID;
        private System.Windows.Forms.MaskedTextBox mtxt_Téléphone;
        private System.Windows.Forms.MaskedTextBox mtxt_Email;
        private System.Windows.Forms.PictureBox pic_Photo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Recherche;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_Supprimer;
    }
}