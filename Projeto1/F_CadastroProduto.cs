using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class F_CadastroProduto : Form
    {
        public F_CadastroProduto()
        {
            InitializeComponent();
        }

        // Ação do botão home (voltar para o menu inicial)
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Principal j_principal = new F_Principal();
            j_principal.ShowDialog();
            this.Close();
        }

        // Permite que o usuário digite apenas números e vírgula (para decimais) e backspace no preço do produto
        private void tbCadastroPrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Impede que o usuário digite mais de uma vírgula
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        // Cadastro de produtos e preços
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string conexao = "Data Source=SOB041998LAB1PC\\SQLEXPRESS;" +
                "Initial Catalog = bd_Metalhead; Integrated Security = true; TrustServerCertificate=true";

            string query = "INSERT INTO tb_CadastroProduto (nomeProduto, precoProduto) VALUES (@nome, @preco)";

            SqlConnection conn = new SqlConnection(conexao);
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", tbCadastroNomeProduto.Text);
                    cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(tbCadastroPrecoProduto.Text));

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto cadastrado com sucesso!");

                        // Limpa os campos após salvar
                        tbCadastroNomeProduto.Clear();
                        tbCadastroPrecoProduto.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                    }
                }
            }
        }

        // Abre a janela de gerenciamento dos produtos
        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_GerenciarProdutos j_GerenciarProduto = new F_GerenciarProdutos();
            j_GerenciarProduto.ShowDialog();
            this.Close();
        }

        private void tbCadastroPrecoProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
