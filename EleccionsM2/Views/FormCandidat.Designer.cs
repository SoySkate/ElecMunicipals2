namespace EleccionsM2.Views
{
    partial class FormCandidat
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
            buttonCrearCandidat = new Button();
            textBoxNomCandidat = new TextBox();
            SuspendLayout();
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(407, 238);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(123, 23);
            buttonVolver.TabIndex = 15;
            buttonVolver.Text = "Cancel·lar";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 58);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 14;
            label1.Text = "Nom Candidat";
            // 
            // buttonCrearCandidat
            // 
            buttonCrearCandidat.Location = new Point(153, 129);
            buttonCrearCandidat.Name = "buttonCrearCandidat";
            buttonCrearCandidat.Size = new Size(123, 23);
            buttonCrearCandidat.TabIndex = 13;
            buttonCrearCandidat.Text = "Crear Candidat";
            buttonCrearCandidat.UseVisualStyleBackColor = true;
            buttonCrearCandidat.Click += buttonCrearCandidat_Click;
            // 
            // textBoxNomCandidat
            // 
            textBoxNomCandidat.Location = new Point(202, 55);
            textBoxNomCandidat.Name = "textBoxNomCandidat";
            textBoxNomCandidat.Size = new Size(150, 23);
            textBoxNomCandidat.TabIndex = 12;
            textBoxNomCandidat.TextChanged += textBoxNomCandidat_TextChanged;
            textBoxNomCandidat.KeyPress += textBoxNomCandidat_KeyPress;
            // 
            // FormCandidat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 274);
            Controls.Add(buttonVolver);
            Controls.Add(label1);
            Controls.Add(buttonCrearCandidat);
            Controls.Add(textBoxNomCandidat);
            Name = "FormCandidat";
            Text = "FormCandidat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVolver;
        private Label label1;
        private Button buttonCrearCandidat;
        private TextBox textBoxNomCandidat;
    }
}