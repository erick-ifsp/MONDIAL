using System;
using System.Windows.Forms;

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
            this.b3 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Confirmb2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.b4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.Color.Transparent;
            this.nome.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(193, 139);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(53, 18);
            this.nome.TabIndex = 9;
            this.nome.Text = "Usuário";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.Location = new System.Drawing.Point(196, 161);
            this.b1.Margin = new System.Windows.Forms.Padding(4);
            this.b1.MaximumSize = new System.Drawing.Size(275, 25);
            this.b1.MaxLength = 20;
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
            this.senha.Location = new System.Drawing.Point(193, 199);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(44, 18);
            this.senha.TabIndex = 11;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(196, 220);
            this.b2.MaximumSize = new System.Drawing.Size(275, 25);
            this.b2.MinimumSize = new System.Drawing.Size(275, 25);
            this.b2.Name = "b2";
            this.b2.PasswordChar = '*';
            this.b2.Size = new System.Drawing.Size(275, 22);
            this.b2.TabIndex = 12;
            this.b2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.b2_MaskInputRejected);
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
            this.botao.Location = new System.Drawing.Point(196, 542);
            this.botao.Margin = new System.Windows.Forms.Padding(0);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(275, 36);
            this.botao.TabIndex = 13;
            this.botao.Text = "Criar";
            this.botao.UseVisualStyleBackColor = false;
            this.botao.Click += new System.EventHandler(this.BtnMenssage_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(196, 338);
            this.b3.Mask = "000,000,000-00";
            this.b3.MaximumSize = new System.Drawing.Size(275, 25);
            this.b3.MinimumSize = new System.Drawing.Size(275, 25);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(275, 22);
            this.b3.TabIndex = 18;
            this.b3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "CPF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(11, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 20);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Concordo com os ";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(11, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 20);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Não concordo";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(141, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 16);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Termos de Uso";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Confirmb2
            // 
            this.Confirmb2.Location = new System.Drawing.Point(196, 280);
            this.Confirmb2.MaximumSize = new System.Drawing.Size(275, 25);
            this.Confirmb2.MinimumSize = new System.Drawing.Size(275, 25);
            this.Confirmb2.Name = "Confirmb2";
            this.Confirmb2.PasswordChar = '*';
            this.Confirmb2.Size = new System.Drawing.Size(275, 22);
            this.Confirmb2.TabIndex = 34;
            this.Confirmb2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Confirme sua senha";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(11, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(255, 20);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Desejo receber e-mails promocionais";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // b4
            // 
            this.b4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b4.Location = new System.Drawing.Point(196, 398);
            this.b4.Margin = new System.Windows.Forms.Padding(4);
            this.b4.MaximumSize = new System.Drawing.Size(275, 25);
            this.b4.MaxLength = 40;
            this.b4.MinimumSize = new System.Drawing.Size(275, 25);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(275, 22);
            this.b4.TabIndex = 37;
            this.b4.TextChanged += new System.EventHandler(this.b4_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.button2.Location = new System.Drawing.Point(196, 588);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 36);
            this.button2.TabIndex = 38;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(766, 220);
            this.b5.Name = "b5";
            this.b5.TabIndex = 39;
            this.b5.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("TT Rounds Neue Cond Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(716, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Insira sua data de nascimento (opicional)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(196, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 96);
            this.panel1.TabIndex = 41;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Confirmb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.label2);
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
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONDIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.MaskedTextBox b2;
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.MaskedTextBox b3;
        private System.Windows.Forms.Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private LinkLabel linkLabel1;
        private MaskedTextBox Confirmb2;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox b4;
        private Label label3;
        private Button button2;
        private MonthCalendar b5;
        private Label label4;
        private Panel panel1;
    }
}

