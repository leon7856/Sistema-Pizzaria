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

namespace projetoPizzaria
{
    public partial class AdicionarPizza : Form
    {
        public AdicionarPizza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomePizza = txtNomePizza.Text; // Certifique-se de que o TextBox para o nome da pizza tem o nome txtNomePizza
            decimal valorPizza;

            // Validação básica
            if (string.IsNullOrEmpty(nomePizza) || !decimal.TryParse(txtValorPizza.Text, out valorPizza))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // String de conexão com o banco de dados
            string connectionString = "server=localhost;user=root;database=bd_pizzzaria;password=;";

            // Inserir pizza no banco
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO produtos (nome, preco) VALUES (@nome, @preco)";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomePizza);
                        cmd.Parameters.AddWithValue("@preco", valorPizza);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pizza adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar os campos
                    txtNomePizza.Clear();
                    txtValorPizza.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar pizza: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
