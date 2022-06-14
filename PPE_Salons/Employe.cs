using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PPE_Salons
{
    public class Employe
    {
        public string TypeConnexion = "";

        public int Id { get; set; }
        public string Identifiant { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }


        public void SaveD() //connexion distante
        {
            if (Id > 0)
                UpdateEmployeD();
            else AjouterEmployeD();
        }

        public bool SupprimerD() //connexion distante
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                dbCon.DatabaseName = "PPE_Willy";
                dbCon.UserName = "admin";
                dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    String sqlString = "DELETE FROM user  WHERE id = ?id_E";
                    sqlString = Tools.PrepareLigne(sqlString, "?id_E", Tools.PrepareChamp(Id.ToString(), "Nombre"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return false;
            }
        }

        private void UpdateEmployeD() //connexion distante
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                dbCon.DatabaseName = "PPE_Willy";
                dbCon.UserName = "admin";
                dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    String sqlString = "UPDATE user SET identifiant = ?identifiant, password = ?password, level = ?level WHERE Id = ?id_user";
                    sqlString = Tools.PrepareLigne(sqlString, "?id_user", Tools.PrepareChamp(Id.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?identifiant", Tools.PrepareChamp(Identifiant, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?password", Tools.PrepareChamp(SHA.petitsha(Password), "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?level", Tools.PrepareChamp(Level.ToString(), "Nombre"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
        }

        private void AjouterEmployeD() //connexion distante
        {
            try
            {
                Id = AppelerProcedureStockeeEmployeD();
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "ppebelletablecerfal.chaisgxhr4z6.eu-west-3.rds.amazonaws.com";
                dbCon.DatabaseName = "PPE_Willy";
                dbCon.UserName = "admin";
                dbCon.Password = Crypto.Decrypt("tr9y0URXywxHt1XgTEn4yg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    String sqlString = "INSERT INTO user (id , identifiant , password, level, , Nb_Conn, Date_Derniere_Conn) VALUES(?id,?Identifiant,?Password, ?Level , ?Nb_Conn, ?Date_Derniere_Conn)";
                    sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(Id.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Identifiant", Tools.PrepareChamp(Identifiant, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Password", Tools.PrepareChamp(SHA.petitsha(Password), "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Level", Tools.PrepareChamp(Level.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Nb_Conn", Tools.PrepareChamp(0.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Date_Derniere_Conn", Tools.PrepareChamp("***", "Chaine"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }

        }

        private int AppelerProcedureStockeeEmployeD() //connexion distante
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
                    String sqlString = "GiveIdEmploye";
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

        /*
         * 
         *CONNEXION LOCALE 
         *
         */

        public void SaveL() //connexion Locale
        {
            if (Id > 0)
                UpdateEmployeL();
            else AjouterEmployeL();
        }

        public bool SupprimerL() //connexion Locale
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "ppe";
                dbCon.UserName = "ClientLourd";
                dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    String sqlString = "DELETE FROM user  WHERE id = ?id_E";
                    sqlString = Tools.PrepareLigne(sqlString, "?id_E", Tools.PrepareChamp(Id.ToString(), "Nombre"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return false;
            }
        }

        private void UpdateEmployeL() //connexion Locale
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "ppe";
                dbCon.UserName = "ClientLourd";
                dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    String sqlString = "UPDATE user SET identifiant = ?identifiant, password = ?password, level = ?level WHERE Id = ?id_user";
                    sqlString = Tools.PrepareLigne(sqlString, "?id_user", Tools.PrepareChamp(Id.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?identifiant", Tools.PrepareChamp(Identifiant, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?password", Tools.PrepareChamp(SHA.petitsha(Password), "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?level", Tools.PrepareChamp(Level.ToString(), "Nombre"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
        }

        private void AjouterEmployeL() //connexion locale
        {
            try
            {
                Id = AppelerProcedureStockeeEmployeL();
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "ppe";
                dbCon.UserName = "ClientLourd";
                dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
                string dateco = "***";
                if (dbCon.IsConnect())
                {
                     
                    String sqlString = "INSERT INTO user (id , identifiant , password, level, Nb_Conn, Date_Derniere_Conn) VALUES(?id,?Identifiant,?Password, ?Level, ?Nb_Conn, ?Date_Derniere_Conn)";
                    sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(Id.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Identifiant", Tools.PrepareChamp(Identifiant, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Password", Tools.PrepareChamp(SHA.petitsha(Password), "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Level", Tools.PrepareChamp(Level.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Nb_Conn", Tools.PrepareChamp(0.ToString(), "Nombre"));
                    sqlString = Tools.PrepareLigne(sqlString, "?Date_Derniere_Conn", Tools.PrepareChamp(dateco, "Chaine"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }

        }

        private int AppelerProcedureStockeeEmployeL() //connexion locale
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "ppe";
                dbCon.UserName = "ClientLourd";
                dbCon.Password = Crypto.Decrypt("eqmNIlqzbB/Tn8Ld1T1fkXofwKCMVzfz");//Pour éviter d'afficher le mot de passe en clair dans le code
                int Identifiant = -1;
                if (dbCon.IsConnect())
                {
                    String sqlString = "GiveIdEmploye";
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
