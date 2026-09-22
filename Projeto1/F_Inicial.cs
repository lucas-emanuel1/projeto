using System.Data;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Projeto1
{
    public partial class F_Inicial : Form
    {
        public F_Inicial()
        {
            InitializeComponent();
        }
        // Variável global
        double preco = 0;
        // Quando clicar em adicionar...
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Codicional para verificar se o nome e a mesa foi preenchida   
            if (tbNomeCliente.Text == "")
            {
                error.Visible = true;
            } else if (tbMesa.Text == "")
            {
                if (tbNomeCliente.Text != "")
                {
                    error.Visible = false;
                }
                error1.Visible = true;
            }
            // Caso estiver tudo preenchido corretamente...
            else
            {
                // Oculta o erro
                error1.Visible = false;
                // Cria as variáveis removendo os espaços em branco e pegando o seu respectivos valores
                string produto = cbProduto.Text.Trim();
                int quantidade = Convert.ToInt32(nudQuantidade.Value);
                double precoUnitario = Convert.ToDouble(cbProduto.SelectedValue);

                // Calcula o subtotal do item
                double subtotal = precoUnitario * quantidade;

                // Monta o texto e adiciona na ListBox
                string itemFormatado = $"{produto.Trim()} - {quantidade}x - R$ {subtotal}";
                lstPedido.Items.Add(itemFormatado);

                // Atualiza o total geral do pedido
                preco += subtotal;
                lblTotal.Text = $"Total: R$ {preco:F2}";
            }
        }
        // Quando clicar no botão de finalizar...
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Cria as variáveis
            int Quant = Convert.ToInt32(nudQuantidade.Text);
            string Produto = cbProduto.Text;
            string nomeCliente = tbNomeCliente.Text;
            int numMesa = Convert.ToInt32(tbMesa.Text);
            string numeroWhatsapp = "8892497229";

            // Pega a data atual (horas e minutos)
            DateTime agora = DateTime.Now;
            int hora = agora.Hour;
            int minuto = agora.Minute;

            // Mensagem amigável para o cliente
            MessageBox.Show(
                $"Pedido Finalizado com sucesso! \n----------------------------------------\n\n" +
                $"Nome: {nomeCliente} \n" +
                $"Mesa: {numMesa} \n" +
                $"Produto: {Produto.Trim()} \n" +
                $"Quantidade: {Quant}x \n\n" +
                $"==================== \n" +
                $"Pedido realizado às {hora:D2}:{minuto:D2}",
                "Pedido Concluído!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            MessageBox.Show(
                $"Metalhead Burgers agradece, volte sempre!🤘🏼\n",
                "Obrigado(a)!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            string mensagem = $"*Novo Pedido - Metalhead Burgers 🤘🏼*\n\n" +
                     $"*Cliente:* {nomeCliente}\n" +
                     $"*Mesa:* {numMesa}\n" +
                     $"*Produto:* {Produto} (x{Quant})\n" +
                     $"-----------------------------------\n" +
                     $"*Total:* {lblTotal.Text}\n\n" +
                     $"Pedido realizado às {DateTime.Now:HH:mm}";

            string mensagemCodificada = WebUtility.UrlEncode(mensagem);

            string urlWhatsApp = $"https://wa.me/{numeroWhatsapp}?text={mensagemCodificada}";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = urlWhatsApp,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o WhatsApp: " + ex.Message);
            }
        }

        // Ao clicar no botão cancelar...
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpa o ListBox
            lstPedido.Items.Clear();
            lblTotal.Text = "Total: R$ 0,00";
        }

        // Bloco para voltar para o menu inicial
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Principal j_principal = new F_Principal();
            j_principal.ShowDialog();
            this.Close();
        }

        private void F_Inicial_Load(object sender, EventArgs e)
        {
            CarregarProdutosComboBox();
        }

        // Função para carregar os produtos do banco de dados
        private void CarregarProdutosComboBox()
        {
            string conexao = "Data Source=SOB041998LAB1PC\\SQLEXPRESS;" +
            "Initial Catalog = bd_Metalhead; Integrated Security = true; TrustServerCertificate=true";
            string query = "SELECT id_produto, TRIM(nomeProduto) AS nomeProduto, precoProduto FROM tb_CadastroProduto";

            using (SqlConnection con = new SqlConnection(conexao))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbProduto.DataSource = dt;
                    cbProduto.DisplayMember = "nomeProduto";
                    cbProduto.ValueMember = "precoProduto";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
                }
            }
        }

        private void lstPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Permite que o usuário digite apenas números e vírgulas (ignorando letras)
        private void tbMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Permite que o usuário digite apenas uma única vírgula (evitando colocar várias vírgulas)
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        // Limita o usuário a não ultrapassar 99 (número total de mesas)
        private void tbMesa_TextChanged(object sender, EventArgs e)
        {
            tbMesa.MaxLength = 2;
        }
    }
}