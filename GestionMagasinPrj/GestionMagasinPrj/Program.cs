using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GestionMagasinPrj.Présentation;

namespace GestionMagasinPrj
{
    static class Program
    {
        // Chaîne de la connexion SQL utilisée dans le programme
        public static string CHAINE_CONNEXION = @"Data Source=AMBRATOLM-PC\AMBRATOLM_SQL;
                                                  Initial Catalog=GestionMagasinDb;
                                                  Integrated Security=True";
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormClient());
        }
    }
}
