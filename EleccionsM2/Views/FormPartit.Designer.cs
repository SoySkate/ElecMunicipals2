namespace EleccionsM2.Views
{
    partial class FormPartit
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
            buttonVolver = new Button();
            label1 = new Label();
            textBoxNomPartit = new TextBox();
            buttonCrearPartit = new Button();
            SuspendLayout();
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(443, 259);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(123, 23);
            buttonVolver.TabIndex = 11;
            buttonVolver.Text = "Tornar al Main";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 79);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 8;
            label1.Text = "Nom Partit";
            // 
            // textBoxNomPartit
            // 
            textBoxNomPartit.Location = new Point(238, 76);
            textBoxNomPartit.Name = "textBoxNomPartit";
            textBoxNomPartit.Size = new Size(116, 23);
            textBoxNomPartit.TabIndex = 6;
            textBoxNomPartit.TextChanged += textBoxNomPartit_TextChanged;
            textBoxNomPartit.KeyPress += textBoxNomPartit_KeyPress;
            // 
            // buttonCrearPartit
            // 
            buttonCrearPartit.Location = new Point(219, 151);
            buttonCrearPartit.Name = "buttonCrearPartit";
            buttonCrearPartit.Size = new Size(135, 23);
            buttonCrearPartit.TabIndex = 12;
            buttonCrearPartit.Text = "Crear Partit";
            buttonCrearPartit.UseVisualStyleBackColor = true;
            buttonCrearPartit.Click += buttonCrearPartit_Click;
            // 
            // FormPartit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 299);
            Controls.Add(buttonCrearPartit);
            Controls.Add(buttonVolver);
            Controls.Add(label1);
            Controls.Add(textBoxNomPartit);
            Name = "FormPartit";
            Text = "FormPartit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVolver;
        private Label label2;
        private TextBox textBoxNumRegidors;
        private Label label1;
        private Button buttonCrearMunicipi;
        private TextBox textBoxNomPartit;
        private Button buttonCrearPartit;
    }
}