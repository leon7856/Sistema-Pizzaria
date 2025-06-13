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
    public partial class Login : Form
    {

        Form1 Form1;

        public Login(Form1 form1)
        {
            InitializeComponent();
            this.Form1 = form1;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
    }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            {
                // Recebendo dados do TextBox;
                string username = Tb_Usuario.Text;
                string senha = Tb_Senha.Text;

                //Verificar se os campos estão preenchidos.
                if (username == "" || senha == "")
                {
                    MessageBox.Show("Usuário e ou senha inválidos");
                    Tb_Usuario.Focus();
                    // para encerrar o procedimento de clique.
                    return;
                }
                /*else
                {
                    MessageBox.Show("Usuário Válido");
                    this.Close();
                    return;
                }
                */

                bool usuarioCadastrado = false;

                try
                {
                    var strConexao = "server=localhost; uid=root; pwd=''; database=bd_pizzzaria";
                    var conexao = new MySqlConnection(strConexao);
                    conexao.Open();

                    var comando = new MySqlCommand("SELECT * FROM tb_usuario WHERE usuario= @usuario AND senha = @senha", conexao);
                    comando.Parameters.AddWithValue("@usuario", username);
                    comando.Parameters.AddWithValue("@senha", senha);

                    var reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        usuarioCadastrado = true;
                        Form1.reader = reader;
                    }
                    // MessageBox.Show("Conexão bem-sucedida");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }

                if (usuarioCadastrado)
                {
                    Form1.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretas.");
                    Tb_Usuario.Clear();
                    Tb_Senha.Clear();
                    Tb_Usuario.Focus();
                }
            }
        }
    }
}
