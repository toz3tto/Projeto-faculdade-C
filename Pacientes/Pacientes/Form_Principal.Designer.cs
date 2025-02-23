namespace Pacientes
{
    partial class Form_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            btnCriarTreinos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCriarTreinos
            // 
            btnCriarTreinos.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarTreinos.Image = (Image)resources.GetObject("btnCriarTreinos.Image");
            btnCriarTreinos.ImageAlign = ContentAlignment.TopCenter;
            btnCriarTreinos.Location = new Point(144, 61);
            btnCriarTreinos.Name = "btnCriarTreinos";
            btnCriarTreinos.Size = new Size(94, 96);
            btnCriarTreinos.TabIndex = 0;
            btnCriarTreinos.UseVisualStyleBackColor = true;
            btnCriarTreinos.Click += btnCriarTreinos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 171);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 1;
            label1.Text = "Protocolos";
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 238);
            Controls.Add(label1);
            Controls.Add(btnCriarTreinos);
            Name = "Form_Principal";
            Text = "Form_Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCriarTreinos;
        private Label label1;
    }
}