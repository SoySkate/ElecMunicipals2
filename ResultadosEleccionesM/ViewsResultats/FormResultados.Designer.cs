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
            panelMainModal = new Panel();
            panel3 = new Panel();
            buttonAddTotalVots = new Button();
            labelTotalVots = new Label();
            textBoxNumVotsTotals = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVotsPartit).BeginInit();
            panelMainModal.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxTaules
            // 
            comboBoxTaules.FormattingEnabled = true;
            comboBoxTaules.Location = new Point(48, 166);
            comboBoxTaules.Name = "comboBoxTaules";
            comboBoxTaules.Size = new Size(121, 23);
            comboBoxTaules.TabIndex = 0;
            comboBoxTaules.SelectedIndexChanged += comboBoxTaules_SelectedIndexChanged;
            // 
            // comboBoxMunicipis
            // 
            comboBoxMunicipis.FormattingEnabled = true;
            comboBoxMunicipis.Location = new Point(48, 49);
            comboBoxMunicipis.Name = "comboBoxMunicipis";
            comboBoxMunicipis.Size = new Size(121, 23);
            comboBoxMunicipis.TabIndex = 1;
            comboBoxMunicipis.SelectedIndexChanged += comboBoxMunicipis_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 21);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Municipis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 139);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Taules";
            // 
            // textBoxVotsBlanc
            // 
            textBoxVotsBlanc.Location = new Point(433, 85);
            textBoxVotsBlanc.Name = "textBoxVotsBlanc";
            textBoxVotsBlanc.Size = new Size(100, 23);
            textBoxVotsBlanc.TabIndex = 4;
            // 
            // textBoxVotsNuls
            // 
            textBoxVotsNuls.Location = new Point(433, 202);
            textBoxVotsNuls.Name = "textBoxVotsNuls";
            textBoxVotsNuls.Size = new Size(100, 23);
            textBoxVotsNuls.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 57);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Vots Blanc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 175);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
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
            panel1.Location = new Point(201, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 417);
            panel1.TabIndex = 8;
            panel1.Visible = false;
            // 
            // dataGridViewVotsPartit
            // 
            dataGridViewVotsPartit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVotsPartit.Location = new Point(65, 28);
            dataGridViewVotsPartit.Name = "dataGridViewVotsPartit";
            dataGridViewVotsPartit.RowTemplate.Height = 25;
            dataGridViewVotsPartit.Size = new Size(343, 339);
            dataGridViewVotsPartit.TabIndex = 8;
            // 
            // panelMainModal
            // 
            panelMainModal.Controls.Add(panel3);
            panelMainModal.Location = new Point(204, 12);
            panelMainModal.Name = "panelMainModal";
            panelMainModal.Size = new Size(558, 408);
            panelMainModal.TabIndex = 9;
            panelMainModal.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonAddTotalVots);
            panel3.Controls.Add(labelTotalVots);
            panel3.Controls.Add(textBoxNumVotsTotals);
            panel3.Location = new Point(85, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(405, 148);
            panel3.TabIndex = 2;
            // 
            // buttonAddTotalVots
            // 
            buttonAddTotalVots.Location = new Point(168, 112);
            buttonAddTotalVots.Name = "buttonAddTotalVots";
            buttonAddTotalVots.Size = new Size(52, 23);
            buttonAddTotalVots.TabIndex = 2;
            buttonAddTotalVots.Text = "OK";
            buttonAddTotalVots.UseVisualStyleBackColor = true;
            //buttonAddTotalVots.Click += buttonAddTotalVots_Click;
            // 
            // labelTotalVots
            // 
            labelTotalVots.AutoSize = true;
            labelTotalVots.Font = new Font("Segoe UI", 12.75F, FontStyle.Underline, GraphicsUnit.Point);
            labelTotalVots.Location = new Point(42, 36);
            labelTotalVots.Name = "labelTotalVots";
            labelTotalVots.Size = new Size(299, 23);
            labelTotalVots.TabIndex = 1;
            labelTotalVots.Text = "Introdueix el Total de Vots de la Taula:";
            // 
            // textBoxNumVotsTotals
            // 
            textBoxNumVotsTotals.Location = new Point(143, 83);
            textBoxNumVotsTotals.Name = "textBoxNumVotsTotals";
            textBoxNumVotsTotals.Size = new Size(100, 23);
            textBoxNumVotsTotals.TabIndex = 0;
            // 
            // FormResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelMainModal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMunicipis);
            Controls.Add(comboBoxTaules);
            Name = "FormResultados";
            Text = "FormResultados";
            FormClosing += FormResultados_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVotsPartit).EndInit();
            panelMainModal.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panelMainModal;
        private Label labelTotalVots;
        private TextBox textBoxNumVotsTotals;
        private Panel panel3;
        private Button buttonAddTotalVots;
    }
}