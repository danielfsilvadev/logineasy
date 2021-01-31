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

      /*Abaixo temos a string de conexação com a base de dados.
      Substitua os asteríscos pelo nome da sua máquina ou nome da sua instancia SQL válida.*/ 

      con.ConnectionString = @"Data Source= **********;Initial Catalog=Sistema;Integrated Security=True";

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
