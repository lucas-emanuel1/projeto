namespace Projeto1
{
    partial class F_CadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CadastroProduto));
            label1 = new Label();
            lblProduto = new Label();
            groupBox1 = new GroupBox();
            btnGerenciar = new Button();
            btnCadastrar = new Button();
            tbCadastroPrecoProduto = new TextBox();
            tbCadastroNomeProduto = new TextBox();
            label2 = new Label();
            btnHome = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Matura MT Script Capitals", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(800, 60);
            label1.TabIndex = 10;
            label1.Text = "Cadastro de Produtos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Square721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(97, 90);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(172, 23);
            lblProduto.TabIndex = 11;
            lblProduto.Text = "Nome do Produto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGerenciar);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(tbCadastroPrecoProduto);
            groupBox1.Controls.Add(tbCadastroNomeProduto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblProduto);
            groupBox1.Font = new Font("Square721 BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(144, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 388);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de produtos/preços";
            // 
            // btnGerenciar
            // 
            btnGerenciar.Cursor = Cursors.Hand;
            btnGerenciar.Location = new Point(97, 262);
            btnGerenciar.Name = "btnGerenciar";
            btnGerenciar.Size = new Size(131, 40);
            btnGerenciar.TabIndex = 15;
            btnGerenciar.Text = "Gerenciar";
            btnGerenciar.UseVisualStyleBackColor = true;
            btnGerenciar.Click += btnGerenciar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderColor = Color.White;
            btnCadastrar.FlatAppearance.BorderSize = 2;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Square721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonFace;
            btnCadastrar.Location = new Point(285, 262);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(131, 40);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // tbCadastroPrecoProduto
            // 
            tbCadastroPrecoProduto.Font = new Font("Square721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCadastroPrecoProduto.Location = new Point(97, 193);
            tbCadastroPrecoProduto.Multiline = true;
            tbCadastroPrecoProduto.Name = "tbCadastroPrecoProduto";
            tbCadastroPrecoProduto.Size = new Size(319, 28);
            tbCadastroPrecoProduto.TabIndex = 13;
            tbCadastroPrecoProduto.TextChanged += tbCadastroPrecoProduto_TextChanged;
            tbCadastroPrecoProduto.KeyPress += tbCadastroPrecoProduto_KeyPress;
            // 
            // tbCadastroNomeProduto
            // 
            tbCadastroNomeProduto.Font = new Font("Square721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCadastroNomeProduto.Location = new Point(97, 116);
            tbCadastroNomeProduto.Multiline = true;
            tbCadastroNomeProduto.Name = "tbCadastroNomeProduto";
            tbCadastroNomeProduto.Size = new Size(319, 28);
            tbCadastroNomeProduto.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Square721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 167);
            label2.Name = "label2";
            label2.Size = new Size(172, 23);
            label2.TabIndex = 11;
            label2.Text = "Preço do Produto";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(255, 224, 192);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 2;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(603, 66);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(81, 33);
            btnHome.TabIndex = 15;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // F_CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 523);
            Controls.Add(btnHome);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "F_CadastroProduto";
            Text = "F_CadastroProduto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblProduto;
        private GroupBox groupBox1;
        private TextBox tbCadastroNomeProduto;
        private Label label2;
        private TextBox tbCadastroPrecoProduto;
        private Button btnCadastrar;
        private Button btnHome;
        private Button btnGerenciar;
    }
}