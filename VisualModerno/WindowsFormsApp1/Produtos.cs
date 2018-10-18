using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNEGOCIOS;

namespace WindowsFormsApp1
{
    public partial class Produtos : Form
    {

        CN_Produtos objetoCN = new CN_Produtos();
        private string idProduto = null;
        private bool Editar = false;

        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            Privilegio();
            MostrarProdutos();
        }

        private void Privilegio()
        {
            if (Program.Cargo != "Administrador")
            {
                btnSalvar.Visible = false;
            }
        }


        private void MostrarProdutos()
        {
            dataGridView1.DataSource = objetoCN.MostrarProdutos();


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Editar == false)
            {

                try
                {

                    objetoCN.InserirProduto(txtNome.Text, txtMarca.Text, txtDescricao.Text, txtPreco.Text, txtEstoque.Text);
                    MessageBox.Show("Produto salvo com Sucesso!");
                    MostrarProdutos();
                    Limpar();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao SALVAR o Produto! MOTIVO: " + ex);
                }
            }

            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarProduto(txtNome.Text, txtMarca.Text, txtDescricao.Text, txtPreco.Text, txtEstoque.Text, idProduto);
                    MessageBox.Show("Produto EDITADO com Sucesso!");
                    MostrarProdutos();
                    Limpar();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao EDITAR o Produto! MOTIVO: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNome.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDescricao.Text = dataGridView1.CurrentRow.Cells["Descricao"].Value.ToString();
                txtPreco.Text = dataGridView1.CurrentRow.Cells["Preco"].Value.ToString();
                txtEstoque.Text = dataGridView1.CurrentRow.Cells["Estoque"].Value.ToString();
                idProduto = dataGridView1.CurrentRow.Cells["IdProduto"].Value.ToString();
            }
            else
                MessageBox.Show("Selecione uma línha");
        }

        private void Limpar()
        {
            txtNome.Clear();
            txtMarca.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                idProduto = dataGridView1.CurrentRow.Cells["IdProduto"].Value.ToString();
                objetoCN.DeletarProduto(idProduto);
                MessageBox.Show("Produto DELETADO com sucesso");
                MostrarProdutos();
            }
            else
                MessageBox.Show("Selecione uma línha");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Estoque")
            {

                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {

                        if (Convert.ToInt32(e.Value) <= 9999999)
                        {
                            e.CellStyle.ForeColor = Color.Green;
                            //e.CellStyle.BackColor = Color.Green;

                            if (Convert.ToInt32(e.Value) <= 20)
                            {
                                e.CellStyle.ForeColor = Color.Yellow;
                                //e.CellStyle.BackColor = Color.Gray;
                            }
                            if (Convert.ToInt32(e.Value) <= 10)
                            {
                                e.CellStyle.ForeColor = Color.Orange;
                                //e.CellStyle.BackColor = Color.Gray;
                            }
                            if (Convert.ToInt32(e.Value) <= 5)
                            {
                                e.CellStyle.ForeColor = Color.Red;
                                //e.CellStyle.BackColor = Color.Gray;
                            }
                        }
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("" + ex);
                }

            }

        }
    }
}
