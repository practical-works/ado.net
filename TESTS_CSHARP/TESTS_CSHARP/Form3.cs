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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                metroGrid1.Rows.Add("Valeur1", "Valeur2", "Valeur3");
            }
        }
    }
}
