namespace ResultadosEleccionesM.ViewsResultats
{
    partial class FormDiaEleccions
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
            dataGridViewEscons = new DataGridView();
            dataGridViewRegidors = new DataGridView();
            comboBoxMunicipisDiaE = new ComboBox();
            dataGridViewTaula = new DataGridView();
            labelListRegidors = new Label();
            labelTaulesMunicipi = new Label();
            textBoxNumRegidors = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEscons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegidors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaula).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEscons
            // 
            dataGridViewEscons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEscons.Location = new Point(48, 87);
            dataGridViewEscons.Margin = new Padding(3, 2, 3, 2);
            dataGridViewEscons.Name = "dataGridViewEscons";
            dataGridViewEscons.RowHeadersWidth = 51;
            dataGridViewEscons.RowTemplate.Height = 29;
            dataGridViewEscons.Size = new Size(750, 267);
            dataGridViewEscons.TabIndex = 0;
            // 
            // dataGridViewRegidors
            // 
            dataGridViewRegidors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegidors.Location = new Point(918, 170);
            dataGridViewRegidors.Margin = new Padding(3, 2, 3, 2);
            dataGridViewRegidors.Name = "dataGridViewRegidors";
            dataGridViewRegidors.RowHeadersWidth = 51;
            dataGridViewRegidors.RowTemplate.Height = 29;
            dataGridViewRegidors.Size = new Size(289, 340);
            dataGridViewRegidors.TabIndex = 1;
            // 
            // comboBoxMunicipisDiaE
            // 
            comboBoxMunicipisDiaE.FormattingEnabled = true;
            comboBoxMunicipisDiaE.Location = new Point(48, 36);
            comboBoxMunicipisDiaE.Margin = new Padding(3, 2, 3, 2);
            comboBoxMunicipisDiaE.Name = "comboBoxMunicipisDiaE";
            comboBoxMunicipisDiaE.Size = new Size(133, 23);
            comboBoxMunicipisDiaE.TabIndex = 2;
            comboBoxMunicipisDiaE.SelectedIndexChanged += comboBoxMunicipisDiaE_SelectedIndexChanged;
            // 
            // dataGridViewTaula
            // 
            dataGridViewTaula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaula.Location = new Point(51, 428);
            dataGridViewTaula.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTaula.Name = "dataGridViewTaula";
            dataGridViewTaula.RowHeadersWidth = 51;
            dataGridViewTaula.RowTemplate.Height = 29;
            dataGridViewTaula.Size = new Size(750, 267);
            dataGridViewTaula.TabIndex = 3;
            // 
            // labelListRegidors
            // 
            labelListRegidors.AutoSize = true;
            labelListRegidors.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelListRegidors.Location = new Point(983, 140);
            labelListRegidors.Name = "labelListRegidors";
            labelListRegidors.Size = new Size(97, 19);
            labelListRegidors.TabIndex = 4;
            labelListRegidors.Text = "Llista Regidors";
            // 
            // labelTaulesMunicipi
            // 
            labelTaulesMunicipi.AutoSize = true;
            labelTaulesMunicipi.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
            labelTaulesMunicipi.Location = new Point(336, 400);
            labelTaulesMunicipi.Name = "labelTaulesMunicipi";
            labelTaulesMunicipi.Size = new Size(110, 20);
            labelTaulesMunicipi.TabIndex = 5;
            labelTaulesMunicipi.Text = "Taules Municipi";
            // 
            // textBoxNumRegidors
            // 
            textBoxNumRegidors.Location = new Point(1102, 135);
            textBoxNumRegidors.Margin = new Padding(3, 2, 3, 2);
            textBoxNumRegidors.Name = "textBoxNumRegidors";
            textBoxNumRegidors.Size = new Size(48, 23);
            textBoxNumRegidors.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(336, 56);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 7;
            label1.Text = "Resultats Eleccions";
            // 
            // FormDiaEleccions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 727);
            Controls.Add(label1);
            Controls.Add(textBoxNumRegidors);
            Controls.Add(labelTaulesMunicipi);
            Controls.Add(labelListRegidors);
            Controls.Add(dataGridViewTaula);
            Controls.Add(comboBoxMunicipisDiaE);
            Controls.Add(dataGridViewRegidors);
            Controls.Add(dataGridViewEscons);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDiaEleccions";
            Text = "FormDiaEleccions";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEscons).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegidors).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEscons;
        private DataGridView dataGridViewRegidors;
        private ComboBox comboBoxMunicipisDiaE;
        private DataGridView dataGridViewTaula;
        private Label labelListRegidors;
        private Label labelTaulesMunicipi;
        private TextBox textBoxNumRegidors;
        private Label label1;
    }
}