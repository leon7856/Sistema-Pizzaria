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
    public partial class AtualizarPizza : Form
    {
        public AtualizarPizza()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click_Click(object sender, EventArgs e)
        {
            int pizzaId;
            string novoNome = txtNovoNome.Text;
            decimal novoValor;

            // Validação dos campos
            if (!int.TryParse(txtID.Text, out pizzaId))
            {
                MessageBox.Show("Por favor, insira um ID válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(novoNome) || !decimal.TryParse(txtNovoValor.Text, out novoValor))
            {
                MessageBox.Show("Por favor, preencha os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // String de conexão
            string connectionString = "server=localhost;user=root;database=bd_pizzzaria;password=;";

            // Atualizar a pizza no banco de dados
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE produtos SET nome = @novoNome, preco = @novoPreco WHERE id = @id";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@novoNome", novoNome);
                        cmd.Parameters.AddWithValue("@novoPreco", novoValor);
                        cmd.Parameters.AddWithValue("@id", pizzaId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pizza atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Pizza não encontrada. Verifique o ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar a pizza: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Limpar os campos
            txtID.Clear();
            txtNovoNome.Clear();
            txtNovoValor.Clear();
        }
    }
}