namespace EleccionsM2.Views
{
    partial class FormResultatsT
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
            labelVblanc = new Label();
            textBoxVotsBlanc = new TextBox();
            textBoxVotsNulls = new TextBox();
            labelVotsNull = new Label();
            dataGridViewVotsPartit = new DataGridView();
            textBoxVotsPartit = new TextBox();
            labelVotsPartitIndividual = new Label();
            buttonAddVotPartit = new Button();
            buttonAddResultatTaula = new Button();
            labelLlistaVots = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVotsPartit).BeginInit();
            SuspendLayout();
            // 
            // labelVblanc
            // 
            labelVblanc.AutoSize = true;
            labelVblanc.Location = new Point(50, 37);
            labelVblanc.Name = "labelVblanc";
            labelVblanc.Size = new Size(80, 15);
            labelVblanc.TabIndex = 0;
            labelVblanc.Text = "Vots en Blanc:";
            // 
            // textBoxVotsBlanc
            // 
            textBoxVotsBlanc.Location = new Point(151, 34);
            textBoxVotsBlanc.Name = "textBoxVotsBlanc";
            textBoxVotsBlanc.Size = new Size(100, 23);
            textBoxVotsBlanc.TabIndex = 1;
            textBoxVotsBlanc.KeyPress += textBoxVotsBlanc_KeyPress;
            // 
            // textBoxVotsNulls
            // 
            textBoxVotsNulls.Location = new Point(427, 34);
            textBoxVotsNulls.Name = "textBoxVotsNulls";
            textBoxVotsNulls.Size = new Size(100, 23);
            textBoxVotsNulls.TabIndex = 3;
            textBoxVotsNulls.KeyPress += textBoxVotsNulls_KeyPress;
            // 
            // labelVotsNull
            // 
            labelVotsNull.AutoSize = true;
            labelVotsNull.Location = new Point(344, 37);
            labelVotsNull.Name = "labelVotsNull";
            labelVotsNull.Size = new Size(62, 15);
            labelVotsNull.TabIndex = 2;
            labelVotsNull.Text = "Vots Nulls:";
            // 
            // dataGridViewVotsPartit
            // 
            dataGridViewVotsPartit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVotsPartit.Location = new Point(274, 136);
            dataGridViewVotsPartit.Name = "dataGridViewVotsPartit";
            dataGridViewVotsPartit.RowTemplate.Height = 25;
            dataGridViewVotsPartit.Size = new Size(240, 184);
            dataGridViewVotsPartit.TabIndex = 4;
            // 
            // textBoxVotsPartit
            // 
            textBoxVotsPartit.Location = new Point(151, 159);
            textBoxVotsPartit.Name = "textBoxVotsPartit";
            textBoxVotsPartit.Size = new Size(100, 23);
            textBoxVotsPartit.TabIndex = 6;
            textBoxVotsPartit.KeyPress += textBoxVotsPartit_KeyPress;
            // 
            // labelVotsPartitIndividual
            // 
            labelVotsPartitIndividual.AutoSize = true;
            labelVotsPartitIndividual.Location = new Point(59, 162);
            labelVotsPartitIndividual.Name = "labelVotsPartitIndividual";
            labelVotsPartitIndividual.Size = new Size(58, 15);
            labelVotsPartitIndividual.TabIndex = 5;
            labelVotsPartitIndividual.Text = "Vot Partit:\r\n";
            // 
            // buttonAddVotPartit
            // 
            buttonAddVotPartit.Location = new Point(151, 209);
            buttonAddVotPartit.Name = "buttonAddVotPartit";
            buttonAddVotPartit.Size = new Size(100, 23);
            buttonAddVotPartit.TabIndex = 7;
            buttonAddVotPartit.Text = "AddNumVots";
            buttonAddVotPartit.UseVisualStyleBackColor = true;
            buttonAddVotPartit.Click += buttonAddVotPartit_Click;
            // 
            // buttonAddResultatTaula
            // 
            buttonAddResultatTaula.Location = new Point(331, 326);
            buttonAddResultatTaula.Name = "buttonAddResultatTaula";
            buttonAddResultatTaula.Size = new Size(128, 23);
            buttonAddResultatTaula.TabIndex = 8;
            buttonAddResultatTaula.Text = "Add Resultats Taula";
            buttonAddResultatTaula.UseVisualStyleBackColor = true;
            buttonAddResultatTaula.Click += buttonAddResultatTaula_Click;
            // 
            // labelLlistaVots
            // 
            labelLlistaVots.AutoSize = true;
            labelLlistaVots.Location = new Point(344, 118);
            labelLlistaVots.Name = "labelLlistaVots";
            labelLlistaVots.Size = new Size(90, 15);
            labelLlistaVots.TabIndex = 9;
            labelLlistaVots.Text = "Llista Vots Partit\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 84);
            label1.Name = "label1";
            label1.Size = new Size(512, 15);
            label1.TabIndex = 10;
            label1.Text = "_____________________________________________________________________________________________________";
            // 
            // FormResultatsT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 376);
            Controls.Add(label1);
            Controls.Add(labelLlistaVots);
            Controls.Add(buttonAddResultatTaula);
            Controls.Add(buttonAddVotPartit);
            Controls.Add(textBoxVotsPartit);
            Controls.Add(labelVotsPartitIndividual);
            Controls.Add(dataGridViewVotsPartit);
            Controls.Add(textBoxVotsNulls);
            Controls.Add(labelVotsNull);
            Controls.Add(textBoxVotsBlanc);
            Controls.Add(labelVblanc);
            Name = "FormResultatsT";
            Text = "FormResultatsT";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVotsPartit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVblanc;
        private TextBox textBoxVotsBlanc;
        private TextBox textBoxVotsNulls;
        private Label labelVotsNull;
        private DataGridView dataGridViewVotsPartit;
        private TextBox textBoxVotsPartit;
        private Label labelVotsPartitIndividual;
        private Button buttonAddVotPartit;
        private Button buttonAddResultatTaula;
        private Label labelLlistaVots;
        private Label label1;
    }
}