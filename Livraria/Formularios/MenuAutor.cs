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
    public partial class MenuAutor : Form
    {
        public MenuAutor()
        {
            InitializeComponent();
            AtualizarDgv();
        }
        private void AtualizarDgv()
        {
            dgvAutor.DataSource = Banco.AutorDAO.ListarTudo();
        }
        private void MenuAutor_Load(object sender, EventArgs e)
        {

        }

        private void btnCadAutor_Click(object sender, EventArgs e)
        {
            var a = new Autor();
            a.Nome_Autor = txtNomeAutor.Text;
            // Chamar o cadastrar:
            if (Banco.AutorDAO.Cadastrar(a) == true)
            {
                MessageBox.Show("Autor cadastrado!");
                // Limpar os campos:
                txtNomeAutor.Clear();

                // Atualizar o dgv:
                AtualizarDgv();
            }
            else
            {
                MessageBox.Show("Houve um erro no cadastro. " +
                "Verifique as informações digitadas.");

            }
        }
    }
}
