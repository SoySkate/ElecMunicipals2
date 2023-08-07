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
            labelTitol.Location = new Point(229, 45);
            labelTitol.Name = "labelTitol";
            labelTitol.Size = new Size(245, 21);
            labelTitol.TabIndex = 0;
            labelTitol.Text = "Menú d'Eleccions Municipals";
            // 
            // buttonDiaEleccions
            // 
            buttonDiaEleccions.Location = new Point(280, 116);
            buttonDiaEleccions.Margin = new Padding(3, 2, 3, 2);
            buttonDiaEleccions.Name = "buttonDiaEleccions";
            buttonDiaEleccions.Size = new Size(126, 25);
            buttonDiaEleccions.TabIndex = 1;
            buttonDiaEleccions.Text = "Dia Eleccions";
            buttonDiaEleccions.UseVisualStyleBackColor = true;
            buttonDiaEleccions.Click += buttonDiaEleccions_Click;
            // 
            // buttonAfegirResultats
            // 
            buttonAfegirResultats.Location = new Point(280, 178);
            buttonAfegirResultats.Margin = new Padding(3, 2, 3, 2);
            buttonAfegirResultats.Name = "buttonAfegirResultats";
            buttonAfegirResultats.Size = new Size(126, 27);
            buttonAfegirResultats.TabIndex = 2;
            buttonAfegirResultats.Text = "Afegir Resultats";
            buttonAfegirResultats.UseVisualStyleBackColor = true;
            buttonAfegirResultats.Click += buttonAfegirResultats_Click_1;
            // 
            // buttonConfiguracio
            // 
            buttonConfiguracio.Location = new Point(280, 241);
            buttonConfiguracio.Margin = new Padding(3, 2, 3, 2);
            buttonConfiguracio.Name = "buttonConfiguracio";
            buttonConfiguracio.Size = new Size(126, 25);
            buttonConfiguracio.TabIndex = 3;
            buttonConfiguracio.Text = "Configuració";
            buttonConfiguracio.UseVisualStyleBackColor = true;
            buttonConfiguracio.Click += buttonConfiguracio_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonConfiguracio);
            Controls.Add(buttonAfegirResultats);
            Controls.Add(buttonDiaEleccions);
            Controls.Add(labelTitol);
            Margin = new Padding(3, 2, 3, 2);
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