namespace site_pr2
{
    partial class CreateAccount
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.nome = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.MaskedTextBox();
            this.botao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.Color.Transparent;
            this.nome.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(191, 250);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(42, 18);
            this.nome.TabIndex = 9;
            this.nome.Text = "Nome";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.Location = new System.Drawing.Point(194, 272);
            this.b1.Margin = new System.Windows.Forms.Padding(4);
            this.b1.MaximumSize = new System.Drawing.Size(275, 25);
            this.b1.MinimumSize = new System.Drawing.Size(275, 25);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(275, 22);
            this.b1.TabIndex = 10;
            this.b1.TextChanged += new System.EventHandler(this.b1_TextChanged);
            // 
            // senha
            // 
            this.senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senha.AutoSize = true;
            this.senha.BackColor = System.Drawing.Color.Transparent;
            this.senha.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(191, 316);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(44, 18);
            this.senha.TabIndex = 11;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(194, 337);
            this.b2.MaximumSize = new System.Drawing.Size(275, 25);
            this.b2.MinimumSize = new System.Drawing.Size(275, 25);
            this.b2.Name = "b2";
            this.b2.PasswordChar = '*';
            this.b2.Size = new System.Drawing.Size(275, 22);
            this.b2.TabIndex = 12;
            // 
            // botao
            // 
            this.botao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botao.BackColor = System.Drawing.SystemColors.WindowText;
            this.botao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao.ForeColor = System.Drawing.Color.Transparent;
            this.botao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botao.Location = new System.Drawing.Point(193, 390);
            this.botao.Margin = new System.Windows.Forms.Padding(0);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(278, 36);
            this.botao.TabIndex = 13;
            this.botao.Text = "Criar";
            this.botao.UseVisualStyleBackColor = false;
            this.botao.Click += new System.EventHandler(this.btnMenssage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Já possui uma conta?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(426, 437);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 16);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log in";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(767, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // MONDIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.nome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MONDIAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONDIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.MaskedTextBox b2;
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

