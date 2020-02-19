using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin.DAO
{
    class LoginDAO
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from login where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                    con.Desconectar();
                    dr.Close();
                }
            }
            catch (SqlException)
            {

                this.mensagem = "ops aconteceu algum erro no banco de dados";
            }
            return tem;
        }
        public String cadastrar(String login, String senha, String confSenha)
        {
            tem = false;
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into login values (@l, @s)";
                cmd.Parameters.AddWithValue("@l", login);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro ao acessar o Banco de Dados";
                }
            }else
            {
                this.mensagem = "Obs: as duas senhas tem que ser IGUAIS!!";
            }

            return mensagem;
        }
    }
}
