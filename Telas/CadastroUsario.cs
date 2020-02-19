using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaLogin.DAO;
using TelaLogin.Modelos;

namespace TelaLogin.Telas
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {

            InitializeComponent();
        }

        private void btnCadastroCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtCadastroLogin.Text, txtCadastroSenha.Text, txtCadastroSenhaConfirma.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
