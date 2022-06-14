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
        public string TypeConnexion = "";
        public int NbConnexion;
        public PageAdmin(int Lid, int LeLevel, string TypeConn, int NbConn)
        {
            IdUtilisateur = Lid;
            LevelUtilisateur = LeLevel;
            TypeConnexion = TypeConn;
            NbConnexion = NbConn;
            InitializeComponent();
        }

        private void PageAdmin_Load(object sender, EventArgs e)
        {
            if (TypeConnexion == "1") //connexion distante
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                dbCon.DatabaseName = "PPE_Willy";
                dbCon.UserName = "admin";
                dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    string query = "SELECT user.id, user.identifiant, user.level FROM user ORDER BY user.id";
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
            else if(TypeConnexion == "2") // connexion locale
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "ppe";
                dbCon.UserName = "ClientLourd";
                dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    string query = "SELECT user.id, user.identifiant, user.level FROM user ORDER BY user.id";
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
            
        }

        private void click__btn__to_come_back(object sender, EventArgs e)
        {
            Admin MonFormAdmin = new Admin(IdUtilisateur, LevelUtilisateur, TypeConnexion, NbConnexion);
            MonFormAdmin.Show();
            this.Close();
        }

        private void click__btn__to_add(object sender, EventArgs e)
        {  
            Employe UnEmploye = new Employe();
            UnEmploye.Id = 0;//Pour être sur qu'il soit inséré

            PageEmploye MonFormAjoutEmploye = new PageEmploye(IdUtilisateur, LevelUtilisateur, UnEmploye, TypeConnexion, NbConnexion);
            MonFormAjoutEmploye.Show();
            this.Close();   
        }

        //data grid view
        private void FormaterListe()
        {
            data_grid_view__employes.Columns["id"].Visible = true;
            data_grid_view__employes.Columns["identifiant"].HeaderText = "Identifiant";
            data_grid_view__employes.Columns["identifiant"].Width = 150;
            data_grid_view__employes.Columns["level"].HeaderText = "Rôle";
            data_grid_view__employes.Columns["level"].Width = 70;
            data_grid_view__employes.Columns["password"].Visible = false;
            data_grid_view__employes.MultiSelect = false;
            data_grid_view__employes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid_view__employes.ReadOnly = true;
        }

        private void click__btn__to_delete(object sender, EventArgs e)
        {
            if(TypeConnexion == "1") //connexion distante
            {
                foreach (DataGridViewRow row in data_grid_view__employes.SelectedRows)
                {
                    Employe LeEmploye = row.DataBoundItem as Employe;
                    if (LeEmploye.SupprimerD())
                    {
                        MessageBox.Show("Participant Supprimé !");
                    }
                    else
                        MessageBox.Show("Impossible de  Supprimer !");
                }
            }
            else if(TypeConnexion == "2") //connexion locale
            {
                foreach (DataGridViewRow row in data_grid_view__employes.SelectedRows)
                {
                    Employe LeEmploye = row.DataBoundItem as Employe;
                    if (LeEmploye.SupprimerL())
                    {
                        MessageBox.Show("Participant Supprimé !");
                    }
                    else
                        MessageBox.Show("Impossible de  Supprimer !");
                }
            }

            
        }

        private void click__btn__to_refresh(object sender, EventArgs e)
        {
            if(TypeConnexion == "1") //connexion distante
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                dbCon.DatabaseName = "PPE_Willy";
                dbCon.UserName = "admin";
                dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    string query = "SELECT user.id, user.identifiant, user.level FROM user ORDER BY user.id";
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
            else if(TypeConnexion == "2") //connexion locale
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "ppe";
                dbCon.UserName = "ClientLourd";
                dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    string query = "SELECT user.id, user.identifiant, user.level FROM user ORDER BY user.id";
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
            

        }

        private void click__btn__to_profil(object sender, EventArgs e)
        {
            if (TypeConnexion == "1")//connexion distance
            {
                foreach (DataGridViewRow row in data_grid_view__employes.SelectedRows)
                {
                    Employe UnEmploye = row.DataBoundItem as Employe;
                    PageEmploye MonFormEmploye = new PageEmploye(UnEmploye, TypeConnexion);
                    MonFormEmploye.Show();

                }
            }
            else if (TypeConnexion == "2")//connexion locale
            {
                foreach (DataGridViewRow row in data_grid_view__employes.SelectedRows)
                {
                    Employe UnEmploye = row.DataBoundItem as Employe;
                    PageEmploye MonFormEmploye = new PageEmploye(UnEmploye, TypeConnexion);
                    MonFormEmploye.Show();

                }
            }

        }
    }
}
