using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoPizzaria
{
    public partial class AdicionarFuncionario : Form
    {

        public MySqlConnection conexao;

        public AdicionarFuncionario()
        {
            InitializeComponent();
            var strConexao = "server=localhost; uid=root; pwd=''; database=bd_pizzzaria";
            var conexao = new MySqlConnection(strConexao);
        }

        private void AdicionarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = TxtNomeFunc.Text;
            string senha = TxtSenhaFunc.Text;
            string nivel = NumericNivel.Text;

            // Configurar a conexão com o banco de dados
            string connectionString = "server=localhost;user=root;database=bd_pizzzaria;password=;";
            MySqlConnection conexao = new MySqlConnection(connectionString);

            // Criar o comando SQL
            var comando = new MySqlCommand("INSERT INTO Tb_usuario (usuario, senha, nivel) VALUES (@usuario, @senha, @nivel)", conexao);
            comando.Parameters.AddWithValue("@usuario", nome);
            comando.Parameters.AddWithValue("@senha", senha);
            comando.Parameters.AddWithValue("@nivel", nivel);

            try
            {
                // Abrir a conexão e executar o comando
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();

                // Mostrar mensagem de sucesso
                MessageBox.Show("Usuário inserido com sucesso!");

                // Limpar os campos do formulário
                TxtNomeFunc.Clear();
                TxtSenhaFunc.Clear();
                NumericNivel.Text = "";
            }
            catch (Exception ex)
            {
                // Mostrar mensagem de erro
                MessageBox.Show("Erro ao inserir usuário: " + ex.Message);
            }

        }
    }
}
