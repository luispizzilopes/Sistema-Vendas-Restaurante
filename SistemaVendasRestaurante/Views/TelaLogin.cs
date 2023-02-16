using SistemaVendasRestaurante.Controller.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendasRestaurante.Views
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            if(loginController.Acessar(txtBoxUsuario.Text, txtBoxSenha.Text) == true)
            {
                MessageBox.Show("Acessando...");
            }
            else
            {
                MessageBox.Show("Erro!"); 
            }
        }
    }
}
