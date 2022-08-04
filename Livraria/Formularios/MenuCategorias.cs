using System;
using System.Collections;
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
    public partial class MenuCategorias : Form
    {
        string c;
        public MenuCategorias()
        {
            InitializeComponent();
            //AtualizarDgv();

            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter este objeto para o array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbCategorias.DataSource = rows;
        }
        //private void AtualizarDgv()
        //{
        //    dgvCategoria.DataSource = Banco.CategoriaDAO.ListarTudoporCat(c);
        //}
        private void MenuCategorias_Load(object sender, EventArgs e)
        {

        }
        private int obterIDdaString(string texto)
        {
            return int.Parse(texto.Split(' ')[0]);
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = new Categoria();
            c.Id = obterIDdaString(cmbCategorias.Text);
            dgvCategoria.DataSource = Banco.CategoriaDAO.ListarTudoporCat(c);
        }
    }
}
