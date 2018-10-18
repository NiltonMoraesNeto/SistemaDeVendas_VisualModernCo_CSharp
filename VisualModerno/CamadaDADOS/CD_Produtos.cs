using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CamadaDADOS
{
    public class CD_Produtos
    {
        private CDConexao conexao = new CDConexao();
        MySqlDataReader reader;
        DataTable table = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "select * from produtos";
            //comando.CommandType = CommandType.Text;
            reader = comando.ExecuteReader();
            table.Load(reader);
            conexao.FecharConexao();
            return table;
        }


        public void Inserir(string nome, string marca, string descricao, double preco, int estoque)
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "INSERT INTO `itmoraes`.`produtos` (`Nome`,`Marca`,`Descricao`,`Preco`,`Estoque`) VALUES('" + nome+"', '" +marca+"', '"+descricao+"', "+preco+", "+estoque+")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nome, string marca, string descricao, double preco, int estoque, int id)
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "UPDATE `itmoraes`.`produtos`SET `Nome` ='" + nome + "' ,`Marca` ='" + marca + "' ,`Descricao` ='" + descricao + "' ,`Preco` = " + preco + " ,`Estoque` = " + estoque + " WHERE `IdProduto` = " + id;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Deletar(int id)
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "DELETE FROM `itmoraes`.`produtos` WHERE `IdProduto` = " +id;
            //comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }



    }
}
