using SistemaVendasRestaurante.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
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
            finally { conexao.Desconectar(); }
        }

        public bool VerificarUsuario(string usuario)
        {
            conexao.StrSql = "select * from TabelaLogin where usuario = @usuario";
            SqlCommand comandos = new SqlCommand(conexao.StrSql, conexao.Conectar());
            comandos.Parameters.Add("usuario", System.Data.SqlDbType.VarChar).Value = usuario;
            try
            {
                using(SqlDataReader dataReader = comandos.ExecuteReader()) 
                {
                    if(dataReader.HasRows != true) 
                    { 
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool Cadastrar(string usuario, string senha)
        {
            if(VerificarUsuario(usuario) == true)
            {
                conexao.StrSql = "insert into TabelaLogin values (@usuario, @senha)";
                SqlCommand comandos = new SqlCommand(conexao.StrSql, conexao.Conectar()); 
                comandos.Parameters.Add("usuario", System.Data.SqlDbType.VarChar).Value = usuario;
                comandos.Parameters.Add("senha", System.Data.SqlDbType.VarChar).Value = senha;
                try
                {
                    comandos.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
            else
            {
                return false; 
            }
        }
    }
}
