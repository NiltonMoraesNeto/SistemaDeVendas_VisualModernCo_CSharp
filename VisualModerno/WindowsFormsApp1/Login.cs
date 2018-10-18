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
using CamadaNEGOCIOS;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUÁRIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUÁRIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.DimGray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            CNLogin objLogin = new CNLogin();
            MySqlDataReader reader;

            objLogin.Login = txtUsuario.Text;
            objLogin.Senha = txtSenha.Text;

            reader = objLogin.IniciarSessao();

            if(reader.Read() == true)
            {
                this.Hide();
                Form1 f = new Form1();
                Program.Cargo = reader["Cargo"].ToString();
                Program.Login = reader["Login"].ToString();
                Program.Email = reader["Email"].ToString();
                f.Show();
            }
            else
            {

                labelUsuarioErro.Text = "Usuário/Senha Inválido ou Inativo! Tente de Novo!";
                labelUsuarioErro.Visible = true;
                txtSenha.Text = "";
                txtSenha_Leave(null, e);
                txtUsuario.Text = "";
                txtUsuario_Leave(null, e);
                txtUsuario.Focus();

                //MessageBox.Show("Login ou Senha Incorretos!");

            }
        }

        private void linkRecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarSenha f = new FormRecuperarSenha();
            f.ShowDialog();
        }
    }
}
