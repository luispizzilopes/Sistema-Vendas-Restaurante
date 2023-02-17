using SistemaVendasRestaurante.Models.TelaCadastrarProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Controller.TelaCadastrarProduto
{
    internal class BuscarProdutoController
    {
        BuscarProdutoModel buscar = new BuscarProdutoModel();

        public string[] BuscarProduto(string nome)
        {
            if(buscar.BuscarProduto(nome) != null)
            {
                return buscar.BuscarProduto(nome);
            }
            else
            {
                return null; 
            }
        }
    }
}
