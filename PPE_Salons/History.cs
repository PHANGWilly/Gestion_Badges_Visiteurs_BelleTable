using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PPE_Salons
{
    public class History
    {
        public int id { get; set; }
        public string debut { get; set; }
        public string fin { get; set; }
        public int IdUtilisateur { get; set; }

        public void Save()
        {
            if (id > 0)
                UpdateHistorique();
            else AddHistorique();
        }

        private void UpdateHistorique()
        {
            try
            {
                DateTime fin = DateTime.Now;
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                dbCon.DatabaseName = "PPE_Willy";
                dbCon.UserName = "admin";
                dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    String sqlString = "UPDATE Historique SET fin = ?h_fin WHERE Id = ?h_id";
                    sqlString = Tools.PrepareLigne(sqlString, "?h_id", Tools.PrepareChamp(id.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?h_fin", Tools.PrepareChamp(fin.ToString("F"), "Chaine"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
        }

        private void AddHistorique()
        {
            try
            {
                DateTime debut = DateTime.Now;

                id = AppelerProcedureStockeeHistorique();
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                dbCon.DatabaseName = "PPE_Willy";
                dbCon.UserName = "admin";
                dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    String sqlString = "INSERT INTO historique (id, debut, id_user) VALUES(?h_id, ?h_debut, ?user_id)";
                    sqlString = Tools.PrepareLigne(sqlString, "?h_id", Tools.PrepareChamp(id.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?h_debut", Tools.PrepareChamp(debut.ToString("F"), "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?user_id", Tools.PrepareChamp(IdUtilisateur.ToString(), "Chaine"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }

        }

        private int AppelerProcedureStockeeHistorique()
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                dbCon.DatabaseName = "PPE_Willy";
                dbCon.UserName = "admin";
                dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                int Identifiant = -1;
                if (dbCon.IsConnect())
                {
                    String sqlString = "GiveIdHistorique";
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.CommandType = CommandType.StoredProcedure; //Il faut System.Data pour cette ligne

                    cmd.Parameters.Add("@TheID", MySqlDbType.Int32);
                    cmd.Parameters["@TheID"].Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    Identifiant = (int)cmd.Parameters["@TheID"].Value;
                    dbCon.Close();
                    return Identifiant + 1;
                }
                dbCon.Close();
                return -1;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return -1;
            }
        }
    }

    
}
