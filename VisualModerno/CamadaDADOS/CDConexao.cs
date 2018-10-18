using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CamadaDADOS
{
    class CDConexao
    {
        MySqlConnection conMySQL = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=itmoraes;SslMode=none;User Id=root;password=''");
        MySqlCommand cmdMySQL = new MySqlCommand();
        MySqlDataReader reader;

        //cmdMySQL.Connection = conMySQL;


        public MySqlConnection AbrirConexao()
        {
            if (conMySQL.State == System.Data.ConnectionState.Closed)
                conMySQL.Open();
            return conMySQL;
        }

        public MySqlConnection FecharConexao()
        {
            if (conMySQL.State == System.Data.ConnectionState.Open)
                conMySQL.Close();
            return conMySQL;
        }


    }
}
