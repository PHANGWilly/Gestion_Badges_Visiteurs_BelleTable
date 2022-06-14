using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            if (MonFormLogin.DialogResult == DialogResult.OK)
            {
                //recupération de l'id et du level
                int LevelUtilisateur = MonFormLogin.LevelUtilisateur;
                int IdUtilisateur = MonFormLogin.IdUtilisateur;
                string TypeConnexion = MonFormLogin.TypeConnexion;
                int NbConnexion = MonFormLogin.NbConn;
                MonFormLogin.Close();
                Application.Run(new Admin(IdUtilisateur, LevelUtilisateur, TypeConnexion, NbConnexion));

                if (TypeConnexion == "1")//connexion distante
                {
                    DBConnection dbCon = new DBConnection();
                    dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                    dbCon.DatabaseName = "PPE_Willy";
                    dbCon.UserName = "admin";
                    dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                    if (dbCon.IsConnect())
                    {
                        string query = "UPDATE user SET Date_Derniere_Conn = ?date_derniere_conn WHERE id = ?id";
                        query = Tools.PrepareLigne(query, "?id", Tools.PrepareChamp(IdUtilisateur.ToString(), "Nombre"));
                        query = Tools.PrepareLigne(query, "?date_derniere_conn", Tools.PrepareChamp(Date.RetournerDateFrancais(), "Chaine")); 
                        var cmd = new MySqlCommand(query, dbCon.Connection);
                        var reader = cmd.ExecuteReader();//Remplissage du curseur
                        reader.Close();
                        dbCon.Close();
                    }
                }
                else if (TypeConnexion == "2") //connexion locale
                {
                    DBConnection dbCon = new DBConnection();
                    dbCon.Server = "127.0.0.1";
                    dbCon.DatabaseName = "ppe";
                    dbCon.UserName = "ClientLourd";
                    dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
                    if (dbCon.IsConnect())
                    {
                        string query = "UPDATE user SET Date_Derniere_Conn = ?date_derniere_conn WHERE id = ?id";
                        query = Tools.PrepareLigne(query, "?id", Tools.PrepareChamp(IdUtilisateur.ToString(), "Nombre"));
                        query = Tools.PrepareLigne(query, "?date_derniere_conn", Tools.PrepareChamp(Date.RetournerDateFrancais(), "Chaine")); ;
                        var cmd = new MySqlCommand(query, dbCon.Connection);
                        var reader = cmd.ExecuteReader();//Remplissage du curseur
                        reader.Close();
                        dbCon.Close();
                    }
                }
                MessageBox.Show("À bientôt ...");

            }
            else
            {
                MonFormLogin.Close();
                MessageBox.Show("Au revoir ...");
            }
        }
    }
}
