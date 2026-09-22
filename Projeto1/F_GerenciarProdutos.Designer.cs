namespace Projeto1
{
    partial class F_GerenciarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GerenciarProdutos));
            lblTitulo = new Label();
            btnHome = new Button();
            dgvGerenciarProdutos = new DataGridView();
            btnGerenciarEditar = new Button();
            btnGerenciarSalvar = new Button();
            groupBox1 = new GroupBox();
            tbxPreco = new TextBox();
            tbxProduto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDeletar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvGerenciarProdutos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Black;
            lblTitulo.Font = new Font("Matura MT Script Capitals", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(-75, -2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(877, 103);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Gerenciar Produtos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(255, 224, 192);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 2;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(694, 36);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(81, 33);
            btnHome.TabIndex = 15;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // dgvGerenciarProdutos
            // 
            dgvGerenciarProdutos.BackgroundColor = SystemColors.ButtonFace;
            dgvGerenciarProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGerenciarProdutos.Location = new Point(24, 134);
            dgvGerenciarProdutos.Name = "dgvGerenciarProdutos";
            dgvGerenciarProdutos.Size = new Size(377, 274);
            dgvGerenciarProdutos.TabIndex = 16;
            // 
            // btnGerenciarEditar
            // 
            btnGerenciarEditar.BackColor = Color.FromArgb(255, 128, 0);
            btnGerenciarEditar.Cursor = Cursors.Hand;
            btnGerenciarEditar.FlatAppearance.BorderColor = Color.White;
            btnGerenciarEditar.FlatAppearance.BorderSize = 2;
            btnGerenciarEditar.FlatStyle = FlatStyle.Flat;
            btnGerenciarEditar.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGerenciarEditar.ForeColor = SystemColors.ButtonFace;
            btnGerenciarEditar.Location = new Point(238, 444);
            btnGerenciarEditar.Name = "btnGerenciarEditar";
            btnGerenciarEditar.Size = new Size(122, 39);
            btnGerenciarEditar.TabIndex = 17;
            btnGerenciarEditar.Text = "Editar";
            btnGerenciarEditar.UseVisualStyleBackColor = false;
            btnGerenciarEditar.Click += btnGerenciarEditar_Click;
            // 
            // btnGerenciarSalvar
            // 
            btnGerenciarSalvar.BackColor = Color.FromArgb(255, 128, 0);
            btnGerenciarSalvar.Cursor = Cursors.Hand;
            btnGerenciarSalvar.FlatAppearance.BorderColor = Color.White;
            btnGerenciarSalvar.FlatAppearance.BorderSize = 2;
            btnGerenciarSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            btnGerenciarSalvar.FlatStyle = FlatStyle.Flat;
            btnGerenciarSalvar.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGerenciarSalvar.ForeColor = SystemColors.ButtonFace;
            btnGerenciarSalvar.Location = new Point(50, 205);
            btnGerenciarSalvar.Name = "btnGerenciarSalvar";
            btnGerenciarSalvar.Size = new Size(219, 45);
            btnGerenciarSalvar.TabIndex = 18;
            btnGerenciarSalvar.Text = "Salvar";
            btnGerenciarSalvar.UseVisualStyleBackColor = false;
            btnGerenciarSalvar.Click += btnGerenciarSalvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxPreco);
            groupBox1.Controls.Add(tbxProduto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGerenciarSalvar);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(453, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 274);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Produto";
            // 
            // tbxPreco
            // 
            tbxPreco.Location = new Point(50, 143);
            tbxPreco.Name = "tbxPreco";
            tbxPreco.Size = new Size(219, 29);
            tbxPreco.TabIndex = 3;
            // 
            // tbxProduto
            // 
            tbxProduto.Location = new Point(50, 65);
            tbxProduto.Name = "tbxProduto";
            tbxProduto.Size = new Size(219, 29);
            tbxProduto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Square721 BT", 14.25F, FontStyle.Bold);
            label2.Location = new Point(50, 115);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 1;
            label2.Text = "Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Square721 BT", 14.25F, FontStyle.Bold);
            label1.Location = new Point(50, 37);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.FromArgb(255, 192, 128);
            btnDeletar.Cursor = Cursors.Hand;
            btnDeletar.FlatAppearance.BorderColor = Color.White;
            btnDeletar.FlatAppearance.BorderSize = 2;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeletar.ForeColor = SystemColors.ActiveCaptionText;
            btnDeletar.Location = new Point(73, 444);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(122, 39);
            btnDeletar.TabIndex = 20;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(619, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // F_GerenciarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 556);
            Controls.Add(pictureBox1);
            Controls.Add(btnDeletar);
            Controls.Add(groupBox1);
            Controls.Add(btnGerenciarEditar);
            Controls.Add(dgvGerenciarProdutos);
            Controls.Add(btnHome);
            Controls.Add(lblTitulo);
            DoubleBuffered = true;
            Name = "F_GerenciarProdutos";
            Text = "F_GerenciarProdutos";
            Load += F_GerenciarProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGerenciarProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnHome;
        private DataGridView dgvGerenciarProdutos;
        private Button btnGerenciarEditar;
        private Button btnGerenciarSalvar;
        private GroupBox groupBox1;
        private TextBox tbxPreco;
        private TextBox tbxProduto;
        private Label label2;
        private Label label1;
        private Button btnDeletar;
        private PictureBox pictureBox1;
    }
}