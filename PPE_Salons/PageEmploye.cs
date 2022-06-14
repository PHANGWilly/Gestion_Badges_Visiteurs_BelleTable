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
    public partial class PageEmploye : Form
    {
        Employe LeEmploye;
        public string TypeConnexion;
        public int IdUtilisateur;
        public int LevelUtilisateur; 
        public int Level;
        public int NbConnexion;
        private Employe unEmploye;

        public PageEmploye(int Lid, int LeLevel, Employe UnEmploye, string TypeConn, int NbConn)
        {
            InitializeComponent();
            IdUtilisateur = Lid;
            LevelUtilisateur = LeLevel;
            TypeConnexion = TypeConn;
            NbConnexion = NbConn;

            LeEmploye = UnEmploye;
            txt_box__identifiant.Text = UnEmploye.Identifiant;
            txt_box__password.Text = UnEmploye.Password;
            combo_box__level.ValueMember = UnEmploye.Level.ToString();
        }

        public PageEmploye(Employe UnEmploye, string TypeConn)
        {
            InitializeComponent();
            LeEmploye = UnEmploye;
            txt_box__identifiant.Text = UnEmploye.Identifiant;
            combo_box__level.SelectedItem = UnEmploye.Level.ToString();
            TypeConnexion = TypeConn;
        }
        private void click__btn__to_retour(object sender, EventArgs e)
        {
            this.Close();
            
            PageAdmin MonFormPageAdmin = new PageAdmin(IdUtilisateur, LevelUtilisateur, TypeConnexion, NbConnexion);
            MonFormPageAdmin.Show();
        }

        private void click__btn_add(object sender, EventArgs e)//enregistre un employe
        {
            if(TypeConnexion == "1" )//connexion distante
            {
                bool IsOK = true;

                ComboValue MaComboValue = (ComboValue)combo_box__level.SelectedItem;
                Level = int.Parse(MaComboValue.Value);

                if (txt_box__identifiant.Text.Length == 0)
                {
                    IsOK = false;
                }
                else LeEmploye.Identifiant = txt_box__identifiant.Text;

                if (txt_box__password.Text.Length == 0)
                {
                    IsOK = false;
                }
                else LeEmploye.Password = txt_box__password.Text;

                LeEmploye.Level = Level;
                if (IsOK)
                {
                    LeEmploye.SaveD();

                    MessageBox.Show("Employé.e enregisté.e !");

                    txt_box__identifiant.Text = "";
                    txt_box__password.Text = "";
                }
            }
            else if(TypeConnexion == "2")//connexion locale
            {
                bool IsOK = true;

                ComboValue MaComboValue = (ComboValue)combo_box__level.SelectedItem;
                Level = int.Parse(MaComboValue.Value);

                if (txt_box__identifiant.Text.Length == 0)
                {
                    IsOK = false;
                }
                else LeEmploye.Identifiant = txt_box__identifiant.Text;

                if (txt_box__password.Text.Length == 0)
                {
                    IsOK = false;
                }
                else LeEmploye.Password = txt_box__password.Text;

                LeEmploye.Level = Level;
                if (IsOK)
                {
                    LeEmploye.SaveL();

                    MessageBox.Show("Employé.e enregisté.e !");

                    txt_box__identifiant.Text = "";
                    txt_box__password.Text = "";
                }
            }
            

        }

        private void AjoutEmploye_Load(object sender, EventArgs e)
        {
            lbl__msg.Text = " ";

            var ComboLevelSource = new List<ComboValue>();
            ComboLevelSource.Add(new ComboValue() { Name = "Admin", Value = "2" });
            ComboLevelSource.Add(new ComboValue() { Name = "Employé.e", Value = "1" });

            combo_box__level.DataSource = ComboLevelSource;
            combo_box__level.DisplayMember = "Name"; //ce qui va s'afficher
            combo_box__level.ValueMember = "Value"; // ce qui va s'envoyer
        }
    }
}