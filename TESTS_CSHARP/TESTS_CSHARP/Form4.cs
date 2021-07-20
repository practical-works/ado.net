using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TESTS_CSHARP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            button1.Enabled = false;
            //textBox1.MaxLength = 6;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Length.ToString();
            if (textBox1.TextLength >= 6)
            {
                button1.Enabled = true;
            }
            else
            {
                
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength >= 6)
            {
                MessageBox.Show("Khdaaaaaaaaaam");
            }
            else
            {

                MessageBox.Show("a brrd, khask tekteb 6");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('@'))
            {
                MessageBox.Show("Email valide !");
            }
            else
            {
                MessageBox.Show("aa");
            }
        }
    }
}
