namespace Projeto1
{
    partial class F_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            label1 = new Label();
            btnEntrar = new Button();
            btnCadastrar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(567, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Matura MT Script Capitals", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(96, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(465, 64);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Metalhead Burgers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Square721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(131, 144);
            label1.Name = "label1";
            label1.Size = new Size(549, 23);
            label1.TabIndex = 9;
            label1.Text = "Seja bem vindo(a) ao menu principal do Metalhead Burgers";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(255, 128, 0);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderColor = Color.White;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Square721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonFace;
            btnEntrar.Location = new Point(159, 330);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(139, 40);
            btnEntrar.TabIndex = 10;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Square721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonFace;
            btnCadastrar.Location = new Point(488, 330);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(139, 40);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(391, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 200);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Square721 BT", 9.75F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(118, 229);
            label2.Name = "label2";
            label2.Size = new Size(225, 71);
            label2.TabIndex = 9;
            label2.Text = "Escolha a opção Entrar, caso queira acessar o painel principal.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Square721 BT", 9.75F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(423, 229);
            label3.Name = "label3";
            label3.Size = new Size(282, 71);
            label3.TabIndex = 9;
            label3.Text = "Escolha a opção Cadastrar, caso queira cadastrar um novo produto/preço.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            DoubleBuffered = true;
            Name = "F_Principal";
            Text = "F_Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label label1;
        private Button btnEntrar;
        private Button btnCadastrar;
        private Panel panel1;
        private Label label2;
        private Label label3;
    }
}