using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaLogin.DAO;

namespace TelaLogin.Modelos
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDAO logindao = new LoginDAO();
            tem = logindao.verificarLogin(login, senha);
            if (!logindao.mensagem.Equals(""))
            {
                this.mensagem = logindao.mensagem;
            }
            return tem;
        }
        public string cadastrar(String login, String senha, String confSenha)
        {
            LoginDAO loginDAO = new LoginDAO();
            this.mensagem = loginDAO.cadastrar(login, senha, confSenha);
            if (loginDAO.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
