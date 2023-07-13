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
            components = new System.ComponentModel.Container();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomMunicipiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroRegidorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            municipiBindingSource = new BindingSource(components);
            partitMunicipiBindingSource = new BindingSource(components);
            candidatBindingSource = new BindingSource(components);
            button1 = new Button();
            eleccionsMContextBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            iDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nomMunicipiDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            numeroRegidorsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Partits = new DataGridViewButtonColumn();
            municipiBindingSource1 = new BindingSource(components);
            dataGridView2 = new DataGridView();
            iDDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nomPartitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Candidats = new DataGridViewButtonColumn();
            dataGridView3 = new DataGridView();
            iDDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            nomCandidatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)municipiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partitMunicipiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)candidatBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eleccionsMContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)municipiBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
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
            // municipiBindingSource
            // 
            municipiBindingSource.DataSource = typeof(Models.Municipi);
            // 
            // partitMunicipiBindingSource
            // 
            partitMunicipiBindingSource.DataSource = typeof(Models.PartitMunicipi);
            // 
            // candidatBindingSource
            // 
            candidatBindingSource.DataSource = typeof(Models.Candidat);
            // 
            // button1
            // 
            button1.Location = new Point(681, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 3;
            button1.Text = "carregarDades";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // eleccionsMContextBindingSource
            // 
            eleccionsMContextBindingSource.DataSource = typeof(EleccionsMContext);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn1, nomMunicipiDataGridViewTextBoxColumn1, numeroRegidorsDataGridViewTextBoxColumn1, Partits });
            dataGridView1.DataSource = municipiBindingSource1;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(470, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // nomMunicipiDataGridViewTextBoxColumn1
            // 
            nomMunicipiDataGridViewTextBoxColumn1.DataPropertyName = "nomMunicipi";
            nomMunicipiDataGridViewTextBoxColumn1.HeaderText = "nomMunicipi";
            nomMunicipiDataGridViewTextBoxColumn1.Name = "nomMunicipiDataGridViewTextBoxColumn1";
            // 
            // numeroRegidorsDataGridViewTextBoxColumn1
            // 
            numeroRegidorsDataGridViewTextBoxColumn1.DataPropertyName = "numeroRegidors";
            numeroRegidorsDataGridViewTextBoxColumn1.HeaderText = "numeroRegidors";
            numeroRegidorsDataGridViewTextBoxColumn1.Name = "numeroRegidorsDataGridViewTextBoxColumn1";
            // 
            // Partits
            // 
            Partits.DataPropertyName = "ID";
            Partits.HeaderText = "Partits";
            Partits.Name = "Partits";
            // 
            // municipiBindingSource1
            // 
            municipiBindingSource1.DataSource = typeof(Models.Municipi);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn2, nomPartitDataGridViewTextBoxColumn, Candidats });
            dataGridView2.DataSource = partitMunicipiBindingSource;
            dataGridView2.Location = new Point(180, 177);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(358, 150);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            // 
            // nomPartitDataGridViewTextBoxColumn
            // 
            nomPartitDataGridViewTextBoxColumn.DataPropertyName = "nomPartit";
            nomPartitDataGridViewTextBoxColumn.HeaderText = "nomPartit";
            nomPartitDataGridViewTextBoxColumn.Name = "nomPartitDataGridViewTextBoxColumn";
            // 
            // Candidats
            // 
            Candidats.DataPropertyName = "ID";
            Candidats.HeaderText = "Candidats";
            Candidats.Name = "Candidats";
            // 
            // dataGridView3
            // 
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn3, nomCandidatDataGridViewTextBoxColumn });
            dataGridView3.DataSource = candidatBindingSource;
            dataGridView3.Location = new Point(544, 288);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(244, 150);
            dataGridView3.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            // 
            // nomCandidatDataGridViewTextBoxColumn
            // 
            nomCandidatDataGridViewTextBoxColumn.DataPropertyName = "nomCandidat";
            nomCandidatDataGridViewTextBoxColumn.HeaderText = "nomCandidat";
            nomCandidatDataGridViewTextBoxColumn.Name = "nomCandidatDataGridViewTextBoxColumn";
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "FormInicial";
            Text = "FormInicial";
            ((System.ComponentModel.ISupportInitialize)municipiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)partitMunicipiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)candidatBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)eleccionsMContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)municipiBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomMunicipiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroRegidorsDataGridViewTextBoxColumn;
        private BindingSource municipiBindingSource;
        private BindingSource partitMunicipiBindingSource;
        private BindingSource candidatBindingSource;
        private Button button1;
        private BindingSource eleccionsMContextBindingSource;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn nomCandidatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nomPartitDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Candidats;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nomMunicipiDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn numeroRegidorsDataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn Partits;
        private BindingSource municipiBindingSource1;
    }
}