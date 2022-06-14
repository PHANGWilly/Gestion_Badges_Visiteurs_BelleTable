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
    public partial class Admin : Form
    {
        public int IdUtilisateur;
        public int LevelUtilisateur;
        public int NbConnexion;
        public string TypeConnexion = "";

        public Admin(int Lid, int LeLevel, string TypeConn, int NbConn)
        {
            IdUtilisateur = Lid;
            LevelUtilisateur = LeLevel;
            TypeConnexion = TypeConn;
            NbConnexion = NbConn;
            InitializeComponent();

            if(LeLevel == 2)
            {
                btn__to_admin.Visible = true;
            }
            else
            {
                btn__to_admin.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e) //afficher tous les participants
        {
            if (TypeConnexion == "1")//connexion distante
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                dbCon.DatabaseName = "PPE_Willy";
                dbCon.UserName = "admin";
                dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    string query = "SELECT Id, Nom, Prenom, Email FROM contact ORDER BY Nom";
                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteReader();//Remplissage du curseur
                    List<Contact> contacts = new List<Contact>();
                    while (reader.Read())
                    {
                        Contact contact = new Contact
                        {
                            Id = (int)reader["Id"],
                            Nom = (string)reader["Nom"],
                            Prenom = (string)reader["Prenom"],
                            Email = (string)reader["Email"],
                        };
                        contacts.Add(contact);
                    }

                    MaGrid.DataSource = null;
                    MaGrid.DataSource = contacts;
                    FormaterListe();
                    reader.Close();
                    dbCon.Close();
                    MaGrid.Visible = true;

                }
            }
            else if(TypeConnexion == "2")//connexion locale
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "ppe";
                dbCon.UserName = "ClientLourd";
                dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    string query = "SELECT Id, Nom, Prenom, Email FROM contact ORDER BY Nom";
                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteReader();//Remplissage du curseur
                    List<Contact> contacts = new List<Contact>();
                    while (reader.Read())
                    {
                        Contact contact = new Contact
                        {
                            Id = (int)reader["Id"],
                            Nom = (string)reader["Nom"],
                            Prenom = (string)reader["Prenom"],
                            Email = (string)reader["Email"],
                        };
                        contacts.Add(contact);
                    }

                    MaGrid.DataSource = null;
                    MaGrid.DataSource = contacts;
                    FormaterListe();
                    reader.Close();
                    dbCon.Close();
                    MaGrid.Visible = true;

                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e) // afficher les details du contact
        {
            if(TypeConnexion == "1")//connexion distance
            {
                foreach (DataGridViewRow row in MaGrid.SelectedRows)
                {
                    Contact UnParticipant = row.DataBoundItem as Contact;
                    PageParticipant MonFormParticipant = new PageParticipant(UnParticipant, TypeConnexion);
                    MonFormParticipant.Show();

                }
            }
            else if(TypeConnexion == "2")//connexion locale
            {
                foreach (DataGridViewRow row in MaGrid.SelectedRows)
                {
                    Contact UnParticipant = row.DataBoundItem as Contact;
                    PageParticipant MonFormParticipant = new PageParticipant(UnParticipant, TypeConnexion);
                    MonFormParticipant.Show();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e) //ajouter une participant
        {
            if(TypeConnexion == "1")
            {
                Contact UnParticipant = new Contact();
                UnParticipant.Id = 0;//Pour être sur qu'il soit inséré
                PageParticipant MonFormParticipant = new PageParticipant(UnParticipant, TypeConnexion);
                MonFormParticipant.Show();
            }
            else if(TypeConnexion == "2")
            {
                Contact UnParticipant = new Contact();
                UnParticipant.Id = 0;//Pour être sur qu'il soit inséré
                PageParticipant MonFormParticipant = new PageParticipant(UnParticipant, TypeConnexion);
                MonFormParticipant.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(TypeConnexion == "1") //connexion distance
            {
                foreach (DataGridViewRow row in MaGrid.SelectedRows)
                {
                    Contact UnParticipant = row.DataBoundItem as Contact;
                    if (UnParticipant.SupprimerD())
                        MessageBox.Show("Participant Supprimé !");
                    // Ici on rafraîchit la liste....
                    else
                        MessageBox.Show("Impossible de  Supprimer !");
                }
            }
            else if(TypeConnexion == "2")
            {
                foreach (DataGridViewRow row in MaGrid.SelectedRows)
                {
                    Contact UnParticipant = row.DataBoundItem as Contact;
                    if (UnParticipant.SupprimerL())
                        MessageBox.Show("Participant Supprimé !");
                    // Ici on rafraîchit la liste....
                    else
                        MessageBox.Show("Impossible de  Supprimer !");
                }
            }
            
        }

        private void FormaterListe()
        {
            MaGrid.Columns["Id"].Visible = false;
            MaGrid.Columns["Nom"].HeaderText = "Nom du participant";
            MaGrid.Columns["Nom"].Width = 150;
            MaGrid.MultiSelect = false;
            MaGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MaGrid.ReadOnly = true;
        }
        private void button5_Click(object sender, EventArgs e) //affiche le participant
        {
            if (TypeConnexion == "1") // connexion distante
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                dbCon.DatabaseName = "PPE_Willy";
                dbCon.UserName = "admin";
                dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    string query = "SELECT Id, Nom, Prenom, Email FROM contact where Nom =?nom_P ORDER BY Nom";
                    query = Tools.PrepareLigne(query, "?nom_P", Tools.PrepareChamp(tbNom.Text, "Chaine"));

                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteReader();//Remplissage du curseur
                    List<Contact> contacts = new List<Contact>();
                    while (reader.Read())
                    {
                        Contact contact = new Contact
                        {
                            Id = (int)reader["Id"],
                            Nom = (string)reader["Nom"],
                            Prenom = (string)reader["Prenom"],
                            Email = (string)reader["Email"],
                        };
                        contacts.Add(contact);
                    }

                    MaGrid.DataSource = null;
                    MaGrid.DataSource = contacts;
                    FormaterListe();
                    reader.Close();
                    dbCon.Close();
                    MaGrid.Visible = true;
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
                    string query = "SELECT Id, Nom, Prenom, Email FROM contact where Nom =?nom_P ORDER BY Nom";
                    query = Tools.PrepareLigne(query, "?nom_P", Tools.PrepareChamp(tbNom.Text, "Chaine"));

                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteReader();//Remplissage du curseur
                    List<Contact> contacts = new List<Contact>();
                    while (reader.Read())
                    {
                        Contact contact = new Contact
                        {
                            Id = (int)reader["Id"],
                            Nom = (string)reader["Nom"],
                            Prenom = (string)reader["Prenom"],
                            Email = (string)reader["Email"],
                        };
                        contacts.Add(contact);
                    }

                    MaGrid.DataSource = null;
                    MaGrid.DataSource = contacts;
                    FormaterListe();
                    reader.Close();
                    dbCon.Close();
                    MaGrid.Visible = true;
                }
            }
  
        }

        private void click__btn__to_admin(object sender, EventArgs e)
        {
            //this.Hide();

            PageAdmin MonFormPageAdmin = new PageAdmin(IdUtilisateur, LevelUtilisateur, TypeConnexion, NbConnexion);
            MonFormPageAdmin.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
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
                    string query = "SELECT Nb_Conn, Date_DerniereèConn FROM user WHERE id = ?id";
                    query = Tools.PrepareLigne(query, "?id", Tools.PrepareChamp(IdUtilisateur.ToString(), "Nombre"));
                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteReader();//Remplissage du curseur
                    while (reader.Read())
                    {
                        lbl__nb_conn.Text = "Connexion n° "+(int)reader["Nb_Conn"];
                            
                        if((string)reader["Date_Derniere_Conn"] == " " || (string)reader["Date_Derniere_Conn"] == "***")
                        {
                            lbl__last_conn.Text = " ";
                        }
                        else
                        {
                            lbl__last_conn.Text = "Dernière connexion le " + (string)reader["Date_Derniere_Conn"];
                        }
                    }
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
                    string query = "SELECT Nb_Conn, Date_Derniere_Conn FROM user WHERE id = ?id";
                    query = Tools.PrepareLigne(query, "?id", Tools.PrepareChamp(IdUtilisateur.ToString(), "Nombre"));
                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteReader();//Remplissage du curseur
                    while (reader.Read())
                    {
                        lbl__nb_conn.Text = "Connexion n° " + (int)reader["Nb_Conn"];
                        if ((string)reader["Date_Derniere_Conn"] == " " || (string)reader["Date_Derniere_Conn"] == "***")
                        {
                            lbl__last_conn.Text = " ";
                        }
                        else
                        {
                            lbl__last_conn.Text = "Dernière connexion le " + (string)reader["Date_Derniere_Conn"];
                        }
                    }
                    reader.Close();
                    dbCon.Close();
                }
            }
        }
    }
}
