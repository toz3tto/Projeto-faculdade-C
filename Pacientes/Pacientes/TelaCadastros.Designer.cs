namespace Pacientes
{
    partial class TelaCadastros
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
            lblNome = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
            txtCpf = new TextBox();
            btnPesquisar = new Button();
            lblId = new Label();
            btnLimpar = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblNome.Location = new Point(64, 143);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(71, 24);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(64, 194);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 24);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "E-mail:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblCpf.Location = new Point(65, 244);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(56, 24);
            lblCpf.TabIndex = 8;
            lblCpf.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(190, 143);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(389, 27);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 194);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(390, 27);
            txtEmail.TabIndex = 2;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(65, 295);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(107, 24);
            lblEndereco.TabIndex = 9;
            lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(190, 290);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(389, 27);
            txtEndereco.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(64, 369);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(118, 38);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(189, 244);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(390, 27);
            txtCpf.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(227, 369);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(118, 38);
            btnPesquisar.TabIndex = 13;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(65, 97);
            lblId.Name = "lblId";
            lblId.Size = new Size(36, 24);
            lblId.TabIndex = 14;
            lblId.Text = "ID:";
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(480, 72);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(99, 35);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(351, 369);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(107, 38);
            btnAtualizar.TabIndex = 16;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(464, 369);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(115, 38);
            btnDeletar.TabIndex = 17;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // TelaCadastros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLimpar);
            Controls.Add(lblId);
            Controls.Add(btnPesquisar);
            Controls.Add(txtCpf);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblCpf);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastros";
            Text = "Cadastro de pacientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblCpf;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Button btnCadastrar;
        private TextBox txtCpf;
        private Button btnPesquisar;
        private Label lblId;
        private Button btnLimpar;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}
