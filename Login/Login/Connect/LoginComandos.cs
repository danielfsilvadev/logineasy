using Login.Apresentacao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Connect
{
  class LoginComandos
  {

    public bool tem;
    public String mensagem;
    SqlCommand cmd = new SqlCommand();
    Conexao con = new Conexao();
    SqlDataReader dr;

    public bool verificarlogin(String login, String senha)
    {

      //comandos sql para verificar se tem no banco de dados

      cmd.CommandText = "select * from logins where email = @login and senha = @senha";
      cmd.Parameters.AddWithValue("@login", login);
      cmd.Parameters.AddWithValue("@senha", senha);

      try
      {
        cmd.Connection = con.conectar();
        dr = cmd.ExecuteReader();

        if (dr.HasRows) // verifica se existem dados
        {
          tem = true;
        }
      }
      catch (SqlException)
      {

        this.mensagem = "Erro de Banco de Dados!";
      }

      return tem;
    }


    public String cadastrar(String email, String senha, String ConfSenha)
    {
      //comandos para inserir

      DadosUsuario usu = new DadosUsuario();

      /*  string senhadigitada = usu.txtDSenha.Text;
        string confdigitada = usu.txtDConfirma.Text;

        if (senhadigitada == confdigitada)
        {*/

      cmd.CommandText = @"insert into logins values ('" + @email + "', '" + @senha + "')";
      cmd.Parameters.AddWithValue("@email", email);
      cmd.Parameters.AddWithValue("@senha", senha);

      cmd.Connection = con.conectar();
      dr = cmd.ExecuteReader();

      if (dr.RecordsAffected >= 1)
      {
        MessageBox.Show("Usuário incluído com sucesso!");
      }
      //}
      else
      {
        MessageBox.Show("Erro ao incluir informações no banco de dados");

      }


      return mensagem;
    }

  }
}
