using SistemaVendasRestaurante.Models.TelaCadastrarProduto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Controller.TelaCadastrarProduto
{
    internal class EditarProdutoController
    {
        EditarProdutoModel editar = new EditarProdutoModel();

        public bool EditarProduto(string nome, double preco, string busca)
        {
            if(editar.EditarProduto(nome, preco, busca) == true)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
