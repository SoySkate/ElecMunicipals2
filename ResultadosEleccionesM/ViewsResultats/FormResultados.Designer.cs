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
            textBoxCensTaula = new TextBox();
            label5 = new Label();
            panelCheckingVots = new Panel();
            buttonAviso = new Button();
            labelAviso = new Label();
            textBoxVotsTotals = new TextBox();
            labelVotsTotals = new Label();
            dataGridViewVotsPartit = new DataGridView();
            labelDesarResultats = new Label();
            buttonDesarResultats = new Button();
            panel1.SuspendLayout();
            panelCheckingVots.SuspendLayout();
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
            comboBoxTaules.MouseClick += comboBoxTaules_MouseClick;
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
            comboBoxMunicipis.MouseClick += comboBoxMunicipis_MouseClick;
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
            textBoxVotsBlanc.Location = new Point(497, 260);
            textBoxVotsBlanc.Margin = new Padding(3, 4, 3, 4);
            textBoxVotsBlanc.Name = "textBoxVotsBlanc";
            textBoxVotsBlanc.Size = new Size(114, 27);
            textBoxVotsBlanc.TabIndex = 4;
            // 
            // textBoxVotsNuls
            // 
            textBoxVotsNuls.Location = new Point(497, 416);
            textBoxVotsNuls.Margin = new Padding(3, 4, 3, 4);
            textBoxVotsNuls.Name = "textBoxVotsNuls";
            textBoxVotsNuls.Size = new Size(114, 27);
            textBoxVotsNuls.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 223);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 6;
            label3.Text = "Vots Blanc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 380);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Vots Nuls";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxCensTaula);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panelCheckingVots);
            panel1.Controls.Add(textBoxVotsTotals);
            panel1.Controls.Add(labelVotsTotals);
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
            // textBoxCensTaula
            // 
            textBoxCensTaula.BorderStyle = BorderStyle.None;
            textBoxCensTaula.Location = new Point(567, 0);
            textBoxCensTaula.Margin = new Padding(3, 4, 3, 4);
            textBoxCensTaula.Name = "textBoxCensTaula";
            textBoxCensTaula.ReadOnly = true;
            textBoxCensTaula.Size = new Size(74, 20);
            textBoxCensTaula.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 11;
            label5.Text = "Cens Taula: ";
            // 
            // panelCheckingVots
            // 
            panelCheckingVots.BackColor = Color.Yellow;
            panelCheckingVots.Controls.Add(buttonAviso);
            panelCheckingVots.Controls.Add(labelAviso);
            panelCheckingVots.Location = new Point(94, 157);
            panelCheckingVots.Margin = new Padding(3, 4, 3, 4);
            panelCheckingVots.Name = "panelCheckingVots";
            panelCheckingVots.Size = new Size(336, 215);
            panelCheckingVots.TabIndex = 9;
            panelCheckingVots.Visible = false;
            // 
            // buttonAviso
            // 
            buttonAviso.Location = new Point(218, 155);
            buttonAviso.Margin = new Padding(3, 4, 3, 4);
            buttonAviso.Name = "buttonAviso";
            buttonAviso.Size = new Size(61, 31);
            buttonAviso.TabIndex = 1;
            buttonAviso.Text = "OK";
            buttonAviso.UseVisualStyleBackColor = true;
            buttonAviso.Click += buttonAviso_Click;
            // 
            // labelAviso
            // 
            labelAviso.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAviso.ForeColor = Color.Red;
            labelAviso.Location = new Point(31, 36);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(288, 149);
            labelAviso.TabIndex = 0;
            labelAviso.Text = "La suma dels vots totals ha de coincidir amb els Vots Totals!";
            // 
            // textBoxVotsTotals
            // 
            textBoxVotsTotals.Location = new Point(491, 85);
            textBoxVotsTotals.Margin = new Padding(3, 4, 3, 4);
            textBoxVotsTotals.Name = "textBoxVotsTotals";
            textBoxVotsTotals.Size = new Size(114, 27);
            textBoxVotsTotals.TabIndex = 9;
            // 
            // labelVotsTotals
            // 
            labelVotsTotals.AutoSize = true;
            labelVotsTotals.Location = new Point(512, 48);
            labelVotsTotals.Name = "labelVotsTotals";
            labelVotsTotals.Size = new Size(80, 20);
            labelVotsTotals.TabIndex = 10;
            labelVotsTotals.Text = "Vots Totals";
            // 
            // dataGridViewVotsPartit
            // 
            dataGridViewVotsPartit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVotsPartit.Location = new Point(51, 37);
            dataGridViewVotsPartit.Margin = new Padding(3, 4, 3, 4);
            dataGridViewVotsPartit.Name = "dataGridViewVotsPartit";
            dataGridViewVotsPartit.RowHeadersWidth = 51;
            dataGridViewVotsPartit.RowTemplate.Height = 25;
            dataGridViewVotsPartit.Size = new Size(415, 452);
            dataGridViewVotsPartit.TabIndex = 8;
            // 
            // labelDesarResultats
            // 
            labelDesarResultats.AutoSize = true;
            labelDesarResultats.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            labelDesarResultats.Location = new Point(14, 448);
            labelDesarResultats.Name = "labelDesarResultats";
            labelDesarResultats.Size = new Size(250, 25);
            labelDesarResultats.TabIndex = 9;
            labelDesarResultats.Text = "Desar Resultats Actual Taula:";
            // 
            // buttonDesarResultats
            // 
            buttonDesarResultats.Location = new Point(75, 487);
            buttonDesarResultats.Margin = new Padding(3, 4, 3, 4);
            buttonDesarResultats.Name = "buttonDesarResultats";
            buttonDesarResultats.Size = new Size(86, 31);
            buttonDesarResultats.TabIndex = 10;
            buttonDesarResultats.Text = "Desar";
            buttonDesarResultats.UseVisualStyleBackColor = true;
            buttonDesarResultats.Click += buttonDesarResultats_Click;
            // 
            // FormResultados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonDesarResultats);
            Controls.Add(labelDesarResultats);
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
            panelCheckingVots.ResumeLayout(false);
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
        private TextBox textBoxVotsTotals;
        private Label labelVotsTotals;
        private Panel panelCheckingVots;
        private Label labelAviso;
        private Button buttonAviso;
        private Label labelDesarResultats;
        private Button buttonDesarResultats;
        private TextBox textBoxCensTaula;
        private Label label5;
    }
}