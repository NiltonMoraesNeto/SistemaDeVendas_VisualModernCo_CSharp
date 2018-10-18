using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(null, e);
            PrivilegioUsuario();
            MostrarUsuarioAtivo();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PrivilegioUsuario()
        {

            //Desabilitar o Botão
            if (Program.Cargo != "Administrador")
            {
                btnProduto.Enabled = false;
                btnCompra.Enabled = false;
                btnVenda.Enabled = false;
                btnCliente.Enabled = false;
                btnCompra.Enabled = false;
                btnFuncionario.Enabled = false;
                btnPagamento.Enabled = false;
                btnRelatório.Enabled = false;
            }

            //Ocultar Botão
            //if (Program.Cargo != "Administrador")
            //{
            //    btnProduto.Visible = false;
            //    btnCompra.Visible = false;
            //    btnVenda.Visible = false;
            //    btnCliente.Visible = false;
            //    btnCompra.Visible = false;
            //    btnFuncionario.Visible = false;
            //    btnPagamento.Visible = false;
            //    btnRelatório.Visible = false;
            //}
        }

        private void MostrarUsuarioAtivo()
        {
            labelNome.Text = Program.Login;
            labelEmail.Text = Program.Email;
            labelCargo.Text = Program.Cargo;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRes.Visible = true;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRes.Visible = false;
            btnMaximizar.Visible = true;            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void btnRelatório_Click(object sender, EventArgs e)
        {
            subMenuRelatorio.Visible = true;
        }

        private void btnRelatorioVEnda_Click(object sender, EventArgs e)
        {
            subMenuRelatorio.Visible = false;
        }

        private void btnRelatorioCompra_Click(object sender, EventArgs e)
        {
            subMenuRelatorio.Visible = false;
        }

        private void btnRelatoriPagamento_Click(object sender, EventArgs e)
        {
            subMenuRelatorio.Visible = false;
        }

        private void AbrirForm(object abrirform)
        {
            if (this.panelCENTRO.Controls.Count > 0)
                this.panelCENTRO.Controls.RemoveAt(0);

            Form f = abrirform as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelCENTRO.Controls.Add(f);
            this.panelCENTRO.Tag = f;
            f.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            //if (Program.Cargo == "Administrador")

                AbrirForm(new Produtos());

            //else
            //    MessageBox.Show("Você não tem permissão para acessar essa opção");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Inicio());
        }
    }
}
