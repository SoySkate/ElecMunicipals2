namespace ResultadosEleccionesM.ViewsResultats
{
    partial class FormMenu
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
            labelTitol = new Label();
            buttonDiaEleccions = new Button();
            buttonAfegirResultats = new Button();
            buttonConfiguracio = new Button();
            SuspendLayout();
            // 
            // labelTitol
            // 
            labelTitol.AutoSize = true;
            labelTitol.Font = new Font("Georgia", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitol.Location = new Point(238, 57);
            labelTitol.Name = "labelTitol";
            labelTitol.Size = new Size(311, 27);
            labelTitol.TabIndex = 0;
            labelTitol.Text = "Menú d'Eleccions Municipals";
            // 
            // buttonDiaEleccions
            // 
            buttonDiaEleccions.Location = new Point(320, 155);
            buttonDiaEleccions.Name = "buttonDiaEleccions";
            buttonDiaEleccions.Size = new Size(144, 33);
            buttonDiaEleccions.TabIndex = 1;
            buttonDiaEleccions.Text = "Dia Eleccions";
            buttonDiaEleccions.UseVisualStyleBackColor = true;
            buttonDiaEleccions.Click += buttonDiaEleccions_Click;
            // 
            // buttonAfegirResultats
            // 
            buttonAfegirResultats.Location = new Point(320, 237);
            buttonAfegirResultats.Name = "buttonAfegirResultats";
            buttonAfegirResultats.Size = new Size(144, 36);
            buttonAfegirResultats.TabIndex = 2;
            buttonAfegirResultats.Text = "Afegir Resultats";
            buttonAfegirResultats.UseVisualStyleBackColor = true;
            buttonAfegirResultats.Click += buttonAfegirResultats_Click_1;
            // 
            // buttonConfiguracio
            // 
            buttonConfiguracio.Location = new Point(320, 321);
            buttonConfiguracio.Name = "buttonConfiguracio";
            buttonConfiguracio.Size = new Size(144, 33);
            buttonConfiguracio.TabIndex = 3;
            buttonConfiguracio.Text = "Configuració";
            buttonConfiguracio.UseVisualStyleBackColor = true;
            buttonConfiguracio.Click += buttonConfiguracio_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(buttonConfiguracio);
            Controls.Add(buttonAfegirResultats);
            Controls.Add(buttonDiaEleccions);
            Controls.Add(labelTitol);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitol;
        private Button buttonDiaEleccions;
        private Button buttonAfegirResultats;
        private Button buttonConfiguracio;
    }
}