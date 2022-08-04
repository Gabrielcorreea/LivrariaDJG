using LivrariaDJG;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Banco
{
    internal class LivroDAO
    {
        // Cadastrar Livros:
        public static bool Cadastrar(Livro l)
        {
            string comando;
            comando = "INSERT INTO livros (nome_livro," +
                "isbn, id_autor, id_editora, id_categoria) VALUES (@nome_livro, @isbn, @id_autor, @id_editora, @id_categoria)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_livro", l.Nome_Livro);
            cmd.Parameters.AddWithValue("@isbn", l.Isbn);
            cmd.Parameters.AddWithValue("@id_autor", l.Id_Autor);
            cmd.Parameters.AddWithValue("@id_editora", l.Id_Editora);
            cmd.Parameters.AddWithValue("@id_categoria", l.Id_Categoria);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        // Listar livros:
        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM view_livros";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        // Apagar livro:
        public static bool ApagarPorID(int id)
        {
            string comando;
            comando = "DELETE FROM livros WHERE id = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySQLCommand":

            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@id", id);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        // Editar
        public static bool Editar(Livro l)
        {
            string comando;
                 
            comando = "UPDATE livros SET isbn = @isbn, nome_livro = @nome_livro, id_autor = @id_autor," +
            "id_categoria = @id_categoria, " +
            "id_editora = @id_editora" + " WHERE id = @id";
                             
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySQL":

            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", l.Id);
            cmd.Parameters.AddWithValue("@isbn", l.Isbn);
            cmd.Parameters.AddWithValue("@nome_livro", l.Nome_Livro);
            cmd.Parameters.AddWithValue("@id_autor", l.Id_Autor);
            cmd.Parameters.AddWithValue("@id_categoria", l.Id_Categoria);
            cmd.Parameters.AddWithValue("@id_editora", l.Id_Editora);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }


        }
    }
   
}
