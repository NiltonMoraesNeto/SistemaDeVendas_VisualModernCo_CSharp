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
    public partial class FormRecuperarSenha : Form
    {
        public FormRecuperarSenha()
        {
            InitializeComponent();
        }

        CNLogin objCN = new CNLogin();

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            txtMSG.Text = objCN.RecuPass(txtID.Text);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }
    }
}
