using SistemaVendasRestaurante.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Models.Login
{
    internal class LoginModel
    {
        ConexaoBd conexao = new ConexaoBd(); 

        public bool Acessar(string usuario, string senha)
        {
            conexao.StrSql = "select * from TabelaLogin where usuario = @usuario and senha = @senha"; 
            SqlCommand comandos = new SqlCommand(conexao.StrSql, conexao.Conectar());
            comandos.Parameters.Add("usuario", System.Data.SqlDbType.VarChar).Value = usuario;
            comandos.Parameters.Add("senha", System.Data.SqlDbType.VarChar).Value = senha;
            try
            {
                SqlDataReader dataReader = comandos.ExecuteReader();
                if(dataReader.HasRows == true)
                {
                    return true; 
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
