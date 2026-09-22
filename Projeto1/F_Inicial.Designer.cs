namespace Projeto1
{
    partial class F_Inicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Inicial));
            lblTitulo = new Label();
            lblProduto = new Label();
            cbProduto = new ComboBox();
            lblQuantidade = new Label();
            nudQuantidade = new NumericUpDown();
            btnAdicionar = new Button();
            panel1 = new Panel();
            error1 = new Label();
            error = new Label();
            tbMesa = new TextBox();
            tbNomeCliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblAjuda = new Label();
            btnFinalizar = new Button();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            btnCancelar = new Button();
            lstPedido = new ListBox();
            panel3 = new Panel();
            lblTotal = new Label();
            lblPedido = new Label();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Matura MT Script Capitals", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(290, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(465, 64);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Metalhead Burgers";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Square721 BT", 14.25F);
            lblProduto.Location = new Point(111, 208);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(84, 23);
            lblProduto.TabIndex = 0;
            lblProduto.Text = "Produto";
            // 
            // cbProduto
            // 
            cbProduto.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProduto.FormattingEnabled = true;
            cbProduto.Location = new Point(111, 234);
            cbProduto.Name = "cbProduto";
            cbProduto.Size = new Size(231, 28);
            cbProduto.TabIndex = 1;
            cbProduto.SelectedIndexChanged += cbProduto_SelectedIndexChanged;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Square721 BT", 14.25F);
            lblQuantidade.Location = new Point(111, 277);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(114, 23);
            lblQuantidade.TabIndex = 0;
            lblQuantidade.Text = "Quantidade";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Font = new Font("Square721 BT", 15.75F);
            nudQuantidade.Location = new Point(111, 303);
            nudQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.ReadOnly = true;
            nudQuantidade.Size = new Size(231, 33);
            nudQuantidade.TabIndex = 2;
            nudQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(255, 128, 0);
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatAppearance.BorderColor = Color.White;
            btnAdicionar.FlatAppearance.BorderSize = 2;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Square721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = SystemColors.ButtonFace;
            btnAdicionar.Location = new Point(173, 351);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(109, 38);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(error1);
            panel1.Controls.Add(error);
            panel1.Controls.Add(tbMesa);
            panel1.Controls.Add(tbNomeCliente);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nudQuantidade);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(cbProduto);
            panel1.Controls.Add(lblQuantidade);
            panel1.Controls.Add(lblAjuda);
            panel1.Controls.Add(lblProduto);
            panel1.Location = new Point(43, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 408);
            panel1.TabIndex = 4;
            // 
            // error1
            // 
            error1.AutoSize = true;
            error1.Font = new Font("Square721 BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            error1.ForeColor = Color.Red;
            error1.Location = new Point(111, 194);
            error1.Name = "error1";
            error1.Size = new Size(124, 14);
            error1.TabIndex = 6;
            error1.Text = "A mesa é obrigatóiria!";
            error1.Visible = false;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Square721 BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            error.ForeColor = Color.Red;
            error.Location = new Point(111, 122);
            error.Name = "error";
            error.Size = new Size(121, 14);
            error.TabIndex = 6;
            error.Text = "O nome é obrigatório!";
            error.Visible = false;
            // 
            // tbMesa
            // 
            tbMesa.Font = new Font("Square721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMesa.Location = new Point(111, 165);
            tbMesa.Multiline = true;
            tbMesa.Name = "tbMesa";
            tbMesa.Size = new Size(231, 28);
            tbMesa.TabIndex = 5;
            tbMesa.TextChanged += tbMesa_TextChanged;
            tbMesa.KeyPress += tbMesa_KeyPress;
            // 
            // tbNomeCliente
            // 
            tbNomeCliente.Font = new Font("Square721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNomeCliente.Location = new Point(111, 93);
            tbNomeCliente.Multiline = true;
            tbNomeCliente.Name = "tbNomeCliente";
            tbNomeCliente.Size = new Size(231, 28);
            tbNomeCliente.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Square721 BT", 14.25F);
            label3.Location = new Point(111, 136);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 4;
            label3.Text = "Mesa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Square721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 64);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // lblAjuda
            // 
            lblAjuda.AutoSize = true;
            lblAjuda.Font = new Font("Square721 BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAjuda.Location = new Point(403, 21);
            lblAjuda.Name = "lblAjuda";
            lblAjuda.Size = new Size(35, 33);
            lblAjuda.TabIndex = 0;
            lblAjuda.Text = "ⓘ";
            toolTip1.SetToolTip(lblAjuda, "Informe o seu nome, a mesa que se encontra, o produto e a quantidade.");
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(255, 128, 0);
            btnFinalizar.Cursor = Cursors.Hand;
            btnFinalizar.FlatAppearance.BorderColor = Color.White;
            btnFinalizar.FlatAppearance.BorderSize = 2;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Square721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.ForeColor = SystemColors.ButtonFace;
            btnFinalizar.Location = new Point(259, 346);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(154, 38);
            btnFinalizar.TabIndex = 3;
            btnFinalizar.Text = "Finalizar Pedido";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(lstPedido);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnFinalizar);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblPedido);
            panel2.Location = new Point(541, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 408);
            panel2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Transparent;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Square721 BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(394, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(52, 21);
            dateTimePicker1.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 224, 192);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(58, 346);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 38);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar Pedido";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstPedido
            // 
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(22, 64);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(430, 228);
            lstPedido.TabIndex = 5;
            lstPedido.SelectedIndexChanged += lstPedido_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(22, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 2);
            panel3.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(154, 302);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(160, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total: R$ 0,00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPedido.Location = new Point(205, 12);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(59, 20);
            lblPedido.TabIndex = 0;
            lblPedido.Text = "Pedido";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Square721 BT", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(-2, 545);
            label1.Name = "label1";
            label1.Size = new Size(1065, 15);
            label1.TabIndex = 5;
            label1.Text = "Projeto desenvolvido pela Instituição SENAC                                       ©Copyright by Lucas Soares e Lucas Emanuel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(792, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(255, 224, 192);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 2;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Square721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(940, 39);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(81, 33);
            btnHome.TabIndex = 14;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // F_Inicial
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 559);
            Controls.Add(btnHome);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Square721 BT", 9.75F);
            Name = "F_Inicial";
            Text = "F_Inicial";
            Load += F_Inicial_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblProduto;
        private ComboBox cbProduto;
        private Label lblQuantidade;
        private NumericUpDown nudQuantidade;
        private Button btnAdicionar;
        private Panel panel1;
        private Button btnFinalizar;
        private Panel panel2;
        private ListBox lstPedido;
        private Panel panel3;
        private Label lblPedido;
        private Label lblTotal;
        private Button btnCancelar;
        private Label lblAjuda;
        private ToolTip toolTip1;
        private Label label1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnHome;
        private TextBox tbMesa;
        private TextBox tbNomeCliente;
        private Label label3;
        private Label label2;
        private Label error1;
        private Label error;
    }
}
