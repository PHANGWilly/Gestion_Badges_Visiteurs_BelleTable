using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Salons
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login MonFormLogin = new Login();

            MonFormLogin.ShowDialog();
            if(MonFormLogin.DialogResult == DialogResult.OK)
            {
                //recupération de l'id et du level
                int LevelUtilisateur = MonFormLogin.LevelUtilisateur;
                int IdUtilisateur = MonFormLogin.IdUtilisateur;
                MonFormLogin.Close();
                Application.Run(new Admin(IdUtilisateur, LevelUtilisateur));
            }
            else
            {
                MonFormLogin.Close();
                MessageBox.Show("Au revoir ...");
            }
        }
    }
}
