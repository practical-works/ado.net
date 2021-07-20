using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADO.NET_and_MySQL
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            progressBar_connecting.Hide();
        }

        private void ShowFailureMessage(string failureMessage)
        {
            textBox_state.ForeColor = Color.DarkRed;
            textBox_state.Font = new Font(textBox_state.Font, FontStyle.Bold);
            textBox_state.Text = failureMessage;
        }
        private void ShowSuccessMessage(string successMessage)
        {
            textBox_state.ForeColor = Color.Green;
            textBox_state.Font = new Font(textBox_state.Font, FontStyle.Bold);
            textBox_state.Text = successMessage;
        }
        private void ShowMessage(string message)
        {
            textBox_state.ForeColor = DefaultForeColor;
            textBox_state.Font = new Font(textBox_state.Font, FontStyle.Regular);
            textBox_state.Text = message;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            progressBar_connecting.Show();
            ShowMessage("Connecting...");
            button_connect.Enabled = false;
            textBox_state.SelectionLength = 0;
            Action ConnectAsync = delegate()
            {
                try
                {
                    //string connectionString = @"Server=localhost; user id=root; database=test;";
                    string connectionString = @"Server=amb.mysqldb.com; user id=amb; password=12345; database=amb_db;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        ShowSuccessMessage(string.Format("Connected to [{0}] database on [{1}] server.", connection.Database, connection.DataSource));
                    }
                }
                catch (Exception exception)
                {
                    ShowFailureMessage(exception.Message);
                    button_connect.Enabled = true;
                }
                progressBar_connecting.Hide();
            };
            ConnectAsync.BeginInvoke(null, null);
        }
    }
}
