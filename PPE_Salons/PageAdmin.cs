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
    public partial class PageAdmin : Form
    {
        public int IdUtilisateur;
        public int LevelUtilisateur;
        public PageAdmin(int Lid, int LeLevel)
        {
            IdUtilisateur = Lid;
            LevelUtilisateur = LeLevel;
            InitializeComponent();
        }

        private void PageAdmin_Load(object sender, EventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "127.0.0.1";
            dbCon.DatabaseName = "ppe";
            dbCon.UserName = "ClientLourd";
            dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
            if (dbCon.IsConnect())
            {
                string query = "SELECT user.id, user.identifiant, user.level FROM user ORDER BY identifiant";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();//Remplissage du curseur
                List<Employe> employes = new List<Employe>();
                while (reader.Read())
                {
                    Employe employe = new Employe
                    {
                        Id = (int)reader["id"],
                        Identifiant = (string)reader["identifiant"],
                        Level = (int)reader["level"],
                    };
                    employes.Add(employe);

                }

                data_grid_view__employes.DataSource = null;
                data_grid_view__employes.DataSource = employes;
                FormaterListe();
                reader.Close();
                dbCon.Close();
                data_grid_view__employes.Visible = true;

            }
        }

        private void click__btn__to_come_back(object sender, EventArgs e)
        {
            this.Close();

            Admin MonFormAdmin = new Admin(IdUtilisateur, LevelUtilisateur);
            MonFormAdmin.Show();
        }

        private void click__btn__to_add(object sender, EventArgs e)
        {
            this.Close();

            AjoutEmploye MonFormAjoutEmploye = new AjoutEmploye(IdUtilisateur, LevelUtilisateur);
            MonFormAjoutEmploye.Show();
        }

        private void click__btn_to_history(object sender, EventArgs e)
        {
            this.Close();

            Historique MonFormHistorique = new Historique(IdUtilisateur, LevelUtilisateur);
            MonFormHistorique.Show();
        }

        //data grid view
        private void FormaterListe()
        {
            data_grid_view__employes.Columns["id"].Visible = true;
            data_grid_view__employes.Columns["identifiant"].HeaderText = "Identifiant";
            data_grid_view__employes.Columns["identifiant"].Width = 150;
            data_grid_view__employes.Columns["level"].HeaderText = "Rôle";
            data_grid_view__employes.Columns["Level"].Width = 50;
            data_grid_view__employes.MultiSelect = false;
            data_grid_view__employes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid_view__employes.ReadOnly = true;
        }
    }
}
