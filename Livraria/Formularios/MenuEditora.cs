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
    public partial class MenuEditora : Form
    {
        public MenuEditora()
        {
            InitializeComponent();
            AtualizarDgv();
        }
        private void AtualizarDgv()
        {
            dgvEditora.DataSource = Banco.EditoraDAO.ListarTudo();
        }

        private void MenuEditora_Load(object sender, EventArgs e)
        {

        }

        private void btnCadEditora_Click(object sender, EventArgs e)
        {
            var edi = new Editora();
            edi.Nome_Editora = txtNomeEditora.Text;
            // Chamar o cadastrar:
            if (Banco.EditoraDAO.Cadastrar(edi) == true)
            {
                MessageBox.Show("Editora cadastrada!");
                // Limpar os campos:
                txtNomeEditora.Clear();

                // Atualizar o dgv:
                AtualizarDgv();
            }
            else
            {
                MessageBox.Show("Houve um erro no cadastro. " +
                "Verifique as informações digitadas.");

            }
        }

        private void dgvEditora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
