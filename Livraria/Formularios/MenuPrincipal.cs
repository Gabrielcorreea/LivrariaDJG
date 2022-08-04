using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.Formularios
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            var menucategorias = new Formularios.MenuCategorias();
            // Esconder a primeira janela:
            Hide();
            // Mostrar a nova:
            menucategorias.ShowDialog();
            // Ao sair da anterior, mostrar novamente:
            Show();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            var menulivros = new Formularios.MenuLivros();
            // Esconder a primeira janela:
            Hide();
            // Mostrar a nova:
            menulivros.ShowDialog();
            // Ao sair da anterior, mostrar novamente:
            Show();
        }

        private void btnEditora_Click(object sender, EventArgs e)
        {
            var menueditoras = new Formularios.MenuEditora();
            // Esconder a primeira janela:
            Hide();
            // Mostrar a nova:
            menueditoras.ShowDialog();
            // Ao sair da anterior, mostrar novamente:
            Show();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            var menuautores = new Formularios.MenuAutor();
            // Esconder a primeira janela:
            Hide();
            // Mostrar a nova:
            menuautores.ShowDialog();
            // Ao sair da anterior, mostrar novamente:
            Show();
        }
    }
}
