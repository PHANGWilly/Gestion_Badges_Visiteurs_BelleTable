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
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "ppe";
                dbCon.UserName = "ClientLourd";
                dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");

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

                    cmd.ExecuteNonQuery();
                    IdUtilisateur = (int)cmd.Parameters["@IdSortie"].Value;
                    if (IdUtilisateur > 0)
                    {
                        lbl__error.Text = "Bienvenue";
                        this.DialogResult = DialogResult.OK;//Modale est validée par OK
                        LevelUtilisateur = (int)cmd.Parameters["@LvlSortie"].Value;
                    }
                    else lbl__error.Text = "Veuillez réessayer !";
                    dbCon.Close();
                }
                dbCon.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Erreur");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
