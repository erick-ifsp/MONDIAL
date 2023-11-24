namespace site_pr2
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.botao = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.MaskedTextBox();
            this.senha = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.dados = new System.Windows.Forms.ListView();
            this.IdUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.botao.Location = new System.Drawing.Point(197, 412);
            this.botao.Margin = new System.Windows.Forms.Padding(0);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(275, 36);
            this.botao.TabIndex = 21;
            this.botao.Text = "Editar";
            this.botao.UseVisualStyleBackColor = false;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(197, 250);
            this.b2.MaximumSize = new System.Drawing.Size(275, 22);
            this.b2.MinimumSize = new System.Drawing.Size(275, 22);
            this.b2.Name = "b2";
            this.b2.PasswordChar = '*';
            this.b2.Size = new System.Drawing.Size(275, 22);
            this.b2.TabIndex = 20;
            this.b2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.b2_MaskInputRejected);
            // 
            // senha
            // 
            this.senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senha.AutoSize = true;
            this.senha.BackColor = System.Drawing.Color.Transparent;
            this.senha.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(194, 229);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(44, 18);
            this.senha.TabIndex = 19;
            this.senha.Text = "Senha";
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.Location = new System.Drawing.Point(197, 188);
            this.b1.Margin = new System.Windows.Forms.Padding(4);
            this.b1.MaximumSize = new System.Drawing.Size(275, 20);
            this.b1.MaxLength = 20;
            this.b1.MinimumSize = new System.Drawing.Size(275, 20);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(275, 22);
            this.b1.TabIndex = 18;
            this.b1.TextChanged += new System.EventHandler(this.b1_TextChanged);
            // 
            // nome
            // 
            this.nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.Color.Transparent;
            this.nome.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(194, 166);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(53, 18);
            this.nome.TabIndex = 17;
            this.nome.Text = "Usuário";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // dados
            // 
            this.dados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdUser,
            this.NameUser});
            this.dados.FullRowSelect = true;
            this.dados.HideSelection = false;
            this.dados.Location = new System.Drawing.Point(767, 247);
            this.dados.Name = "dados";
            this.dados.Size = new System.Drawing.Size(274, 158);
            this.dados.TabIndex = 24;
            this.dados.UseCompatibleStateImageBehavior = false;
            this.dados.View = System.Windows.Forms.View.Details;
            this.dados.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.dados.DoubleClick += new System.EventHandler(this.dados_DoubleClick);
            // 
            // IdUser
            // 
            this.IdUser.Text = "id";
            this.IdUser.Width = 0;
            // 
            // NameUser
            // 
            this.NameUser.Text = "Usuário";
            this.NameUser.Width = 274;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(197, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(197, 311);
            this.b3.Mask = "000,000,000-00";
            this.b3.MaximumSize = new System.Drawing.Size(275, 25);
            this.b3.MinimumSize = new System.Drawing.Size(275, 25);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(275, 22);
            this.b3.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "CPF";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(197, 565);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 36);
            this.button2.TabIndex = 28;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b4
            // 
            this.b4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b4.Location = new System.Drawing.Point(197, 368);
            this.b4.Margin = new System.Windows.Forms.Padding(4);
            this.b4.MaximumSize = new System.Drawing.Size(275, 25);
            this.b4.MaxLength = 40;
            this.b4.MinimumSize = new System.Drawing.Size(275, 25);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(275, 22);
            this.b4.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "E-mail";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dados);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.nome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONDIAL";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.MaskedTextBox b2;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.ListView dados;
        private System.Windows.Forms.ColumnHeader NameUser;
        private System.Windows.Forms.ColumnHeader IdUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox b3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox b4;
        private System.Windows.Forms.Label label3;
    }
}