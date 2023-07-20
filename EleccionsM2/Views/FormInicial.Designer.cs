namespace EleccionsM2.Views
{
    partial class FormInicial
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
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomMunicipiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroRegidorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            button1 = new Button();
            dataGridViewMunicipis = new DataGridView();
            dataGridViewPartits = new DataGridView();
            dataGridViewCandidats = new DataGridView();
            btnGuardarDades = new Button();
            panel1 = new Panel();
            buttonDeleteTaula = new Button();
            buttonAddTaula = new Button();
            label4 = new Label();
            label1 = new Label();
            textBoxCensTaula = new TextBox();
            dataGridViewTaules = new DataGridView();
            textBoxNomTaula = new TextBox();
            buttonDeleteCandidat = new Button();
            buttonDeletePartit = new Button();
            buttonDeleteMuni = new Button();
            buttonAddCandidat = new Button();
            buttonAddPartit = new Button();
            buttonAddMuni = new Button();
            label3 = new Label();
            textBoxNomCandidat = new TextBox();
            label2 = new Label();
            textBoxNomPartit = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMunicipis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCandidats).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaules).BeginInit();
            SuspendLayout();
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nomMunicipiDataGridViewTextBoxColumn
            // 
            nomMunicipiDataGridViewTextBoxColumn.DataPropertyName = "nomMunicipi";
            nomMunicipiDataGridViewTextBoxColumn.HeaderText = "nomMunicipi";
            nomMunicipiDataGridViewTextBoxColumn.Name = "nomMunicipiDataGridViewTextBoxColumn";
            // 
            // numeroRegidorsDataGridViewTextBoxColumn
            // 
            numeroRegidorsDataGridViewTextBoxColumn.DataPropertyName = "numeroRegidors";
            numeroRegidorsDataGridViewTextBoxColumn.HeaderText = "numeroRegidors";
            numeroRegidorsDataGridViewTextBoxColumn.Name = "numeroRegidorsDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(12, 26);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 3;
            button1.Text = "Refrescar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewMunicipis
            // 
            dataGridViewMunicipis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMunicipis.Location = new Point(13, 78);
            dataGridViewMunicipis.Name = "dataGridViewMunicipis";
            dataGridViewMunicipis.RowTemplate.Height = 25;
            dataGridViewMunicipis.Size = new Size(255, 189);
            dataGridViewMunicipis.TabIndex = 4;
            dataGridViewMunicipis.DataSourceChanged += dataGridViewMunicipis_DataSourceChanged;
            // 
            // dataGridViewPartits
            // 
            dataGridViewPartits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartits.Location = new Point(288, 78);
            dataGridViewPartits.Name = "dataGridViewPartits";
            dataGridViewPartits.RowTemplate.Height = 25;
            dataGridViewPartits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPartits.Size = new Size(244, 189);
            dataGridViewPartits.TabIndex = 5;
            dataGridViewPartits.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // dataGridViewCandidats
            // 
            dataGridViewCandidats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCandidats.Location = new Point(548, 78);
            dataGridViewCandidats.Name = "dataGridViewCandidats";
            dataGridViewCandidats.RowTemplate.Height = 25;
            dataGridViewCandidats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCandidats.Size = new Size(244, 189);
            dataGridViewCandidats.TabIndex = 6;
            dataGridViewCandidats.SelectionChanged += dataGridView3_SelectionChanged;
            // 
            // btnGuardarDades
            // 
            btnGuardarDades.Anchor = AnchorStyles.Top;
            btnGuardarDades.Location = new Point(12, 516);
            btnGuardarDades.Name = "btnGuardarDades";
            btnGuardarDades.Size = new Size(67, 30);
            btnGuardarDades.TabIndex = 7;
            btnGuardarDades.Text = "Desar";
            btnGuardarDades.UseVisualStyleBackColor = true;
            btnGuardarDades.Click += btnGuardarDades_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(buttonDeleteTaula);
            panel1.Controls.Add(buttonAddTaula);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxCensTaula);
            panel1.Controls.Add(dataGridViewTaules);
            panel1.Controls.Add(textBoxNomTaula);
            panel1.Controls.Add(buttonDeleteCandidat);
            panel1.Controls.Add(buttonDeletePartit);
            panel1.Controls.Add(buttonDeleteMuni);
            panel1.Controls.Add(buttonAddCandidat);
            panel1.Controls.Add(buttonAddPartit);
            panel1.Controls.Add(buttonAddMuni);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxNomCandidat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxNomPartit);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(dataGridViewMunicipis);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridViewPartits);
            panel1.Controls.Add(dataGridViewCandidats);
            panel1.Location = new Point(106, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 523);
            panel1.TabIndex = 8;
            // 
            // buttonDeleteTaula
            // 
            buttonDeleteTaula.FlatStyle = FlatStyle.System;
            buttonDeleteTaula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteTaula.Location = new Point(352, 410);
            buttonDeleteTaula.Name = "buttonDeleteTaula";
            buttonDeleteTaula.Size = new Size(22, 27);
            buttonDeleteTaula.TabIndex = 28;
            buttonDeleteTaula.Text = "-";
            buttonDeleteTaula.UseVisualStyleBackColor = true;
            buttonDeleteTaula.Click += buttonDeleteTaula_Click;
            // 
            // buttonAddTaula
            // 
            buttonAddTaula.FlatStyle = FlatStyle.System;
            buttonAddTaula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddTaula.Location = new Point(352, 479);
            buttonAddTaula.Name = "buttonAddTaula";
            buttonAddTaula.Size = new Size(122, 27);
            buttonAddTaula.TabIndex = 27;
            buttonAddTaula.Text = "Afegir Taula";
            buttonAddTaula.UseVisualStyleBackColor = true;
            buttonAddTaula.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 334);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 26;
            label4.Text = "Nom i Cens Taula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 29);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 11;
            label1.Text = "Nom i Num regidors :";
            // 
            // textBoxCensTaula
            // 
            textBoxCensTaula.Location = new Point(352, 381);
            textBoxCensTaula.Name = "textBoxCensTaula";
            textBoxCensTaula.Size = new Size(65, 23);
            textBoxCensTaula.TabIndex = 25;
            // 
            // dataGridViewTaules
            // 
            dataGridViewTaules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaules.Location = new Point(16, 326);
            dataGridViewTaules.Name = "dataGridViewTaules";
            dataGridViewTaules.RowTemplate.Height = 25;
            dataGridViewTaules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTaules.Size = new Size(323, 189);
            dataGridViewTaules.TabIndex = 23;
            dataGridViewTaules.DataSourceChanged += dataGridViewTaules_DataSourceChanged;
            dataGridViewTaules.SelectionChanged += dataGridView4_SelectionChanged;
            // 
            // textBoxNomTaula
            // 
            textBoxNomTaula.Location = new Point(352, 352);
            textBoxNomTaula.Name = "textBoxNomTaula";
            textBoxNomTaula.Size = new Size(110, 23);
            textBoxNomTaula.TabIndex = 24;
            // 
            // buttonDeleteCandidat
            // 
            buttonDeleteCandidat.FlatStyle = FlatStyle.System;
            buttonDeleteCandidat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteCandidat.Location = new Point(756, 45);
            buttonDeleteCandidat.Name = "buttonDeleteCandidat";
            buttonDeleteCandidat.Size = new Size(22, 27);
            buttonDeleteCandidat.TabIndex = 22;
            buttonDeleteCandidat.Text = "-";
            buttonDeleteCandidat.UseVisualStyleBackColor = true;
            buttonDeleteCandidat.Click += buttonDeleteCandidat_Click;
            // 
            // buttonDeletePartit
            // 
            buttonDeletePartit.FlatStyle = FlatStyle.System;
            buttonDeletePartit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeletePartit.Location = new Point(498, 45);
            buttonDeletePartit.Name = "buttonDeletePartit";
            buttonDeletePartit.Size = new Size(22, 27);
            buttonDeletePartit.TabIndex = 21;
            buttonDeletePartit.Text = "-";
            buttonDeletePartit.UseVisualStyleBackColor = true;
            buttonDeletePartit.Click += buttonDeletePartit_Click;
            // 
            // buttonDeleteMuni
            // 
            buttonDeleteMuni.FlatStyle = FlatStyle.System;
            buttonDeleteMuni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteMuni.Location = new Point(230, 47);
            buttonDeleteMuni.Name = "buttonDeleteMuni";
            buttonDeleteMuni.Size = new Size(22, 27);
            buttonDeleteMuni.TabIndex = 20;
            buttonDeleteMuni.Text = "-";
            buttonDeleteMuni.UseVisualStyleBackColor = true;
            buttonDeleteMuni.Click += buttonDeleteMuni_Click;
            // 
            // buttonAddCandidat
            // 
            buttonAddCandidat.FlatStyle = FlatStyle.System;
            buttonAddCandidat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCandidat.Location = new Point(602, 273);
            buttonAddCandidat.Name = "buttonAddCandidat";
            buttonAddCandidat.Size = new Size(158, 27);
            buttonAddCandidat.TabIndex = 19;
            buttonAddCandidat.Text = "Afegir Candidat";
            buttonAddCandidat.UseVisualStyleBackColor = true;
            buttonAddCandidat.Click += buttonAddCandidat_Click;
            // 
            // buttonAddPartit
            // 
            buttonAddPartit.FlatStyle = FlatStyle.System;
            buttonAddPartit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddPartit.Location = new Point(338, 273);
            buttonAddPartit.Name = "buttonAddPartit";
            buttonAddPartit.Size = new Size(157, 27);
            buttonAddPartit.TabIndex = 18;
            buttonAddPartit.Text = "Afegir Partit";
            buttonAddPartit.UseVisualStyleBackColor = true;
            buttonAddPartit.Click += buttonAddPartit_Click;
            // 
            // buttonAddMuni
            // 
            buttonAddMuni.FlatStyle = FlatStyle.System;
            buttonAddMuni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddMuni.Location = new Point(58, 273);
            buttonAddMuni.Name = "buttonAddMuni";
            buttonAddMuni.Size = new Size(165, 27);
            buttonAddMuni.TabIndex = 17;
            buttonAddMuni.Text = "Afegir Municipi";
            buttonAddMuni.UseVisualStyleBackColor = true;
            buttonAddMuni.Click += buttonAddMuni_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 48);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 16;
            label3.Text = "Nom Candidat :";
            // 
            // textBoxNomCandidat
            // 
            textBoxNomCandidat.Location = new Point(650, 45);
            textBoxNomCandidat.Name = "textBoxNomCandidat";
            textBoxNomCandidat.Size = new Size(100, 23);
            textBoxNomCandidat.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 48);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 14;
            label2.Text = "Nom Partit :";
            // 
            // textBoxNomPartit
            // 
            textBoxNomPartit.Location = new Point(375, 45);
            textBoxNomPartit.Name = "textBoxNomPartit";
            textBoxNomPartit.Size = new Size(106, 23);
            textBoxNomPartit.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(65, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 9;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 558);
            Controls.Add(btnGuardarDades);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "FormInicial";
            Text = "FormInicial";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMunicipis).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCandidats).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaules).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomMunicipiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroRegidorsDataGridViewTextBoxColumn;
        private Button button1;
        private DataGridView dataGridViewMunicipis;
        private DataGridView dataGridViewPartits;
        private DataGridView dataGridViewCandidats;
        private Button btnGuardarDades;
        private Panel panel1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBoxNomPartit;
        private Label label3;
        private TextBox textBoxNomCandidat;
        private Button buttonAddMuni;
        private Button buttonAddCandidat;
        private Button buttonAddPartit;
        private Button buttonDeleteCandidat;
        private Button buttonDeletePartit;
        private Button buttonDeleteMuni;
        private Button buttonDeleteTaula;
        private Button buttonAddTaula;
        private Label label4;
        private TextBox textBoxCensTaula;
        private DataGridView dataGridViewTaules;
        private TextBox textBoxNomTaula;
    }
}