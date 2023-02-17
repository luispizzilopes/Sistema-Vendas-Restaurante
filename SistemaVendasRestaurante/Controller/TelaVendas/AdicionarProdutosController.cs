using SistemaVendasRestaurante.Models.TelaVendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Controller.TelaVendas
{
    internal class AdicionarProdutosController
    {
        AdicionarProdutosModel adicionar = new AdicionarProdutosModel(); 
        public double? AdicionarProduto(string nome, int quantidade)
        {
            if (adicionar.AdicionarProduto(nome, quantidade) != null)
            {
                return adicionar.AdicionarProduto(nome, quantidade);
            }
            else
            {
                return null; 
            }
        }
    }
}
