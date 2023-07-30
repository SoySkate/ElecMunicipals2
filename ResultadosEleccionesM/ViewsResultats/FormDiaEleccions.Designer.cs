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
            dataGridViewEscons.Location = new Point(55, 116);
            dataGridViewEscons.Name = "dataGridViewEscons";
            dataGridViewEscons.RowHeadersWidth = 51;
            dataGridViewEscons.RowTemplate.Height = 29;
            dataGridViewEscons.Size = new Size(857, 356);
            dataGridViewEscons.TabIndex = 0;
            // 
            // dataGridViewRegidors
            // 
            dataGridViewRegidors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegidors.Location = new Point(1049, 226);
            dataGridViewRegidors.Name = "dataGridViewRegidors";
            dataGridViewRegidors.RowHeadersWidth = 51;
            dataGridViewRegidors.RowTemplate.Height = 29;
            dataGridViewRegidors.Size = new Size(330, 454);
            dataGridViewRegidors.TabIndex = 1;
            // 
            // comboBoxMunicipisDiaE
            // 
            comboBoxMunicipisDiaE.FormattingEnabled = true;
            comboBoxMunicipisDiaE.Location = new Point(55, 48);
            comboBoxMunicipisDiaE.Name = "comboBoxMunicipisDiaE";
            comboBoxMunicipisDiaE.Size = new Size(151, 28);
            comboBoxMunicipisDiaE.TabIndex = 2;
            comboBoxMunicipisDiaE.SelectedIndexChanged += comboBoxMunicipisDiaE_SelectedIndexChanged;
            // 
            // dataGridViewTaula
            // 
            dataGridViewTaula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaula.Location = new Point(58, 570);
            dataGridViewTaula.Name = "dataGridViewTaula";
            dataGridViewTaula.RowHeadersWidth = 51;
            dataGridViewTaula.RowTemplate.Height = 29;
            dataGridViewTaula.Size = new Size(857, 356);
            dataGridViewTaula.TabIndex = 3;
            // 
            // labelListRegidors
            // 
            labelListRegidors.AutoSize = true;
            labelListRegidors.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelListRegidors.Location = new Point(1123, 187);
            labelListRegidors.Name = "labelListRegidors";
            labelListRegidors.Size = new Size(119, 23);
            labelListRegidors.TabIndex = 4;
            labelListRegidors.Text = "Llista Regidors";
            // 
            // labelTaulesMunicipi
            // 
            labelTaulesMunicipi.AutoSize = true;
            labelTaulesMunicipi.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
            labelTaulesMunicipi.Location = new Point(384, 533);
            labelTaulesMunicipi.Name = "labelTaulesMunicipi";
            labelTaulesMunicipi.Size = new Size(143, 25);
            labelTaulesMunicipi.TabIndex = 5;
            labelTaulesMunicipi.Text = "Taules Municipi";
            // 
            // textBoxNumRegidors
            // 
            textBoxNumRegidors.Location = new Point(1259, 180);
            textBoxNumRegidors.Name = "textBoxNumRegidors";
            textBoxNumRegidors.Size = new Size(54, 27);
            textBoxNumRegidors.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(384, 75);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 7;
            label1.Text = "Resultats Eleccions";
            // 
            // FormDiaEleccions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 955);
            Controls.Add(label1);
            Controls.Add(textBoxNumRegidors);
            Controls.Add(labelTaulesMunicipi);
            Controls.Add(labelListRegidors);
            Controls.Add(dataGridViewTaula);
            Controls.Add(comboBoxMunicipisDiaE);
            Controls.Add(dataGridViewRegidors);
            Controls.Add(dataGridViewEscons);
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