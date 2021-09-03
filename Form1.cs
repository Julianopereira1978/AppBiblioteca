using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace AppBiblioteca
{
    public partial class FormBiblioteca : Form
    {
        public FormBiblioteca()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder ConexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "biblioteca_pessoal";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbnome.Clear();
            tbAutor.Clear();
            tbGenero.Clear();
            tbEdicao.Clear();
            tbSinopse.Clear();
            tbEditora.Clear();
            tbEmprPara.Clear();
            tbEmprestado.Clear();
        }

        private void FormBiblioteca_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();
                MySqlCommand commandoMySql = realizaConexaoBD.CreateCommand();
                commandoMySql.CommandText = "SELECT * FROM livros";
                MySqlDataReader reader = commandoMySql.ExecuteReader();

                dgbiblioteca_pessoal.Rows.Clear();

                while (reader.Read())
                {

                    DataGridViewRow row = (DataGridViewRow)dgbiblioteca_pessoal.Rows[0].Clone();
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    row.Cells[5].Value = reader.GetString(5);
                    row.Cells[6].Value = reader.GetString(6);
                    row.Cells[7].Value = reader.GetString(7);
                    row.Cells[8].Value = reader.GetString(8);
                    dgbiblioteca_pessoal.Rows.Add(row);

                }

                realizaConexaoBD.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("can not open connection !");
                Console.WriteLine(ex.Message);

            }

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();
                MySqlCommand commandoMySql = realizaConexaoBD.CreateCommand();
                commandoMySql.CommandText = "INSERT INTO livros (nomeLivro,generoLivro,sinopseLivro,editoraLivro,autorLivro,edicaoLivro,emprestadoLivro,emprestadoLivroPara)" + "VALUES ('" + tbnome.Text + "','" + tbGenero + "','" + tbSinopse + "', '" + tbEditora + "','" + tbAutor + "', '" + tbEdicao + "', '" + tbEmprestado + "', '" + tbEmprPara + "')";
                commandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close();
                MessageBox.Show("Inserido com Sucesso");
                atualizarGrid();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
