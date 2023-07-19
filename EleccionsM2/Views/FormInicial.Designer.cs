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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            btnGuardarDades = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            textBoxCensTaula = new TextBox();
            dataGridView4 = new DataGridView();
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
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
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
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 3;
            button1.Text = "carregarDades";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(243, 189);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(265, 48);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(244, 189);
            dataGridView2.TabIndex = 5;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(533, 48);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(244, 189);
            dataGridView3.TabIndex = 6;
            dataGridView3.SelectionChanged += dataGridView3_SelectionChanged;
            // 
            // btnGuardarDades
            // 
            btnGuardarDades.Anchor = AnchorStyles.Top;
            btnGuardarDades.Location = new Point(12, 497);
            btnGuardarDades.Name = "btnGuardarDades";
            btnGuardarDades.Size = new Size(107, 30);
            btnGuardarDades.TabIndex = 7;
            btnGuardarDades.Text = "DesarDades";
            btnGuardarDades.UseVisualStyleBackColor = true;
            btnGuardarDades.Click += btnGuardarDades_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxCensTaula);
            panel1.Controls.Add(dataGridView4);
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView3);
            panel1.Location = new Point(122, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 515);
            panel1.TabIndex = 8;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(601, 380);
            button2.Name = "button2";
            button2.Size = new Size(22, 27);
            button2.TabIndex = 28;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(601, 449);
            button3.Name = "button3";
            button3.Size = new Size(122, 27);
            button3.TabIndex = 27;
            button3.Text = "Afegir Taula";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 304);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 26;
            label4.Text = "Nom i Cens Taula:";
            // 
            // textBoxCensTaula
            // 
            textBoxCensTaula.Location = new Point(601, 351);
            textBoxCensTaula.Name = "textBoxCensTaula";
            textBoxCensTaula.Size = new Size(65, 23);
            textBoxCensTaula.TabIndex = 25;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(265, 296);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(330, 189);
            dataGridView4.TabIndex = 23;
            dataGridView4.SelectionChanged += dataGridView4_SelectionChanged;
            // 
            // textBoxNomTaula
            // 
            textBoxNomTaula.Location = new Point(601, 322);
            textBoxNomTaula.Name = "textBoxNomTaula";
            textBoxNomTaula.Size = new Size(110, 23);
            textBoxNomTaula.TabIndex = 24;
            // 
            // buttonDeleteCandidat
            // 
            buttonDeleteCandidat.FlatStyle = FlatStyle.System;
            buttonDeleteCandidat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteCandidat.Location = new Point(741, 15);
            buttonDeleteCandidat.Name = "buttonDeleteCandidat";
            buttonDeleteCandidat.Size = new Size(22, 27);
            buttonDeleteCandidat.TabIndex = 22;
            buttonDeleteCandidat.Text = "-";
            buttonDeleteCandidat.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePartit
            // 
            buttonDeletePartit.FlatStyle = FlatStyle.System;
            buttonDeletePartit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeletePartit.Location = new Point(475, 15);
            buttonDeletePartit.Name = "buttonDeletePartit";
            buttonDeletePartit.Size = new Size(22, 27);
            buttonDeletePartit.TabIndex = 21;
            buttonDeletePartit.Text = "-";
            buttonDeletePartit.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteMuni
            // 
            buttonDeleteMuni.FlatStyle = FlatStyle.System;
            buttonDeleteMuni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteMuni.Location = new Point(202, 138);
            buttonDeleteMuni.Name = "buttonDeleteMuni";
            buttonDeleteMuni.Size = new Size(22, 27);
            buttonDeleteMuni.TabIndex = 20;
            buttonDeleteMuni.Text = "-";
            buttonDeleteMuni.UseVisualStyleBackColor = true;
            // 
            // buttonAddCandidat
            // 
            buttonAddCandidat.FlatStyle = FlatStyle.System;
            buttonAddCandidat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCandidat.Location = new Point(587, 243);
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
            buttonAddPartit.Location = new Point(315, 243);
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
            buttonAddMuni.Location = new Point(48, 366);
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
            label3.Location = new Point(533, 18);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 16;
            label3.Text = "Nom Candidat :";
            // 
            // textBoxNomCandidat
            // 
            textBoxNomCandidat.Location = new Point(635, 15);
            textBoxNomCandidat.Name = "textBoxNomCandidat";
            textBoxNomCandidat.Size = new Size(100, 23);
            textBoxNomCandidat.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 18);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 14;
            label2.Text = "Nom Partit :";
            // 
            // textBoxNomPartit
            // 
            textBoxNomPartit.Location = new Point(352, 15);
            textBoxNomPartit.Name = "textBoxNomPartit";
            textBoxNomPartit.Size = new Size(106, 23);
            textBoxNomPartit.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 111);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 11;
            label1.Text = "Nom i Num regidors :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(65, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 9;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 539);
            Controls.Add(panel1);
            Controls.Add(btnGuardarDades);
            Controls.Add(button1);
            Name = "FormInicial";
            Text = "FormInicial";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomMunicipiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroRegidorsDataGridViewTextBoxColumn;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
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
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox textBoxCensTaula;
        private DataGridView dataGridView4;
        private TextBox textBoxNomTaula;
    }
}