using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PPE_Salons
{
    public partial class Historique : Form
    {
        public int IdUtilisateur;
        public int LevelUtilisateur;
        public Historique(int Lid, int LeLevel)
        {
            IdUtilisateur = Lid;
            LevelUtilisateur = LeLevel;
            InitializeComponent();
        }

        private void click__btn__to_come_back(object sender, EventArgs e)
        {
            this.Close();

            PageAdmin MonFormPageAdmin = new PageAdmin(IdUtilisateur, LevelUtilisateur);
            MonFormPageAdmin.Show();
        }

        private void Historique_Load(object sender, EventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "127.0.0.1";
            dbCon.DatabaseName = "ppe";
            dbCon.UserName = "ClientLourd";
            dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
            if (dbCon.IsConnect())
            {
                string query = "SELECT historique.id, historique.debut, historique.fin FROM historique ORDER BY id";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();//Remplissage du curseur
                List<History> histories = new List<History>();
                while (reader.Read())
                {
                    History Ahistory  = new History
                    {
                        id = (int)reader["id"],
                        debut = (string)reader["debut"],
                        fin = (int)reader["fin"],
                    };
                    //History.Add(Ahistory);
                }

                data_grid_view__historique.DataSource = null;
                data_grid_view__historique.DataSource = histories;
                FormaterListe();
                reader.Close();
                dbCon.Close();
                data_grid_view__historique.Visible = true;

            }
        }

        private void FormaterListe()
        {
            data_grid_view__historique.Columns["id"].Visible = true;
            data_grid_view__historique.Columns["debut"].HeaderText = "Début";
            data_grid_view__historique.Columns["debut"].Width = 150;
            data_grid_view__historique.Columns["fin"].HeaderText = "Rôle";
            data_grid_view__historique.Columns["fin"].Width = 50;
            data_grid_view__historique.MultiSelect = false;
            data_grid_view__historique.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid_view__historique.ReadOnly = true;
        }
    }
}
