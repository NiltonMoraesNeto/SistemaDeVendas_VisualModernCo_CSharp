using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using CamadaDADOS;

namespace CamadaNEGOCIOS
{
    public class CN_Produtos
    {
        private CD_Produtos objetoCD = new CD_Produtos();
        
        public DataTable MostrarProdutos()
        {
            DataTable table = new DataTable();
            table = objetoCD.Mostrar();

            return table;
        }


        public void InserirProduto (string nome, string marca, string descricao, string preco, string estoque)
        {
            objetoCD.Inserir(nome, marca, descricao, Convert.ToDouble(preco), Convert.ToInt32(estoque));
        }

        public void EditarProduto(string nome, string marca, string descricao, string preco, string estoque, string id)
        {
            objetoCD.Editar(nome, marca, descricao, Convert.ToDouble(preco), Convert.ToInt32(estoque), Convert.ToInt32(id));
        }

        public void DeletarProduto(string id)
        {
            objetoCD.Deletar(Convert.ToInt32(id));
        }

    }
}
