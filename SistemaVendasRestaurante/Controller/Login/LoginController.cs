using SistemaVendasRestaurante.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Controller.Login
{
    internal class LoginController
    {
        LoginModel loginModel = new LoginModel();

        public bool Acessar(string usuario, string senha)
        {
            if(loginModel.Acessar(usuario, senha) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Cadastrar(string usuario, string senha)
        {
            if(loginModel.Cadastrar(usuario, senha) == true)
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
