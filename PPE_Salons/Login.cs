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
    public partial class Login : Form
    {
        public int IdUtilisateur;
        public int LevelUtilisateur;
        public string Identifiant = "Inconnu";
        public string Password = "";
        public string TypeConnexion = "";
        public int NbConn;
        public Login()
        {
            InitializeComponent();
        }

        private void click__btn__to_cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void click__btn__to_login(object sender, EventArgs e)
        {
            this.Identifiant = txt_box__identifiant.Text;
            this.Password = Crypto.Encrypt(txt_box__password.Text);
            this.TypeConnexion = combo_box__bdd.SelectedValue.ToString(); ;
            try
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
                        String sqlString = "PS_Login_Conn";
                        var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@NomEntree", MySqlDbType.VarChar);
                        cmd.Parameters["@NomEntree"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@NomEntree"].Value = txt_box__identifiant.Text;

                        cmd.Parameters.Add("@LePass", MySqlDbType.Text);
                        cmd.Parameters["@LePass"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@LePass"].Value = SHA.petitsha(txt_box__password.Text);

                        cmd.Parameters.Add("@IdSortie", MySqlDbType.Int32);
                        cmd.Parameters["@IdSortie"].Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@LvlSortie", MySqlDbType.Int32);
                        cmd.Parameters["@LvlSortie"].Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@NbConnSortie", MySqlDbType.Int32);
                        cmd.Parameters["@NbConnSortie"].Direction = ParameterDirection.Output;


                        cmd.ExecuteNonQuery();

                        IdUtilisateur = (int)cmd.Parameters["@IdSortie"].Value;
                        var NbConnSortie = (int)cmd.Parameters["@NbConnSortie"].Value;

                        if (IdUtilisateur > 0)
                        {

                            lbl__error.Text = "Bienvenue";

                            NbConnSortie = NbConnSortie + 1;
                            String insertIncrement = "UPDATE user SET Nb_Conn = ?Nb_Conn WHERE id = ?id";
                            insertIncrement = Tools.PrepareLigne(insertIncrement, "?Nb_Conn", Tools.PrepareChamp(NbConnSortie.ToString(), "Nombre"));
                            insertIncrement = Tools.PrepareLigne(insertIncrement, "?id", Tools.PrepareChamp(IdUtilisateur.ToString(), "Nombre"));
                            var insertIncr = new MySqlCommand(insertIncrement, dbCon.Connection);
                            insertIncr.ExecuteNonQuery();
                            this.DialogResult = DialogResult.OK;//Modale est validée par OK
                            LevelUtilisateur = (int)cmd.Parameters["@LvlSortie"].Value;
                        }
                        else lbl__error.Text = "Veuillez réessayer !";
                        dbCon.Close();
                    }
                    dbCon.Close();

                }
                else if (TypeConnexion == "2")//connexion locale
                {
                    DBConnection dbCon = new DBConnection();
                    dbCon.Server = "127.0.0.1";
                    dbCon.DatabaseName = "ppe";
                    dbCon.UserName = "ClientLourd";
                    dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
                    if (dbCon.IsConnect())
                    {
                        String sqlString = "PS_Login_Conn";
                        var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@NomEntree", MySqlDbType.VarChar);
                        cmd.Parameters["@NomEntree"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@NomEntree"].Value = txt_box__identifiant.Text;

                        cmd.Parameters.Add("@LePass", MySqlDbType.Text);
                        cmd.Parameters["@LePass"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@LePass"].Value = SHA.petitsha(txt_box__password.Text);

                        cmd.Parameters.Add("@IdSortie", MySqlDbType.Int32);
                        cmd.Parameters["@IdSortie"].Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@LvlSortie", MySqlDbType.Int32);
                        cmd.Parameters["@LvlSortie"].Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@NbConnSortie", MySqlDbType.Int32);
                        cmd.Parameters["@NbConnSortie"].Direction = ParameterDirection.Output;


                        cmd.ExecuteNonQuery();

                        IdUtilisateur = (int)cmd.Parameters["@IdSortie"].Value;
                        var NbConnSortie = (int)cmd.Parameters["@NbConnSortie"].Value;

                        if (IdUtilisateur > 0)
                        {
                            lbl__error.Text = "Bienvenue";

                            NbConnSortie = NbConnSortie + 1;
                            String insertIncrement = "UPDATE user SET Nb_Conn = ?Nb_Conn WHERE id = ?id";
                            insertIncrement = Tools.PrepareLigne(insertIncrement, "?Nb_Conn", Tools.PrepareChamp(NbConnSortie.ToString(), "Nombre"));
                            insertIncrement = Tools.PrepareLigne(insertIncrement, "?id", Tools.PrepareChamp(IdUtilisateur.ToString(), "Nombre"));
                            var insertIncr = new MySqlCommand(insertIncrement, dbCon.Connection);
                            insertIncr.ExecuteNonQuery();
                            this.DialogResult = DialogResult.OK;//Modale est validée par OK
                            LevelUtilisateur = (int)cmd.Parameters["@LvlSortie"].Value;
                        }
                        else lbl__error.Text = "Veuillez réessayer !";
                        dbCon.Close();
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Erreur");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            var ComboLevelSource = new List<ComboValueBDD>();
            ComboLevelSource.Add(new ComboValueBDD() { Name = "Distante", Value = "1" });
            ComboLevelSource.Add(new ComboValueBDD() { Name = "Locale", Value = "2" });

            combo_box__bdd.DataSource = ComboLevelSource;
            combo_box__bdd.DisplayMember = "Name"; //ce qui va s'afficher
            combo_box__bdd.ValueMember = "Value"; // ce qui va s'envoyer
        }
    }
}
