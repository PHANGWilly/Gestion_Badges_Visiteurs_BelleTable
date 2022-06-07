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
    public partial class AjoutEmploye : Form
    {
        public int IdUtilisateur;
        public int LevelUtilisateur;
        public AjoutEmploye(int Lid, int LeLevel)
        {
            IdUtilisateur = Lid;
            LevelUtilisateur = LeLevel;
            InitializeComponent();
        }

        private void click__btn__to_retour(object sender, EventArgs e)
        {
            this.Close();
            
            PageAdmin MonFormPageAdmin = new PageAdmin(IdUtilisateur, LevelUtilisateur);
            MonFormPageAdmin.Show();
        }

        private void click__btn_add(object sender, EventArgs e)
        {
            ComboValue MaComboValue = (ComboValue)combo_box__level.SelectedItem;
            int LevelUser = int.Parse(MaComboValue.Value);

            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "ppe";
                dbCon.UserName = "ClientLourd";
                dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    String sqlString = "AjoutEmploye";
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.CommandType = CommandType.StoredProcedure; //Il faut System.Data pour cette ligne

                    cmd.Parameters.Add("@IdentifiantEntree", MySqlDbType.VarChar);
                    cmd.Parameters["@IdentifiantEntree"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@IdentifiantEntree"].Value = txt_box__identifiant.Text;
                    
                    cmd.Parameters.Add("@LePassword", MySqlDbType.Text);
                    cmd.Parameters["@LePassword"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@LePassword"].Value = SHA.petitsha(txt_box__password.Text);

                    cmd.Parameters.Add("@LevelEntree", MySqlDbType.Int32);
                    cmd.Parameters["@LevelEntree"].Direction = ParameterDirection.Input;
                    cmd.Parameters["@LevelEntree"].Value = LevelUser;


                    cmd.ExecuteNonQuery();

                    dbCon.Close();
                    MessageBox.Show("Employé.e ajouté.e");


                }
                dbCon.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Erreur");
            }
        }

        private void AjoutEmploye_Load(object sender, EventArgs e)
        {
                
        }
    }
}