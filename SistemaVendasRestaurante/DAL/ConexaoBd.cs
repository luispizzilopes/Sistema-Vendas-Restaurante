using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.DAL
{
    internal class ConexaoBd
    {
        SqlConnection conexao = new SqlConnection();
        private string StrConexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BdVendasRestaurante;Data Source=DESKTOP-JFDDBJK\SQLEXPRESS"; 
        public string? StrSql = null; 

        public ConexaoBd() 
        {
            conexao.ConnectionString = StrConexao; 
        }

        public SqlConnection Conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }

            return conexao;
        }

        public void Desconectar()
        {
            conexao.Close();
        }
    }
}
