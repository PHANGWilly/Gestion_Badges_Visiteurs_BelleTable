using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Salons
{
    class Date
    {
        private int jour = 1;  // Valeur par défaut
        public int Jour
        {
            get
            {
                return jour;
            }
            set
            {
                if ((value > 0) && (value < 32))
                {
                    jour = value;
                }
            }
        }
        private int mois = 7;  // Valeur par défaut
        public int Mois
        {
            get
            {
                return mois;
            }
            set
            {
                if ((value > 0) && (value < 13))
                {
                    mois = value;
                }
            }
        }
        private int annee = 2021;  // Valeur par défaut
        public int Annee
        {
            get
            {
                return annee;
            }
            set
            {
                if ((value > 0) && (value <= 2021))
                {
                    annee = value;
                }
            }
        }
        public Date(int LeJour, int LeMois, int Lannee)
        {
            if ((LeJour > 0) && (LeJour < 32))
            {
                jour = LeJour;
            }
            if ((LeMois > 0) && (LeMois < 13))
            {
                mois = LeMois;
            }
            if ((Lannee > 0) && (Lannee <= 2023))
            {
                annee = Lannee;
            }
        }

        public String LaDateToString()
        {
            return jour.ToString() + "/" + mois.ToString() + "/" + annee.ToString();
        }

        public static int LeJour()
        {
            return DateTime.Now.Day;
        }
        public static int LeMois()
        {
            return DateTime.Now.Month;
        }
        public static int Lannee()
        {
            return DateTime.Now.Year;
        }

        public static int LeHeure()
        {
            return DateTime.Now.Hour;
        }

        public static int LeMinute()
        {
            return DateTime.Now.Minute;
        }

        public static string RetournerDateFrancais()
        {
            return DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + " à " + DateTime.Now.Hour.ToString() + "h" + DateTime.Now.Minute.ToString(); 
        }
    }
}
