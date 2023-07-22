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
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomMunicipiDataGridViewTextBoxColumn
            // 
            nomMunicipiDataGridViewTextBoxColumn.DataPropertyName = "nomMunicipi";
            nomMunicipiDataGridViewTextBoxColumn.HeaderText = "nomMunicipi";
            nomMunicipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomMunicipiDataGridViewTextBoxColumn.Name = "nomMunicipiDataGridViewTextBoxColumn";
            nomMunicipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroRegidorsDataGridViewTextBoxColumn
            // 
            numeroRegidorsDataGridViewTextBoxColumn.DataPropertyName = "numeroRegidors";
            numeroRegidorsDataGridViewTextBoxColumn.HeaderText = "numeroRegidors";
            numeroRegidorsDataGridViewTextBoxColumn.MinimumWidth = 6;
            numeroRegidorsDataGridViewTextBoxColumn.Name = "numeroRegidorsDataGridViewTextBoxColumn";
            numeroRegidorsDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(14, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 3;
            button1.Text = "Refrescar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewMunicipis
            // 
            dataGridViewMunicipis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMunicipis.Location = new Point(15, 104);
            dataGridViewMunicipis.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMunicipis.Name = "dataGridViewMunicipis";
            dataGridViewMunicipis.RowHeadersWidth = 51;
            dataGridViewMunicipis.RowTemplate.Height = 25;
            dataGridViewMunicipis.Size = new Size(291, 252);
            dataGridViewMunicipis.TabIndex = 4;
            // 
            // dataGridViewPartits
            // 
            dataGridViewPartits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartits.Location = new Point(329, 104);
            dataGridViewPartits.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPartits.Name = "dataGridViewPartits";
            dataGridViewPartits.RowHeadersWidth = 51;
            dataGridViewPartits.RowTemplate.Height = 25;
            dataGridViewPartits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPartits.Size = new Size(279, 252);
            dataGridViewPartits.TabIndex = 5;
            dataGridViewPartits.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // dataGridViewCandidats
            // 
            dataGridViewCandidats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCandidats.Location = new Point(626, 104);
            dataGridViewCandidats.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCandidats.Name = "dataGridViewCandidats";
            dataGridViewCandidats.RowHeadersWidth = 51;
            dataGridViewCandidats.RowTemplate.Height = 25;
            dataGridViewCandidats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCandidats.Size = new Size(279, 252);
            dataGridViewCandidats.TabIndex = 6;
            dataGridViewCandidats.SelectionChanged += dataGridView3_SelectionChanged;
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
            panel1.Location = new Point(121, 31);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 697);
            panel1.TabIndex = 8;
            // 
            // buttonDeleteTaula
            // 
            buttonDeleteTaula.FlatStyle = FlatStyle.System;
            buttonDeleteTaula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteTaula.Location = new Point(402, 547);
            buttonDeleteTaula.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteTaula.Name = "buttonDeleteTaula";
            buttonDeleteTaula.Size = new Size(25, 36);
            buttonDeleteTaula.TabIndex = 28;
            buttonDeleteTaula.Text = "-";
            buttonDeleteTaula.UseVisualStyleBackColor = true;
            buttonDeleteTaula.Click += buttonDeleteTaula_Click;
            // 
            // buttonAddTaula
            // 
            buttonAddTaula.FlatStyle = FlatStyle.System;
            buttonAddTaula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddTaula.Location = new Point(402, 639);
            buttonAddTaula.Margin = new Padding(3, 4, 3, 4);
            buttonAddTaula.Name = "buttonAddTaula";
            buttonAddTaula.Size = new Size(139, 36);
            buttonAddTaula.TabIndex = 27;
            buttonAddTaula.Text = "Afegir Taula";
            buttonAddTaula.UseVisualStyleBackColor = true;
            buttonAddTaula.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 445);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 26;
            label4.Text = "Nom i Cens Taula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 11;
            label1.Text = "Nom Municipi:               Num regidors :";
            // 
            // textBoxCensTaula
            // 
            textBoxCensTaula.Location = new Point(402, 508);
            textBoxCensTaula.Margin = new Padding(3, 4, 3, 4);
            textBoxCensTaula.Name = "textBoxCensTaula";
            textBoxCensTaula.Size = new Size(74, 27);
            textBoxCensTaula.TabIndex = 25;
            textBoxCensTaula.TextChanged += textBoxCensTaula_TextChanged;
            // 
            // dataGridViewTaules
            // 
            dataGridViewTaules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaules.Location = new Point(18, 435);
            dataGridViewTaules.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTaules.Name = "dataGridViewTaules";
            dataGridViewTaules.RowHeadersWidth = 51;
            dataGridViewTaules.RowTemplate.Height = 25;
            dataGridViewTaules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTaules.Size = new Size(369, 252);
            dataGridViewTaules.TabIndex = 23;
            dataGridViewTaules.SelectionChanged += dataGridView4_SelectionChanged;
            // 
            // textBoxNomTaula
            // 
            textBoxNomTaula.Location = new Point(402, 469);
            textBoxNomTaula.Margin = new Padding(3, 4, 3, 4);
            textBoxNomTaula.Name = "textBoxNomTaula";
            textBoxNomTaula.Size = new Size(125, 27);
            textBoxNomTaula.TabIndex = 24;
            textBoxNomTaula.TextChanged += textBoxNomTaula_TextChanged;
            // 
            // buttonDeleteCandidat
            // 
            buttonDeleteCandidat.FlatStyle = FlatStyle.System;
            buttonDeleteCandidat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteCandidat.Location = new Point(880, 56);
            buttonDeleteCandidat.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteCandidat.Name = "buttonDeleteCandidat";
            buttonDeleteCandidat.Size = new Size(25, 36);
            buttonDeleteCandidat.TabIndex = 22;
            buttonDeleteCandidat.Text = "-";
            buttonDeleteCandidat.UseVisualStyleBackColor = true;
            buttonDeleteCandidat.Click += buttonDeleteCandidat_Click;
            // 
            // buttonDeletePartit
            // 
            buttonDeletePartit.FlatStyle = FlatStyle.System;
            buttonDeletePartit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeletePartit.Location = new Point(557, 55);
            buttonDeletePartit.Margin = new Padding(3, 4, 3, 4);
            buttonDeletePartit.Name = "buttonDeletePartit";
            buttonDeletePartit.Size = new Size(25, 36);
            buttonDeletePartit.TabIndex = 21;
            buttonDeletePartit.Text = "-";
            buttonDeletePartit.UseVisualStyleBackColor = true;
            buttonDeletePartit.Click += buttonDeletePartit_Click;
            // 
            // buttonDeleteMuni
            // 
            buttonDeleteMuni.FlatStyle = FlatStyle.System;
            buttonDeleteMuni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteMuni.Location = new Point(281, 57);
            buttonDeleteMuni.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteMuni.Name = "buttonDeleteMuni";
            buttonDeleteMuni.Size = new Size(25, 36);
            buttonDeleteMuni.TabIndex = 20;
            buttonDeleteMuni.Text = "-";
            buttonDeleteMuni.UseVisualStyleBackColor = true;
            buttonDeleteMuni.Click += buttonDeleteMuni_Click;
            // 
            // buttonAddCandidat
            // 
            buttonAddCandidat.FlatStyle = FlatStyle.System;
            buttonAddCandidat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCandidat.Location = new Point(688, 364);
            buttonAddCandidat.Margin = new Padding(3, 4, 3, 4);
            buttonAddCandidat.Name = "buttonAddCandidat";
            buttonAddCandidat.Size = new Size(181, 36);
            buttonAddCandidat.TabIndex = 19;
            buttonAddCandidat.Text = "Afegir Candidat";
            buttonAddCandidat.UseVisualStyleBackColor = true;
            buttonAddCandidat.Click += buttonAddCandidat_Click;
            // 
            // buttonAddPartit
            // 
            buttonAddPartit.FlatStyle = FlatStyle.System;
            buttonAddPartit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddPartit.Location = new Point(386, 364);
            buttonAddPartit.Margin = new Padding(3, 4, 3, 4);
            buttonAddPartit.Name = "buttonAddPartit";
            buttonAddPartit.Size = new Size(179, 36);
            buttonAddPartit.TabIndex = 18;
            buttonAddPartit.Text = "Afegir Partit";
            buttonAddPartit.UseVisualStyleBackColor = true;
            buttonAddPartit.Click += buttonAddPartit_Click;
            // 
            // buttonAddMuni
            // 
            buttonAddMuni.FlatStyle = FlatStyle.System;
            buttonAddMuni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddMuni.Location = new Point(66, 364);
            buttonAddMuni.Margin = new Padding(3, 4, 3, 4);
            buttonAddMuni.Name = "buttonAddMuni";
            buttonAddMuni.Size = new Size(189, 36);
            buttonAddMuni.TabIndex = 17;
            buttonAddMuni.Text = "Afegir Municipi";
            buttonAddMuni.UseVisualStyleBackColor = true;
            buttonAddMuni.Click += buttonAddMuni_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(626, 64);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 16;
            label3.Text = "Nom Candidat :";
            // 
            // textBoxNomCandidat
            // 
            textBoxNomCandidat.Location = new Point(745, 60);
            textBoxNomCandidat.Margin = new Padding(3, 4, 3, 4);
            textBoxNomCandidat.Name = "textBoxNomCandidat";
            textBoxNomCandidat.Size = new Size(128, 27);
            textBoxNomCandidat.TabIndex = 15;
            textBoxNomCandidat.TextChanged += textBoxNomCandidat_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 65);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 14;
            label2.Text = "Nom Partit :";
            // 
            // textBoxNomPartit
            // 
            textBoxNomPartit.Location = new Point(429, 60);
            textBoxNomPartit.Margin = new Padding(3, 4, 3, 4);
            textBoxNomPartit.Name = "textBoxNomPartit";
            textBoxNomPartit.Size = new Size(121, 27);
            textBoxNomPartit.TabIndex = 12;
            textBoxNomPartit.TextChanged += textBoxNomPartit_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 63);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(74, 27);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 63);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 744);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInicial";
            Text = "FormInicial";
            FormClosing += FormInicial_FormClosing;
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