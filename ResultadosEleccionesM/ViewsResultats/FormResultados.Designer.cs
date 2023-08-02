namespace ResultadosEleccionesM
{
    partial class FormResultados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxTaules = new ComboBox();
            comboBoxMunicipis = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxVotsBlanc = new TextBox();
            textBoxVotsNuls = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            dataGridViewVotsPartit = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVotsPartit).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTaules
            // 
            comboBoxTaules.FormattingEnabled = true;
            comboBoxTaules.Location = new Point(55, 221);
            comboBoxTaules.Margin = new Padding(3, 4, 3, 4);
            comboBoxTaules.Name = "comboBoxTaules";
            comboBoxTaules.Size = new Size(138, 28);
            comboBoxTaules.TabIndex = 0;
            comboBoxTaules.SelectedIndexChanged += comboBoxTaules_SelectedIndexChanged;
            // 
            // comboBoxMunicipis
            // 
            comboBoxMunicipis.FormattingEnabled = true;
            comboBoxMunicipis.Location = new Point(55, 65);
            comboBoxMunicipis.Margin = new Padding(3, 4, 3, 4);
            comboBoxMunicipis.Name = "comboBoxMunicipis";
            comboBoxMunicipis.Size = new Size(138, 28);
            comboBoxMunicipis.TabIndex = 1;
            comboBoxMunicipis.SelectedIndexChanged += comboBoxMunicipis_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 28);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 2;
            label1.Text = "Municipis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 185);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Taules";
            // 
            // textBoxVotsBlanc
            // 
            textBoxVotsBlanc.Location = new Point(495, 113);
            textBoxVotsBlanc.Margin = new Padding(3, 4, 3, 4);
            textBoxVotsBlanc.Name = "textBoxVotsBlanc";
            textBoxVotsBlanc.Size = new Size(114, 27);
            textBoxVotsBlanc.TabIndex = 4;
            // 
            // textBoxVotsNuls
            // 
            textBoxVotsNuls.Location = new Point(495, 269);
            textBoxVotsNuls.Margin = new Padding(3, 4, 3, 4);
            textBoxVotsNuls.Name = "textBoxVotsNuls";
            textBoxVotsNuls.Size = new Size(114, 27);
            textBoxVotsNuls.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 76);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 6;
            label3.Text = "Vots Blanc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 233);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Vots Nuls";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewVotsPartit);
            panel1.Controls.Add(textBoxVotsBlanc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxVotsNuls);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(230, 28);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 556);
            panel1.TabIndex = 8;
            panel1.Visible = false;
            // 
            // dataGridViewVotsPartit
            // 
            dataGridViewVotsPartit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVotsPartit.Location = new Point(74, 37);
            dataGridViewVotsPartit.Margin = new Padding(3, 4, 3, 4);
            dataGridViewVotsPartit.Name = "dataGridViewVotsPartit";
            dataGridViewVotsPartit.RowHeadersWidth = 51;
            dataGridViewVotsPartit.RowTemplate.Height = 25;
            dataGridViewVotsPartit.Size = new Size(392, 452);
            dataGridViewVotsPartit.TabIndex = 8;
            // 
            // FormResultados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMunicipis);
            Controls.Add(comboBoxTaules);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormResultados";
            Text = "FormResultados";
            FormClosing += FormResultados_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVotsPartit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTaules;
        private ComboBox comboBoxMunicipis;
        private Label label1;
        private Label label2;
        private TextBox textBoxVotsBlanc;
        private TextBox textBoxVotsNuls;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private DataGridView dataGridViewVotsPartit;
    }
}