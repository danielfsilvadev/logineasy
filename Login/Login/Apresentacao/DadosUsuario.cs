using Login.Connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Apresentacao
{
  public partial class DadosUsuario : Form
  {
    public DadosUsuario()
    {
      InitializeComponent();
    }

    private void DadosUsuario_Load(object sender, EventArgs e)
    {

    }

    private void txtDSenha_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnCadastrarUsuario_Click(object sender, EventArgs e)
    {
      LoginComandos cadastra = new LoginComandos();

      string senhadigitada = txtDSenha.Text;
      string confdigitada = txtDConfirma.Text;

      if (senhadigitada == confdigitada)
      {

        cadastra.cadastrar(txtDLogin.Text, txtDSenha.Text, txtDConfirma.Text);

      }
      else
      {
        MessageBox.Show("Senhas não conferem");
      }
    }
  }
}

