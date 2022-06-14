using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.IO;

namespace PPE_Salons
{
    public partial class PageParticipant : Form
    {
        public string TypeConnexion = "";
        Contact LeParticipant;
        public PageParticipant(Contact unParticipant, string TypeConn)
        {
            InitializeComponent();
            LeParticipant = unParticipant;
            tbNom.Text = unParticipant.Nom;
            tbPrenom.Text = unParticipant.Prenom;
            tbemail.Text = unParticipant.Email;
            TypeConnexion = TypeConn;
        }

        private void PageParticipant_Load(object sender, EventArgs e)
        {
            Error1.Text = "";
            Error2.Text = "";
            Error3.Text = "";
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            if(TypeConnexion == "1")//connexion distante
            {
                Error1.Text = "";
                Error2.Text = "";
                Error3.Text = "";
                bool IsOK = true;
                if (tbNom.Text.Length == 0)
                {
                    Error1.Text = "Le Nom ne peut être vide";
                    IsOK = false;
                }
                else LeParticipant.Nom = tbNom.Text;
                if (tbPrenom.Text.Length == 0)
                {
                    Error2.Text = "Le Prénom ne peut être vide";
                    IsOK = false;
                }
                else
                    LeParticipant.Prenom = tbPrenom.Text;

                if (MesOutils.VeriferMail(tbemail.Text))
                    LeParticipant.Email = tbemail.Text;
                else
                {
                    Error3.Text = "email incorrect";
                    IsOK = false;
                }
                if (IsOK)
                    LeParticipant.SaveD();
                Error3.Text = "Enregistrement effectué";
            }
            else if(TypeConnexion =="2")//connexion locale
            {
                Error1.Text = "";
                Error2.Text = "";
                Error3.Text = "";
                bool IsOK = true;
                if (tbNom.Text.Length == 0)
                {
                    Error1.Text = "Le Nom ne peut être vide";
                    IsOK = false;
                }
                else LeParticipant.Nom = tbNom.Text;
                if (tbPrenom.Text.Length == 0)
                {
                    Error2.Text = "Le Prénom ne peut être vide";
                    IsOK = false;
                }
                else
                    LeParticipant.Prenom = tbPrenom.Text;

                if (MesOutils.VeriferMail(tbemail.Text))
                    LeParticipant.Email = tbemail.Text;
                else
                {
                    Error3.Text = "email incorrect";
                    IsOK = false;
                }
                if (IsOK)
                    LeParticipant.SaveL();
                Error3.Text = "Enregistrement effectué";
            }
            
        }

        private void button1_Click(object sender, EventArgs e) //generer le QR
        {
            if(TypeConnexion == "1") //connexion distante
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                String QRBrut = LeParticipant.Prenom + " " + LeParticipant.Nom;
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRBrut, QRCodeGenerator.ECCLevel.Q);

                Base64QRCode qrCode = new Base64QRCode(qrCodeData);
                string qrCodeImageAsBase64 = qrCode.GetGraphic(20);

                StreamWriter monStreamWriter = new StreamWriter(@"C:\Temp\BadgeSalon_" + LeParticipant.Nom + "_" + LeParticipant.Prenom + ".html");//Necessite using System.IO;

                String strImage = " <img src = \"data:image/png;base64," + qrCodeImageAsBase64 + "\">";
                monStreamWriter.WriteLine("<html>");
                monStreamWriter.WriteLine("<head>");
                monStreamWriter.WriteLine("<link rel='stylesheet' href='BadgeSalon.css'>");
                monStreamWriter.WriteLine("</head>");
                monStreamWriter.WriteLine("<body>");
                String TempText = "<div class='infos'>";
                monStreamWriter.WriteLine(TempText);
                TempText = "<p class='id'>ID : " + LeParticipant.Id + "</p>";
                monStreamWriter.WriteLine(TempText);
                TempText = "<p class='nom'>Nom : " + LeParticipant.Nom + "</p>";
                monStreamWriter.WriteLine(TempText);
                TempText = "<p class='prenom'>Prénom : " + LeParticipant.Prenom + "</p></div>";
                monStreamWriter.WriteLine(TempText);

                monStreamWriter.WriteLine(strImage);    //Ecriture de l'image base 64 dans le fichier
                monStreamWriter.WriteLine("</body>");
                monStreamWriter.WriteLine("</html>");

                // Fermeture du StreamWriter (Très important) 
                monStreamWriter.Close();
                System.Diagnostics.Process.Start("Chrome", @"C:\Temp\BadgeSalon_"+ LeParticipant.Id + "_" + LeParticipant.Nom + "_" + LeParticipant.Prenom + ".html");
                MessageBox.Show("Badge généré");
            }
            else if(TypeConnexion == "2") //connexion locale
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                String QRBrut = LeParticipant.Prenom + " " + LeParticipant.Nom;
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRBrut, QRCodeGenerator.ECCLevel.Q);

                Base64QRCode qrCode = new Base64QRCode(qrCodeData);
                string qrCodeImageAsBase64 = qrCode.GetGraphic(20);

                StreamWriter monStreamWriter = new StreamWriter(@"C:\Temp\BadgeSalon_" + LeParticipant.Nom + "_" + LeParticipant.Prenom + ".html");//Necessite using System.IO;

                String strImage = " <img src = \"data:image/png;base64," + qrCodeImageAsBase64 + "\">";
                monStreamWriter.WriteLine("<html>");
                monStreamWriter.WriteLine("<head>");
                monStreamWriter.WriteLine("<link rel='stylesheet' href='BadgeSalon.css'>");
                monStreamWriter.WriteLine("</head>");
                monStreamWriter.WriteLine("<body>");
                String TempText = "<div class='infos'>";
                monStreamWriter.WriteLine(TempText);
                TempText = "<p class='id'>ID : " + LeParticipant.Id + "</p>";
                monStreamWriter.WriteLine(TempText);
                TempText = "<p class='nom'>Nom : " + LeParticipant.Nom + "</p>";
                monStreamWriter.WriteLine(TempText);
                TempText = "<p class='prenom'>Prénom : " + LeParticipant.Prenom + "</p></div>";
                monStreamWriter.WriteLine(TempText);

                monStreamWriter.WriteLine(strImage);    //Ecriture de l'image base 64 dans le fichier
                monStreamWriter.WriteLine("</body>");
                monStreamWriter.WriteLine("</html>");
               
                // Fermeture du StreamWriter (Très important) 
                monStreamWriter.Close();
                System.Diagnostics.Process.Start("Chrome", @"C:\Temp\BadgeSalon_"+ LeParticipant.Nom + "_" + LeParticipant.Prenom + ".html");
                MessageBox.Show("Badge généré");
            }
            
        }
    }
}
