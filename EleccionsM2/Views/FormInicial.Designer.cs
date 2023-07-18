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
            button1.Location = new Point(339, 25);
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
            dataGridView1.Location = new Point(0, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(243, 189);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(264, 87);
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
            dataGridView3.Location = new Point(532, 87);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(244, 189);
            dataGridView3.TabIndex = 6;
            dataGridView3.SelectionChanged += dataGridView3_SelectionChanged;
            // 
            // btnGuardarDades
            // 
            btnGuardarDades.Anchor = AnchorStyles.Top;
            btnGuardarDades.Location = new Point(339, 348);
            btnGuardarDades.Name = "btnGuardarDades";
            btnGuardarDades.Size = new Size(107, 23);
            btnGuardarDades.TabIndex = 7;
            btnGuardarDades.Text = "DesarDades";
            btnGuardarDades.UseVisualStyleBackColor = true;
            btnGuardarDades.Click += btnGuardarDades_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
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
            panel1.Location = new Point(12, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 279);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 39);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 16;
            label3.Text = "Nom Candidat :";
            // 
            // textBoxNomCandidat
            // 
            textBoxNomCandidat.Location = new Point(657, 36);
            textBoxNomCandidat.Name = "textBoxNomCandidat";
            textBoxNomCandidat.Size = new Size(100, 23);
            textBoxNomCandidat.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 39);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 14;
            label2.Text = "Nom Partit :";
            // 
            // textBoxNomPartit
            // 
            textBoxNomPartit.Location = new Point(384, 39);
            textBoxNomPartit.Name = "textBoxNomPartit";
            textBoxNomPartit.Size = new Size(100, 23);
            textBoxNomPartit.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 11;
            label1.Text = "Nom i Num regidors :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}