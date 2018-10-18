using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;

namespace CamadaDADOS
{
    public class CDLogin
    {
        private CDConexao Conexao = new CDConexao();
        MySqlDataReader reader;

        private String Email, Login, Senha;
        private String Msg;
        MySqlCommand comando = new MySqlCommand();


        public String RecuperarSenha(string idlogin)
        {
            comando.Connection = Conexao.AbrirConexao();
            comando.CommandText = "select * from login where IdLogin=" +idlogin;
            reader = comando.ExecuteReader();

            if (reader.Read() == true)
            {
                Email = reader["Email"].ToString();
                Login = reader["Login"].ToString();
                Senha = reader["Senha"].ToString();

                EnviarEmail();

                Msg = "Caro " + Login + ", a sua senha foi enviada para o seu email " + Email + " Favor verificar!";
                reader.Close();
            }
            else
            { 
                Msg = "Não existem dados!";
            }

            return Msg;

        }


        public void EnviarEmail()
        {
            MailMessage email = new MailMessage();
            email.From = new MailAddress("nilton.nmn@gmail.com");
            email.To.Add(Email);
            email.Subject = ("RECUPERAR SENHA");
            email.Body = "Olá " + Login + ". Você solicitou a sua senha!\n Sua senha é: " + Senha;
            email.Priority = MailPriority.High;

            //SMTP

            SmtpClient ServerMail = new SmtpClient();
            ServerMail.Credentials = new NetworkCredential("nilton.nmn@gmail.com", "moraes9319/");
            ServerMail.Host = "smtp.gmail.com";
            ServerMail.Port = 587;
            ServerMail.EnableSsl = true;

            try
            {
                ServerMail.Send(email);

            }
            catch (Exception ex)
            {

                throw;
            }

            email.Dispose();


        }

        public MySqlDataReader iniciarSessao(string login, string senha)
        {
            string sql = "select * from `itmoraes`.`login` Where Ativo = 1 and Login='" + login + "' and Senha= '" + senha + "'";
            MySqlCommand cmdMySQL = new MySqlCommand();
            cmdMySQL.Connection = Conexao.AbrirConexao();
            cmdMySQL.CommandText = sql;
            reader = cmdMySQL.ExecuteReader();

            return reader;
        }



    }
}
