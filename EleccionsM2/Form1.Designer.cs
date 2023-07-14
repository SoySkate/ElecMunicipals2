namespace EleccionsM2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnCarregarDades = new Button();
            panelMunicipis = new Panel();
            btnEliminarMunicipi = new Button();
            btnCrearMunicipi = new Button();
            labelLlistaMunicipis = new Label();
            MunicipisBox = new ListBox();
            panelNomMunicipi = new Panel();
            textBoxNomMunicipi = new TextBox();
            labelNomMUnicipi = new Label();
            panelNumRegidorsMunicipi = new Panel();
            textBoxNumRegidors = new TextBox();
            labelNumRegidors = new Label();
            panelCandidatsPartitMunicipi = new Panel();
            btnEliminarCandidat = new Button();
            btnAfegirPartit = new Button();
            CandidatsBox = new ListBox();
            textBoxNomCandidat = new TextBox();
            labelNomCandidat = new Label();
            textBoxNomPartit = new TextBox();
            labelNomPartit = new Label();
            panelLlistaPartits = new Panel();
            btnEliminarPartit = new Button();
            btnAfegirTaules = new Button();
            PartitsBox = new ListBox();
            labelLlistaPartits = new Label();
            panelTaulesElectorals = new Panel();
            btnEliminarTaula = new Button();
            btnDesarCanvis = new Button();
            TaulesBox = new ListBox();
            textBoxCensTaula = new TextBox();
            textBoxNomTaula = new TextBox();
            labelCensTaula = new Label();
            labelNomTaula = new Label();
            btnCloseForm = new Button();
            municipiBindingSource = new BindingSource(components);
            btnClosePanelData = new Button();
            panelDataAzul = new Panel();
            numeroRegidorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomMunicipiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            panelMunicipis.SuspendLayout();
            panelNomMunicipi.SuspendLayout();
            panelNumRegidorsMunicipi.SuspendLayout();
            panelCandidatsPartitMunicipi.SuspendLayout();
            panelLlistaPartits.SuspendLayout();
            panelTaulesElectorals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)municipiBindingSource).BeginInit();
            panelDataAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCarregarDades
            // 
            btnCarregarDades.BackColor = SystemColors.ControlLightLight;
            btnCarregarDades.Cursor = Cursors.Hand;
            btnCarregarDades.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarregarDades.ForeColor = SystemColors.ActiveCaptionText;
            btnCarregarDades.Location = new Point(762, 12);
            btnCarregarDades.Name = "btnCarregarDades";
            btnCarregarDades.Size = new Size(123, 29);
            btnCarregarDades.TabIndex = 0;
            btnCarregarDades.Text = "CarregarDades";
            btnCarregarDades.UseVisualStyleBackColor = false;
            btnCarregarDades.Click += btnCarregarDades_Click;
            // 
            // panelMunicipis
            // 
            panelMunicipis.Controls.Add(btnEliminarMunicipi);
            panelMunicipis.Controls.Add(btnCrearMunicipi);
            panelMunicipis.Controls.Add(labelLlistaMunicipis);
            panelMunicipis.Controls.Add(MunicipisBox);
            panelMunicipis.Location = new Point(711, 53);
            panelMunicipis.Name = "panelMunicipis";
            panelMunicipis.Size = new Size(235, 345);
            panelMunicipis.TabIndex = 1;
            panelMunicipis.Visible = false;
            // 
            // btnEliminarMunicipi
            // 
            btnEliminarMunicipi.ForeColor = Color.Red;
            btnEliminarMunicipi.Location = new Point(206, 46);
            btnEliminarMunicipi.Name = "btnEliminarMunicipi";
            btnEliminarMunicipi.Size = new Size(29, 27);
            btnEliminarMunicipi.TabIndex = 7;
            btnEliminarMunicipi.Text = "X";
            btnEliminarMunicipi.UseVisualStyleBackColor = true;
            btnEliminarMunicipi.Click += btnEliminarMunicipi_Click;
            // 
            // btnCrearMunicipi
            // 
            btnCrearMunicipi.Location = new Point(51, 303);
            btnCrearMunicipi.Name = "btnCrearMunicipi";
            btnCrearMunicipi.Size = new Size(106, 23);
            btnCrearMunicipi.TabIndex = 2;
            btnCrearMunicipi.Text = "CrearMunicipi";
            btnCrearMunicipi.UseVisualStyleBackColor = true;
            btnCrearMunicipi.Click += btnCrearMunicipi_Click;
            // 
            // labelLlistaMunicipis
            // 
            labelLlistaMunicipis.AutoSize = true;
            labelLlistaMunicipis.Location = new Point(71, 16);
            labelLlistaMunicipis.Name = "labelLlistaMunicipis";
            labelLlistaMunicipis.Size = new Size(59, 15);
            labelLlistaMunicipis.TabIndex = 1;
            labelLlistaMunicipis.Text = "Municipis";
            // 
            // MunicipisBox
            // 
            MunicipisBox.FormattingEnabled = true;
            MunicipisBox.ItemHeight = 15;
            MunicipisBox.Location = new Point(3, 46);
            MunicipisBox.Name = "MunicipisBox";
            MunicipisBox.Size = new Size(202, 244);
            MunicipisBox.TabIndex = 0;
            // 
            // panelNomMunicipi
            // 
            panelNomMunicipi.Controls.Add(textBoxNomMunicipi);
            panelNomMunicipi.Controls.Add(labelNomMUnicipi);
            panelNomMunicipi.Location = new Point(3, 3);
            panelNomMunicipi.Name = "panelNomMunicipi";
            panelNomMunicipi.Size = new Size(266, 45);
            panelNomMunicipi.TabIndex = 2;
            panelNomMunicipi.Visible = false;
            // 
            // textBoxNomMunicipi
            // 
            textBoxNomMunicipi.Location = new Point(115, 13);
            textBoxNomMunicipi.Name = "textBoxNomMunicipi";
            textBoxNomMunicipi.Size = new Size(148, 23);
            textBoxNomMunicipi.TabIndex = 5;
            textBoxNomMunicipi.KeyDown += textBoxNomMunicipi_KeyDown;
            // 
            // labelNomMUnicipi
            // 
            labelNomMUnicipi.AutoSize = true;
            labelNomMUnicipi.Location = new Point(3, 16);
            labelNomMUnicipi.Name = "labelNomMUnicipi";
            labelNomMUnicipi.Size = new Size(106, 15);
            labelNomMUnicipi.TabIndex = 4;
            labelNomMUnicipi.Text = "Nom del Municipi:";
            labelNomMUnicipi.UseWaitCursor = true;
            // 
            // panelNumRegidorsMunicipi
            // 
            panelNumRegidorsMunicipi.Controls.Add(textBoxNumRegidors);
            panelNumRegidorsMunicipi.Controls.Add(labelNumRegidors);
            panelNumRegidorsMunicipi.Location = new Point(272, 3);
            panelNumRegidorsMunicipi.Name = "panelNumRegidorsMunicipi";
            panelNumRegidorsMunicipi.Size = new Size(185, 45);
            panelNumRegidorsMunicipi.TabIndex = 3;
            panelNumRegidorsMunicipi.Visible = false;
            // 
            // textBoxNumRegidors
            // 
            textBoxNumRegidors.Location = new Point(128, 12);
            textBoxNumRegidors.Name = "textBoxNumRegidors";
            textBoxNumRegidors.Size = new Size(51, 23);
            textBoxNumRegidors.TabIndex = 5;
            textBoxNumRegidors.KeyDown += textBoxNumRegidors_KeyDown;
            textBoxNumRegidors.KeyPress += textBoxNumRegidors_KeyPress;
            // 
            // labelNumRegidors
            // 
            labelNumRegidors.AutoSize = true;
            labelNumRegidors.Location = new Point(3, 16);
            labelNumRegidors.Name = "labelNumRegidors";
            labelNumRegidors.Size = new Size(119, 15);
            labelNumRegidors.TabIndex = 4;
            labelNumRegidors.Text = "Número de Regidors:";
            labelNumRegidors.UseWaitCursor = true;
            // 
            // panelCandidatsPartitMunicipi
            // 
            panelCandidatsPartitMunicipi.Controls.Add(btnEliminarCandidat);
            panelCandidatsPartitMunicipi.Controls.Add(btnAfegirPartit);
            panelCandidatsPartitMunicipi.Controls.Add(CandidatsBox);
            panelCandidatsPartitMunicipi.Controls.Add(textBoxNomCandidat);
            panelCandidatsPartitMunicipi.Controls.Add(labelNomCandidat);
            panelCandidatsPartitMunicipi.Controls.Add(textBoxNomPartit);
            panelCandidatsPartitMunicipi.Controls.Add(labelNomPartit);
            panelCandidatsPartitMunicipi.Location = new Point(3, 54);
            panelCandidatsPartitMunicipi.Name = "panelCandidatsPartitMunicipi";
            panelCandidatsPartitMunicipi.Size = new Size(240, 395);
            panelCandidatsPartitMunicipi.TabIndex = 4;
            panelCandidatsPartitMunicipi.Visible = false;
            // 
            // btnEliminarCandidat
            // 
            btnEliminarCandidat.ForeColor = Color.Red;
            btnEliminarCandidat.Location = new Point(207, 100);
            btnEliminarCandidat.Name = "btnEliminarCandidat";
            btnEliminarCandidat.Size = new Size(31, 30);
            btnEliminarCandidat.TabIndex = 7;
            btnEliminarCandidat.Text = "X";
            btnEliminarCandidat.UseVisualStyleBackColor = true;
            btnEliminarCandidat.Click += btnEliminarCandidat_Click;
            // 
            // btnAfegirPartit
            // 
            btnAfegirPartit.Location = new Point(58, 361);
            btnAfegirPartit.Name = "btnAfegirPartit";
            btnAfegirPartit.Size = new Size(102, 23);
            btnAfegirPartit.TabIndex = 5;
            btnAfegirPartit.Text = "Afegir Partit";
            btnAfegirPartit.UseVisualStyleBackColor = true;
            btnAfegirPartit.Click += btnAfegirPartit_Click;
            // 
            // CandidatsBox
            // 
            CandidatsBox.FormattingEnabled = true;
            CandidatsBox.ItemHeight = 15;
            CandidatsBox.Location = new Point(8, 100);
            CandidatsBox.Name = "CandidatsBox";
            CandidatsBox.Size = new Size(197, 244);
            CandidatsBox.TabIndex = 4;
            // 
            // textBoxNomCandidat
            // 
            textBoxNomCandidat.Location = new Point(9, 60);
            textBoxNomCandidat.Name = "textBoxNomCandidat";
            textBoxNomCandidat.Size = new Size(196, 23);
            textBoxNomCandidat.TabIndex = 3;
            textBoxNomCandidat.KeyDown += textBoxNomCandidat_KeyDown;
            // 
            // labelNomCandidat
            // 
            labelNomCandidat.AutoSize = true;
            labelNomCandidat.Location = new Point(8, 42);
            labelNomCandidat.Name = "labelNomCandidat";
            labelNomCandidat.Size = new Size(91, 15);
            labelNomCandidat.TabIndex = 2;
            labelNomCandidat.Text = "Nom Candidat: ";
            // 
            // textBoxNomPartit
            // 
            textBoxNomPartit.Location = new Point(85, 7);
            textBoxNomPartit.Name = "textBoxNomPartit";
            textBoxNomPartit.Size = new Size(120, 23);
            textBoxNomPartit.TabIndex = 1;
            textBoxNomPartit.KeyDown += textBoxNomPartit_KeyDown;
            // 
            // labelNomPartit
            // 
            labelNomPartit.AutoSize = true;
            labelNomPartit.Location = new Point(8, 10);
            labelNomPartit.Name = "labelNomPartit";
            labelNomPartit.Size = new Size(71, 15);
            labelNomPartit.TabIndex = 0;
            labelNomPartit.Text = "Nom Partit: ";
            // 
            // panelLlistaPartits
            // 
            panelLlistaPartits.Controls.Add(btnEliminarPartit);
            panelLlistaPartits.Controls.Add(btnAfegirTaules);
            panelLlistaPartits.Controls.Add(PartitsBox);
            panelLlistaPartits.Controls.Add(labelLlistaPartits);
            panelLlistaPartits.Location = new Point(247, 54);
            panelLlistaPartits.Name = "panelLlistaPartits";
            panelLlistaPartits.Size = new Size(229, 395);
            panelLlistaPartits.TabIndex = 5;
            panelLlistaPartits.Visible = false;
            // 
            // btnEliminarPartit
            // 
            btnEliminarPartit.ForeColor = Color.Red;
            btnEliminarPartit.Location = new Point(201, 42);
            btnEliminarPartit.Name = "btnEliminarPartit";
            btnEliminarPartit.Size = new Size(28, 28);
            btnEliminarPartit.TabIndex = 3;
            btnEliminarPartit.Text = "X";
            btnEliminarPartit.UseVisualStyleBackColor = true;
            btnEliminarPartit.Click += btnEliminarPartit_Click;
            // 
            // btnAfegirTaules
            // 
            btnAfegirTaules.Location = new Point(63, 302);
            btnAfegirTaules.Name = "btnAfegirTaules";
            btnAfegirTaules.Size = new Size(99, 23);
            btnAfegirTaules.TabIndex = 2;
            btnAfegirTaules.Text = "Afegir Taules";
            btnAfegirTaules.UseVisualStyleBackColor = true;
            btnAfegirTaules.Click += btnAfegirTaules_Click;
            // 
            // PartitsBox
            // 
            PartitsBox.FormattingEnabled = true;
            PartitsBox.ItemHeight = 15;
            PartitsBox.Location = new Point(2, 42);
            PartitsBox.Name = "PartitsBox";
            PartitsBox.Size = new Size(196, 244);
            PartitsBox.TabIndex = 1;
            // 
            // labelLlistaPartits
            // 
            labelLlistaPartits.AutoSize = true;
            labelLlistaPartits.Location = new Point(63, 15);
            labelLlistaPartits.Name = "labelLlistaPartits";
            labelLlistaPartits.Size = new Size(67, 15);
            labelLlistaPartits.TabIndex = 0;
            labelLlistaPartits.Text = "LlistaPartits";
            // 
            // panelTaulesElectorals
            // 
            panelTaulesElectorals.Controls.Add(btnEliminarTaula);
            panelTaulesElectorals.Controls.Add(btnDesarCanvis);
            panelTaulesElectorals.Controls.Add(TaulesBox);
            panelTaulesElectorals.Controls.Add(textBoxCensTaula);
            panelTaulesElectorals.Controls.Add(textBoxNomTaula);
            panelTaulesElectorals.Controls.Add(labelCensTaula);
            panelTaulesElectorals.Controls.Add(labelNomTaula);
            panelTaulesElectorals.Location = new Point(479, 53);
            panelTaulesElectorals.Name = "panelTaulesElectorals";
            panelTaulesElectorals.Size = new Size(229, 396);
            panelTaulesElectorals.TabIndex = 6;
            panelTaulesElectorals.Visible = false;
            // 
            // btnEliminarTaula
            // 
            btnEliminarTaula.ForeColor = Color.Red;
            btnEliminarTaula.Location = new Point(200, 101);
            btnEliminarTaula.Name = "btnEliminarTaula";
            btnEliminarTaula.Size = new Size(29, 27);
            btnEliminarTaula.TabIndex = 6;
            btnEliminarTaula.Text = "X";
            btnEliminarTaula.UseVisualStyleBackColor = true;
            btnEliminarTaula.Click += btnEliminarTaula_Click;
            // 
            // btnDesarCanvis
            // 
            btnDesarCanvis.BackColor = Color.Snow;
            btnDesarCanvis.Cursor = Cursors.Hand;
            btnDesarCanvis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDesarCanvis.Location = new Point(33, 356);
            btnDesarCanvis.Name = "btnDesarCanvis";
            btnDesarCanvis.Size = new Size(142, 30);
            btnDesarCanvis.TabIndex = 5;
            btnDesarCanvis.Text = "Desar Canvis";
            btnDesarCanvis.UseVisualStyleBackColor = false;
            // 
            // TaulesBox
            // 
            TaulesBox.FormattingEnabled = true;
            TaulesBox.ItemHeight = 15;
            TaulesBox.Location = new Point(3, 100);
            TaulesBox.Name = "TaulesBox";
            TaulesBox.Size = new Size(194, 244);
            TaulesBox.TabIndex = 4;
            // 
            // textBoxCensTaula
            // 
            textBoxCensTaula.Location = new Point(84, 44);
            textBoxCensTaula.Name = "textBoxCensTaula";
            textBoxCensTaula.Size = new Size(100, 23);
            textBoxCensTaula.TabIndex = 3;
            textBoxCensTaula.KeyDown += textBoxCensTaula_KeyDown;
            textBoxCensTaula.KeyPress += textBoxCensTaula_KeyPress;
            // 
            // textBoxNomTaula
            // 
            textBoxNomTaula.Location = new Point(84, 15);
            textBoxNomTaula.Name = "textBoxNomTaula";
            textBoxNomTaula.Size = new Size(100, 23);
            textBoxNomTaula.TabIndex = 2;
            textBoxNomTaula.KeyDown += textBoxNomTaula_KeyDown;
            // 
            // labelCensTaula
            // 
            labelCensTaula.AutoSize = true;
            labelCensTaula.Location = new Point(42, 47);
            labelCensTaula.Name = "labelCensTaula";
            labelCensTaula.Size = new Size(36, 15);
            labelCensTaula.TabIndex = 1;
            labelCensTaula.Text = "Cens:";
            // 
            // labelNomTaula
            // 
            labelNomTaula.AutoSize = true;
            labelNomTaula.Location = new Point(11, 21);
            labelNomTaula.Name = "labelNomTaula";
            labelNomTaula.Size = new Size(67, 15);
            labelNomTaula.TabIndex = 0;
            labelNomTaula.Text = "Nom Taula:";
            // 
            // btnCloseForm
            // 
            btnCloseForm.ForeColor = Color.Firebrick;
            btnCloseForm.Location = new Point(879, 426);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(56, 23);
            btnCloseForm.TabIndex = 7;
            btnCloseForm.Text = "CLOSE ";
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // municipiBindingSource
            // 
            municipiBindingSource.DataSource = typeof(Models.Municipi);
            // 
            // btnClosePanelData
            // 
            btnClosePanelData.ForeColor = Color.Red;
            btnClosePanelData.Location = new Point(911, 3);
            btnClosePanelData.Name = "btnClosePanelData";
            btnClosePanelData.Size = new Size(29, 27);
            btnClosePanelData.TabIndex = 9;
            btnClosePanelData.Text = "X";
            btnClosePanelData.UseVisualStyleBackColor = true;
            btnClosePanelData.Click += btnClosePanelData_Click;
            // 
            // panelDataAzul
            // 
            panelDataAzul.BackColor = SystemColors.ActiveCaption;
            panelDataAzul.Controls.Add(dataGridView1);
            panelDataAzul.Controls.Add(btnClosePanelData);
            panelDataAzul.Location = new Point(3, 6);
            panelDataAzul.Name = "panelDataAzul";
            panelDataAzul.Size = new Size(943, 443);
            panelDataAzul.TabIndex = 8;
            panelDataAzul.Visible = false;
            // 
            // numeroRegidorsDataGridViewTextBoxColumn
            // 
            numeroRegidorsDataGridViewTextBoxColumn.DataPropertyName = "numeroRegidors";
            numeroRegidorsDataGridViewTextBoxColumn.HeaderText = "numeroRegidors";
            numeroRegidorsDataGridViewTextBoxColumn.Name = "numeroRegidorsDataGridViewTextBoxColumn";
            // 
            // nomMunicipiDataGridViewTextBoxColumn
            // 
            nomMunicipiDataGridViewTextBoxColumn.DataPropertyName = "nomMunicipi";
            nomMunicipiDataGridViewTextBoxColumn.HeaderText = "nomMunicipi";
            nomMunicipiDataGridViewTextBoxColumn.Name = "nomMunicipiDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nomMunicipiDataGridViewTextBoxColumn, numeroRegidorsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = municipiBindingSource;
            dataGridView1.Location = new Point(211, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(348, 150);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(947, 457);
            Controls.Add(panelDataAzul);
            Controls.Add(panelMunicipis);
            Controls.Add(btnCarregarDades);
            Controls.Add(panelTaulesElectorals);
            Controls.Add(panelLlistaPartits);
            Controls.Add(panelNumRegidorsMunicipi);
            Controls.Add(panelNomMunicipi);
            Controls.Add(panelCandidatsPartitMunicipi);
            Controls.Add(btnCloseForm);
            Name = "Form1";
            Text = "Form1";
            panelMunicipis.ResumeLayout(false);
            panelMunicipis.PerformLayout();
            panelNomMunicipi.ResumeLayout(false);
            panelNomMunicipi.PerformLayout();
            panelNumRegidorsMunicipi.ResumeLayout(false);
            panelNumRegidorsMunicipi.PerformLayout();
            panelCandidatsPartitMunicipi.ResumeLayout(false);
            panelCandidatsPartitMunicipi.PerformLayout();
            panelLlistaPartits.ResumeLayout(false);
            panelLlistaPartits.PerformLayout();
            panelTaulesElectorals.ResumeLayout(false);
            panelTaulesElectorals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)municipiBindingSource).EndInit();
            panelDataAzul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCarregarDades;
        private Panel panelMunicipis;
        private Button btnCrearMunicipi;
        private Label labelLlistaMunicipis;
        private ListBox MunicipisBox;
        private Panel panelNomMunicipi;
        private TextBox textBoxNomMunicipi;
        private Label labelNomMUnicipi;
        private Panel panelNumRegidorsMunicipi;
        private TextBox textBoxNumRegidors;
        private Label labelNumRegidors;
        private Panel panelCandidatsPartitMunicipi;
        private Label labelNomCandidat;
        private TextBox textBoxNomPartit;
        private Label labelNomPartit;
        private ListBox CandidatsBox;
        private TextBox textBoxNomCandidat;
        private Button btnAfegirPartit;
        private Panel panelLlistaPartits;
        private Label labelLlistaPartits;
        private ListBox PartitsBox;
        private Button btnAfegirTaules;
        private Panel panelTaulesElectorals;
        private Label labelNomTaula;
        private ListBox TaulesBox;
        private TextBox textBoxCensTaula;
        private TextBox textBoxNomTaula;
        private Label labelCensTaula;
        private Button btnDesarCanvis;
        private Button btnEliminarCandidat;
        private Button btnEliminarPartit;
        private Button btnEliminarMunicipi;
        private Button btnEliminarTaula;
        private Button btnCloseForm;
        private BindingSource municipiBindingSource;
        private Button btnClosePanelData;
        private Panel panelDataAzul;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomMunicipiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroRegidorsDataGridViewTextBoxColumn;
    }
}