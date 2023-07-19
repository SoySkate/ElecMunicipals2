namespace EleccionsM2.Views
{
    partial class FormMunicipi
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
            textBoxNomMunicipi = new TextBox();
            buttonCrearMunicipi = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxNumRegidors = new TextBox();
            buttonVolver = new Button();
            SuspendLayout();
            // 
            // textBoxNomMunicipi
            // 
            textBoxNomMunicipi.Location = new Point(247, 77);
            textBoxNomMunicipi.Name = "textBoxNomMunicipi";
            textBoxNomMunicipi.Size = new Size(116, 23);
            textBoxNomMunicipi.TabIndex = 0;
            textBoxNomMunicipi.KeyPress += textBoxNomMunicipi_KeyPress;
            // 
            // buttonCrearMunicipi
            // 
            buttonCrearMunicipi.Location = new Point(172, 239);
            buttonCrearMunicipi.Name = "buttonCrearMunicipi";
            buttonCrearMunicipi.Size = new Size(123, 23);
            buttonCrearMunicipi.TabIndex = 1;
            buttonCrearMunicipi.Text = "Crear Municipi";
            buttonCrearMunicipi.UseVisualStyleBackColor = true;
            buttonCrearMunicipi.Click += buttonCrearMunicipi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 80);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Nom Municipi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 150);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Número Regidors";
            // 
            // textBoxNumRegidors
            // 
            textBoxNumRegidors.Location = new Point(247, 147);
            textBoxNumRegidors.Name = "textBoxNumRegidors";
            textBoxNumRegidors.Size = new Size(116, 23);
            textBoxNumRegidors.TabIndex = 3;
            textBoxNumRegidors.KeyPress += textBoxNumRegidors_KeyPress;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(491, 314);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(123, 23);
            buttonVolver.TabIndex = 5;
            buttonVolver.Text = "Tornar al Main";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // FormMunicipi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 348);
            Controls.Add(buttonVolver);
            Controls.Add(label2);
            Controls.Add(textBoxNumRegidors);
            Controls.Add(label1);
            Controls.Add(buttonCrearMunicipi);
            Controls.Add(textBoxNomMunicipi);
            Name = "FormMunicipi";
            Text = "FormMunicipi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNomMunicipi;
        private Button buttonCrearMunicipi;
        private Label label1;
        private Label label2;
        private TextBox textBoxNumRegidors;
        private Button buttonVolver;
    }
}