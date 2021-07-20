namespace ADO.NET_and_MySQL
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_connect = new System.Windows.Forms.Button();
            this.progressBar_connecting = new System.Windows.Forms.ProgressBar();
            this.textBox_state = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button_connect.Location = new System.Drawing.Point(12, 136);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(153, 40);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connect to MySQL";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // progressBar_connecting
            // 
            this.progressBar_connecting.Location = new System.Drawing.Point(171, 136);
            this.progressBar_connecting.MarqueeAnimationSpeed = 1;
            this.progressBar_connecting.Name = "progressBar_connecting";
            this.progressBar_connecting.Size = new System.Drawing.Size(214, 40);
            this.progressBar_connecting.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar_connecting.TabIndex = 1;
            // 
            // textBox_state
            // 
            this.textBox_state.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_state.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_state.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_state.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Italic);
            this.textBox_state.ForeColor = System.Drawing.Color.Gray;
            this.textBox_state.Location = new System.Drawing.Point(12, 15);
            this.textBox_state.Multiline = true;
            this.textBox_state.Name = "textBox_state";
            this.textBox_state.ReadOnly = true;
            this.textBox_state.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_state.Size = new System.Drawing.Size(373, 115);
            this.textBox_state.TabIndex = 4;
            this.textBox_state.Text = "Disconnected.";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 190);
            this.Controls.Add(this.progressBar_connecting);
            this.Controls.Add(this.textBox_state);
            this.Controls.Add(this.button_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADO.NET and MySQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.ProgressBar progressBar_connecting;
        private System.Windows.Forms.TextBox textBox_state;
    }
}

