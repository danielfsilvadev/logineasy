using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Connect
{
  public class Conexao
  {

    SqlConnection con = new SqlConnection();
    public Conexao()
    {

      /*Abaixo temos a string de conexão com a base de dados. Após restaurar o bkp da base de dados, chamado Sistema,
      que também está disponível nos arquivo do GitHuB, substitua os asteriscos abaixo pelo nome da sua máquina
      ou instância SQL válida e faça a conexaão com a base de dados através do menu Tool>Conncet to Database */

      con.ConnectionString = @"Data Source=**********;Initial Catalog=Sistema;Integrated Security=True";

    }

    public SqlConnection conectar()
    {
      if (con.State == System.Data.ConnectionState.Closed)
      {
        con.Open();
      }

      return con;

    }

    public void desconectar()
    {
      if (con.State == System.Data.ConnectionState.Open)
      {
        con.Open();
      }
    }

  }
}
