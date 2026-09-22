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
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        // Oculta a janela atual e abre a janela referente ao botão
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_CadastroProduto j_cadastro = new F_CadastroProduto();
            j_cadastro.ShowDialog();
            this.Close();
        }

        // Oculta a janela atual e abre a janela referente ao botão
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Inicial f_Principal = new F_Inicial();
            f_Principal.ShowDialog();
            this.Close();
        }
    }
}
