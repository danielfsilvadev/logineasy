using Login.Apresentacao;
using Login.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnAcesso_Click(object sender, EventArgs e)
    {
      DadosUsuario cad = new DadosUsuario();
      cad.Show();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
      Controle controle = new Controle();
      controle.acessar(campoUsuario.Text, campoSenha.Text);

      if (controle.mensagem.Equals(""))
      {

        if (controle.tem)
        {

          MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
          TelaInicial ti = new TelaInicial();
          this.Hide();
          ti.Show();

        }
        else
        {
          MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      }
      else
      {
        MessageBox.Show(controle.mensagem);
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void campoUsuario_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
