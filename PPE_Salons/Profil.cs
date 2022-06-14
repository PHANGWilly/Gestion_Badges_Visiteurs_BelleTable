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
    public partial class Profil : Form
    {
        public int IdUtilisateur;
        public int LevelUtilisateur;
        public int NbConnexion;
        public Profil(int Lid, int LeLevel, int NbConn)
        {
            IdUtilisateur = Lid;
            LevelUtilisateur = LeLevel;
            NbConnexion = NbConn;
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            lbl__nb_con_nb.Text = NbConnexion.ToString();
        }

        private void click__btn__come_back(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
