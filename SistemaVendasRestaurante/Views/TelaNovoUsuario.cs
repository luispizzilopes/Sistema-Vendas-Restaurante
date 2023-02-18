using SistemaVendasRestaurante.Controller.Login;
using SistemaVendasRestaurante.Models.Login;
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
    public partial class TelaNovoUsuario : Form
    {
        public TelaNovoUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            LoginController login = new LoginController(); 
            if(login.Cadastrar(txtBoxUsuario.Text, txtBoxSenha.Text) == true)
            {
                MessageBox.Show("Cadastro de usuário realizado com sucesso!"); 
            }
            else
            {
                MessageBox.Show("Não foi possível realizar o cadastro!"); 
            }
        }
    }
}
