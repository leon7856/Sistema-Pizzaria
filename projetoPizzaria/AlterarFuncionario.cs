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
    public partial class AlterarFuncionario : Form
    {
        public AlterarFuncionario()
        {
            InitializeComponent();
        }

        private void AlterarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int pizzaId;
            string novoNome = TxtNomeFunc.Text;
            string novaSenha = TxtSenhaFunc.Text;

            // Validação dos campos
            if (!int.TryParse(txtID.Text, out pizzaId))
            {
                MessageBox.Show("Por favor, insira um ID válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // String de conexão
            string connectionString = "server=localhost;user=root;database=bd_pizzzaria;password=;";

            // Atualizar a pizza no banco de dados
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    if (TxtNomeFunc.Text != "")
                    { 
                    connection.Open();
                    string query = "UPDATE tb_usuario SET Usuario = @usuario WHERE id = @id";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", novoNome);
                        cmd.Parameters.AddWithValue("@id", pizzaId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Usuario não encontrada. Verifique o ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                        connection.Close();
                    }
                    if (TxtSenhaFunc.Text != "")
                    {
                        connection.Open();
                        string query = "UPDATE tb_usuario SET Senha = @Senha WHERE id = @id";

                        using (var cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Senha", novaSenha);
                            cmd.Parameters.AddWithValue("@id", pizzaId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Usuario atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Usuario não encontrada. Verifique o ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        connection.Close();
                    }
                    if (txtNovoNivel.Text != "")
                    {
                        int novoNivel = Convert.ToInt32(txtNovoNivel.Text);
                        connection.Open();
                        string query = "UPDATE tb_usuario SET nivel = @novoNivel WHERE id = @id";

                        using (var cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@novoNivel", novoNivel);
                            cmd.Parameters.AddWithValue("@id", pizzaId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Usuario atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Usuario não encontrada. Verifique o ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        connection.Close();
                    }
                     }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar a pizza: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Limpar os campos
            txtID.Clear();
            TxtNomeFunc.Clear();
            TxtSenhaFunc.Clear();

        }
    }
    }
 
