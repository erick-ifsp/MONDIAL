namespace site_pr2
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.botao = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.MaskedTextBox();
            this.senha = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(767, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(426, 410);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 16);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Editar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Não lembra seus dados?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.botao.Location = new System.Drawing.Point(190, 365);
            this.botao.Margin = new System.Windows.Forms.Padding(0);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(278, 36);
            this.botao.TabIndex = 23;
            this.botao.Text = "Entrar";
            this.botao.UseVisualStyleBackColor = false;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(190, 313);
            this.b2.MaximumSize = new System.Drawing.Size(275, 25);
            this.b2.MinimumSize = new System.Drawing.Size(275, 25);
            this.b2.Name = "b2";
            this.b2.PasswordChar = '*';
            this.b2.Size = new System.Drawing.Size(275, 25);
            this.b2.TabIndex = 22;
            // 
            // senha
            // 
            this.senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senha.AutoSize = true;
            this.senha.BackColor = System.Drawing.Color.Transparent;
            this.senha.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(187, 292);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(44, 18);
            this.senha.TabIndex = 21;
            this.senha.Text = "Senha";
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.Location = new System.Drawing.Point(190, 248);
            this.b1.Margin = new System.Windows.Forms.Padding(4);
            this.b1.MaximumSize = new System.Drawing.Size(275, 25);
            this.b1.MaxLength = 20;
            this.b1.MinimumSize = new System.Drawing.Size(275, 25);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(275, 25);
            this.b1.TabIndex = 20;
            // 
            // nome
            // 
            this.nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.Color.Transparent;
            this.nome.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(187, 226);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(53, 18);
            this.nome.TabIndex = 19;
            this.nome.Text = "Usuário";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.Location = new System.Drawing.Point(397, 436);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(71, 16);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Criar conta";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Novo usuário?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "Copyright © 2023 de Erick Santos\r\nTodos os direitos reservados.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "LoginUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONDIAL";
            this.Load += new System.EventHandler(this.FillAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.MaskedTextBox b2;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}