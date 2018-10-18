using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDADOS;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CamadaNEGOCIOS
{
    public class CNLogin
    {

        private CDLogin objDato = new CDLogin();

        private String _Login;
        private String _Senha;

        public String Login
        {
            get { return _Login; }
            set { _Login = value; }
        }
        public String Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }
        public CNLogin()
        {

        }

        public MySqlDataReader IniciarSessao()
        {
            MySqlDataReader reader;
            reader = objDato.iniciarSessao(Login, Senha);

            return reader;
        }

        public string RecuPass(string idlogin)
        {
            string msg;
            msg = objDato.RecuperarSenha(idlogin);

            return msg;

        }


    }
}
