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
    public partial class F_GerenciarProdutos : Form
    {
        int id_produto;
        public F_GerenciarProdutos()
        {

            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Principal j_principal = new F_Principal();
            j_principal.ShowDialog();
            this.Close();
        }


        private void F_GerenciarProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                string conexao = "Data Source=SOB041998LAB1PC\\SQLEXPRESS;" +
            "Initial Catalog = bd_Metalhead; Integrated Security = true; TrustServerCertificate=true";

                SqlConnection conn = new SqlConnection(conexao);

                conn.Open();

                // string sql = "SELECT id_produto AS ID, nomeProduto AS Nome, precoProduto AS Preço FROM [dbo].[tb_CadastroProduto]";
                string sql = "SELECT id_produto AS ID, TRIM(nomeProduto) AS Nome, precoProduto AS Preço FROM tb_CadastroProduto";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGerenciarProdutos.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lista Produtos");
            }
        }

        private void btnGerenciarEditar_Click(object sender, EventArgs e)
        {
            tbxProduto.Text = dgvGerenciarProdutos.CurrentRow.Cells[1].Value.ToString().Trim();
            tbxPreco.Text = dgvGerenciarProdutos.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void btnGerenciarSalvar_Click(object sender, EventArgs e)
        {
            if (dgvGerenciarProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto na tabela para editar.");
                return;
            }

            int id_produto = Convert.ToInt32(dgvGerenciarProdutos.SelectedRows[0].Cells["id_produto"].Value);

            // 2. Pega os novos textos das caixas
            string nome = tbxProduto.Text.Trim();
            string preco = tbxPreco.Text.Trim();

            string conexao = @"Data Source=SOB041998LAB1PC\SQLEXPRESS;Initial Catalog=bd_Metalhead;Integrated Security=True;TrustServerCertificate=True";

            string sql = "UPDATE [dbo].[tb_CadastroProduto] SET nomeProduto = @nomeProduto, precoProduto = @precoProduto WHERE id_produto = @id_produto";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    // Atribui os parâmetros corretamente
                    comando.Parameters.AddWithValue("@id_produto", id_produto);
                    comando.Parameters.AddWithValue("@nomeProduto", nome);
                    comando.Parameters.AddWithValue("@precoProduto", Convert.ToDecimal(preco));

                    try
                    {
                        conn.Open();
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show($"Atualização do produto {nome} realizada com sucesso!");


                            F_GerenciarProdutos_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum produto foi atualizado. Verifique se o ID está correto.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // 1. Valida se o usuário selecionou alguma linha na tabela
            if (dgvGerenciarProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto na tabela para deletar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmação para evitar exclusão acidental
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir este produto?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                // 3. Pega o ID do produto selecionado na DataGridView
                int id_produto = Convert.ToInt32(dgvGerenciarProdutos.CurrentRow.Cells[0].Value);

                string conexao = @"Data Source=SOB041998LAB1PC\SQLEXPRESS;Initial Catalog=bd_Metalhead;Integrated Security=True;TrustServerCertificate=True;";
                string sql = "DELETE FROM [dbo].[tb_CadastroProduto] WHERE id_produto = @id_produto";

                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    using (SqlCommand comando = new SqlCommand(sql, conn))
                    {
                        comando.Parameters.AddWithValue("@id_produto", id_produto);

                        try
                        {
                            conn.Open();
                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Produto excluído com sucesso!");

                                // Limpa os campos de texto
                                tbxProduto.Clear();
                                tbxPreco.Clear();

                                // Recarrega a tabela para atualizar a lista
                                F_GerenciarProdutos_Load(sender, e);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao deletar produto: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
