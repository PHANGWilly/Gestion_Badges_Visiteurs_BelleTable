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
        public int Id { get; set; }
        public string Identifiant { get; set; }
        public int Level { get; set; }
    }
}
