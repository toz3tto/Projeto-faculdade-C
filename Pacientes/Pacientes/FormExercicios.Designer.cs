namespace Pacientes
{
    partial class FormExercicios
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
            lstExercicios = new ListBox();
            btnGerarPDF = new Button();
            comboBox1 = new ComboBox();
            txtNomePaciente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstExercicios
            // 
            lstExercicios.FormattingEnabled = true;
            lstExercicios.Location = new Point(31, 145);
            lstExercicios.Name = "lstExercicios";
            lstExercicios.Size = new Size(580, 224);
            lstExercicios.TabIndex = 2;
            // 
            // btnGerarPDF
            // 
            btnGerarPDF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerarPDF.Location = new Point(31, 393);
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.Size = new Size(118, 45);
            btnGerarPDF.TabIndex = 3;
            btnGerarPDF.Text = "Gerar PDF";
            btnGerarPDF.UseVisualStyleBackColor = true;
            btnGerarPDF.Click += btnGerarPDF_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNomePaciente
            // 
            txtNomePaciente.Location = new Point(347, 71);
            txtNomePaciente.Name = "txtNomePaciente";
            txtNomePaciente.Size = new Size(264, 27);
            txtNomePaciente.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(347, 50);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 8;
            label2.Text = "Paciente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 51);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 9;
            label1.Text = "Protocolos:";
            // 
            // FormExercicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtNomePaciente);
            Controls.Add(comboBox1);
            Controls.Add(btnGerarPDF);
            Controls.Add(lstExercicios);
            Name = "FormExercicios";
            Text = "FormExercicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstExercicios;
        private Button btnGerarPDF;
        private ComboBox comboBox1;
        private TextBox txtNomePaciente;
        private Label label2;
        private Label label1;
    }
}