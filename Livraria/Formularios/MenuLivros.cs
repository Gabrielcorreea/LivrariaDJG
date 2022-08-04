using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Livraria.Formularios
{
    public partial class MenuLivros : Form
    {
        //Objetos Globais
        private int _idSelecionado;   

        public MenuLivros()
        {
            InitializeComponent();

            AtualizarDgv();

            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter este objeto para o array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbCategoriaCad.DataSource = rows;
            cmbCategoriaEdi.DataSource = rows.Clone();

            // Salvar o resultado da listagem de autores em um objeto:
            var r1 = Banco.AutorDAO.ListarTudo();
            ArrayList rows1 = new ArrayList();
            // Converter este objeto para o array:
            foreach (DataRow dataRow in r1.Rows)
            {
                rows1.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbAutorCad.DataSource = rows1;
            cmbAutorEdi.DataSource = rows1.Clone();

            // Salvar o resultado da listagem de Editoras em um objeto:
            var r2 = Banco.EditoraDAO.ListarTudo();
            ArrayList rows2 = new ArrayList();
            // Converter este objeto para o array:
            foreach (DataRow dataRow in r2.Rows)
            {
                rows2.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbEditoraCad.DataSource = rows2;
            cmbEditoraEdi.DataSource = rows2.Clone();
        }
        private int obterIDdaString(string texto)
        {
            return int.Parse(texto.Split(' ')[0]);
        }
        private void AtualizarDgv()
        {
            dgvLivros.DataSource = Banco.LivroDAO.ListarTudo();
        }
        private void MenuLivros_Load(object sender, EventArgs e)
        {

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var l = new Livro();
            l.Nome_Livro = txtLivroCad.Text;
            l.Id_Categoria = obterIDdaString(cmbCategoriaCad.Text);
            l.Id_Autor = obterIDdaString(cmbAutorCad.Text);
            l.Id_Editora = obterIDdaString(cmbEditoraCad.Text);
            l.Isbn = txtISBNcad.Text;
            // Chamar o cadastrar:
            if (Banco.LivroDAO.Cadastrar(l) == true)
            {
                MessageBox.Show("Livro cadastrado!");
                // Limpar os campos:
                txtLivroCad.Clear();
                //txtEditoraCad.Clear();
                txtISBNcad.Clear();
                //txtCategoriaCad.Clear();
                //txtAutorCad.Clear();

                // Atualizar o dgv:
                AtualizarDgv();
            }
            else
            {
                MessageBox.Show("Houve um erro no cadastro. " +
                "Verifique as informações digitadas.");

            }
        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Outro modo para: Mostrar o GroupBox(grbEditar.Visible = true;)

            // Ativar o groupBox de Editar:
            grbEditar.Enabled = true;
            grbRemover.Enabled = true;

            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvLivros.CurrentCell.RowIndex;

            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvLivros.Rows[numeroLinha];

            // Atribuir os valores das células aos txt do Editar:
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
            txtLivroEdi.Text = linha.Cells[1].Value.ToString();
            cmbCategoriaEdi.Text = linha.Cells[3].Value.ToString();
            cmbEditoraEdi.Text = linha.Cells[4].Value.ToString();
            cmbAutorEdi.Text = linha.Cells[5].Value.ToString();
            txtISBNedi.Text = linha.Cells[2].Value.ToString();
            lblRemover.Text = linha.Cells[1].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Instanciando:
            var l = new Livro();
            l.Id = _idSelecionado;
            l.Nome_Livro = txtLivroEdi.Text;
            l.Isbn = txtISBNedi.Text;
            l.Id_Categoria = obterIDdaString(cmbCategoriaEdi.Text);
            l.Id_Autor = obterIDdaString(cmbAutorEdi.Text);
            l.Id_Editora = obterIDdaString(cmbEditoraEdi.Text);


            // Chamar a Alterar:
            if (Banco.LivroDAO.Editar(l))
            {
                MessageBox.Show("Livro alterado com sucesso.");
                // Limpar os campos:
                txtLivroEdi.Clear();
                txtISBNedi.Clear();
                //txtEditoraEdi.Clear();
                //txtCategoriaEdi.Clear();
                //txtAutorEdi.Clear();

                // Atualizar o dgv:
                AtualizarDgv();
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Confirmar remoção:
            
            var r = MessageBox.Show("Você deseja remover este livro?",
            "ATENÇÃO!!", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                Banco.LivroDAO.ApagarPorID(_idSelecionado);

            }

            grbRemover.Enabled = false;
            // Desabilitar EDITAR:
            grbEditar.Enabled = false;

            // Atualizar DGV:
            AtualizarDgv();
        }

        private void cmbCategoriaCad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grbCadastrar_Enter(object sender, EventArgs e)
        {

        }

        private void cmbAutorCad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRemover_Click(object sender, EventArgs e)
        {

        }

        private void grbRemover_Enter(object sender, EventArgs e)
        {

        }
    }
}
