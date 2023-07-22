namespace EleccionsM2.Views
{
    partial class FormTaula
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
            label2 = new Label();
            textBoxCensTaula = new TextBox();
            label1 = new Label();
            buttonCrearTaula = new Button();
            textBoxNomTaula = new TextBox();
            SuspendLayout();
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(512, 381);
            buttonVolver.Margin = new Padding(3, 4, 3, 4);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(141, 31);
            buttonVolver.TabIndex = 11;
            buttonVolver.Text = "Tornar al Main";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 163);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 10;
            label2.Text = "Cens Taula";
            // 
            // textBoxCensTaula
            // 
            textBoxCensTaula.Location = new Point(233, 159);
            textBoxCensTaula.Margin = new Padding(3, 4, 3, 4);
            textBoxCensTaula.Name = "textBoxCensTaula";
            textBoxCensTaula.Size = new Size(83, 27);
            textBoxCensTaula.TabIndex = 9;
            textBoxCensTaula.TextChanged += textBoxCensTaula_TextChanged;
            textBoxCensTaula.KeyPress += textBoxCensTaula_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 69);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 8;
            label1.Text = "Nom Taula";
            // 
            // buttonCrearTaula
            // 
            buttonCrearTaula.Location = new Point(147, 281);
            buttonCrearTaula.Margin = new Padding(3, 4, 3, 4);
            buttonCrearTaula.Name = "buttonCrearTaula";
            buttonCrearTaula.Size = new Size(141, 31);
            buttonCrearTaula.TabIndex = 7;
            buttonCrearTaula.Text = "Crear Taula";
            buttonCrearTaula.UseVisualStyleBackColor = true;
            buttonCrearTaula.Click += buttonCrearTaula_Click;
            // 
            // textBoxNomTaula
            // 
            textBoxNomTaula.Location = new Point(233, 65);
            textBoxNomTaula.Margin = new Padding(3, 4, 3, 4);
            textBoxNomTaula.Name = "textBoxNomTaula";
            textBoxNomTaula.Size = new Size(132, 27);
            textBoxNomTaula.TabIndex = 6;
            textBoxNomTaula.TextChanged += textBoxNomTaula_TextChanged;
            textBoxNomTaula.KeyPress += textBoxNomTaula_KeyPress;
            // 
            // FormTaula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 433);
            Controls.Add(buttonVolver);
            Controls.Add(label2);
            Controls.Add(textBoxCensTaula);
            Controls.Add(label1);
            Controls.Add(buttonCrearTaula);
            Controls.Add(textBoxNomTaula);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTaula";
            Text = "FormTaula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVolver;
        private Label label2;
        private TextBox textBoxCensTaula;
        private Label label1;
        private Button buttonCrearTaula;
        private TextBox textBoxNomTaula;
    }
}