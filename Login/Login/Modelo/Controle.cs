using Login.Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Modelo
{
  class Controle
  {

    public bool tem;
    public String mensagem = "";

    public bool acessar(String login, String senha)
    {
      LoginComandos loginComand = new LoginComandos();

      tem = loginComand.verificarlogin(login, senha);

      if (!String.IsNullOrEmpty(loginComand.mensagem))
      {
        mensagem = loginComand.mensagem;
      }

      return tem;
    }

    public String cadastrar(String email, String senha, String confSenha)
    {
      return mensagem;
    }

  }
}
