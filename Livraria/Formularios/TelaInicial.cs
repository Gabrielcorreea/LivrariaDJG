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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {       
              var menuPrincipal = new Formularios.MenuPrincipal();
              // Esconder a primeira janela:
              Hide();
              // Mostrar a nova:
              menuPrincipal.ShowDialog();
              // Ao sair da anterior, mostrar novamente:
              Show();          
        }
    }
}
