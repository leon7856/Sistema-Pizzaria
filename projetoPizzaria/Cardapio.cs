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
    public partial class Cardapio : Form
    {
        public Cardapio()
        {
            InitializeComponent();
        }

        private void Cardapio_Load(object sender, EventArgs e)
        {
            CarregarCardapio();
        }

        private void CarregarCardapio()
        {
            string connectionString = "server=localhost;user=root;database=bd_pizzzaria;password=;";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id AS 'ID', nome AS 'Nome da Pizza', preco AS 'Valor (R$)' FROM produtos";

                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewCardapio.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar o cardápio: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
