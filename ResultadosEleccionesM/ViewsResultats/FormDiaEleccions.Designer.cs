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
            labelListRegidors = new Label();
            labelTaulesMunicipi = new Label();
            textBoxNumRegidors = new TextBox();
            label1 = new Label();
            labelParticipacio = new Label();
            textBoxParticipacio = new TextBox();
            comboBoxTaules = new ComboBox();
            dataGridViewTaula1 = new DataGridView();
            dataGridViewTaula3 = new DataGridView();
            panelDadesResultats = new Panel();
            textBoxParticipacioTaula = new TextBox();
            textBoxVotsEscrotats = new TextBox();
            labelParticipacioTaula = new Label();
            textBoxPercentEscrotat = new TextBox();
            textBoxVotsTotals = new TextBox();
            textBoxVotsNuls = new TextBox();
            textBoxVBlan = new TextBox();
            labelVotsEscrotats = new Label();
            labelPercentEscotat = new Label();
            labelVotsTotals = new Label();
            labelVotsN = new Label();
            labelVotsB = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEscons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegidors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaula1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaula3).BeginInit();
            panelDadesResultats.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewEscons
            // 
            dataGridViewEscons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEscons.Location = new Point(48, 87);
            dataGridViewEscons.Margin = new Padding(3, 2, 3, 2);
            dataGridViewEscons.Name = "dataGridViewEscons";
            dataGridViewEscons.ReadOnly = true;
            dataGridViewEscons.RowHeadersWidth = 51;
            dataGridViewEscons.RowTemplate.Height = 29;
            dataGridViewEscons.Size = new Size(549, 267);
            dataGridViewEscons.TabIndex = 0;
            // 
            // dataGridViewRegidors
            // 
            dataGridViewRegidors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegidors.Location = new Point(918, 170);
            dataGridViewRegidors.Margin = new Padding(3, 2, 3, 2);
            dataGridViewRegidors.Name = "dataGridViewRegidors";
            dataGridViewRegidors.ReadOnly = true;
            dataGridViewRegidors.RowHeadersWidth = 51;
            dataGridViewRegidors.RowTemplate.Height = 29;
            dataGridViewRegidors.Size = new Size(254, 340);
            dataGridViewRegidors.TabIndex = 1;
            // 
            // comboBoxMunicipisDiaE
            // 
            comboBoxMunicipisDiaE.FormattingEnabled = true;
            comboBoxMunicipisDiaE.Location = new Point(48, 36);
            comboBoxMunicipisDiaE.Margin = new Padding(3, 2, 3, 2);
            comboBoxMunicipisDiaE.Name = "comboBoxMunicipisDiaE";
            comboBoxMunicipisDiaE.Size = new Size(133, 23);
            comboBoxMunicipisDiaE.TabIndex = 2;
            comboBoxMunicipisDiaE.SelectedIndexChanged += comboBoxMunicipisDiaE_SelectedIndexChanged;
            // 
            // labelListRegidors
            // 
            labelListRegidors.AutoSize = true;
            labelListRegidors.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelListRegidors.Location = new Point(983, 140);
            labelListRegidors.Name = "labelListRegidors";
            labelListRegidors.Size = new Size(97, 19);
            labelListRegidors.TabIndex = 4;
            labelListRegidors.Text = "Llista Regidors";
            // 
            // labelTaulesMunicipi
            // 
            labelTaulesMunicipi.AutoSize = true;
            labelTaulesMunicipi.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
            labelTaulesMunicipi.Location = new Point(336, 388);
            labelTaulesMunicipi.Name = "labelTaulesMunicipi";
            labelTaulesMunicipi.Size = new Size(110, 20);
            labelTaulesMunicipi.TabIndex = 5;
            labelTaulesMunicipi.Text = "Taules Municipi";
            // 
            // textBoxNumRegidors
            // 
            textBoxNumRegidors.BorderStyle = BorderStyle.None;
            textBoxNumRegidors.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumRegidors.Location = new Point(1086, 140);
            textBoxNumRegidors.Margin = new Padding(3, 2, 3, 2);
            textBoxNumRegidors.Name = "textBoxNumRegidors";
            textBoxNumRegidors.ReadOnly = true;
            textBoxNumRegidors.Size = new Size(47, 20);
            textBoxNumRegidors.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(336, 39);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 7;
            label1.Text = "Resultats Eleccions";
            // 
            // labelParticipacio
            // 
            labelParticipacio.AutoSize = true;
            labelParticipacio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelParticipacio.Location = new Point(983, 38);
            labelParticipacio.Name = "labelParticipacio";
            labelParticipacio.Size = new Size(86, 20);
            labelParticipacio.TabIndex = 8;
            labelParticipacio.Text = "Participació";
            // 
            // textBoxParticipacio
            // 
            textBoxParticipacio.BorderStyle = BorderStyle.None;
            textBoxParticipacio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxParticipacio.Location = new Point(1075, 38);
            textBoxParticipacio.Margin = new Padding(3, 2, 3, 2);
            textBoxParticipacio.Name = "textBoxParticipacio";
            textBoxParticipacio.ReadOnly = true;
            textBoxParticipacio.Size = new Size(97, 20);
            textBoxParticipacio.TabIndex = 9;
            // 
            // comboBoxTaules
            // 
            comboBoxTaules.FormattingEnabled = true;
            comboBoxTaules.Location = new Point(48, 388);
            comboBoxTaules.Margin = new Padding(3, 2, 3, 2);
            comboBoxTaules.Name = "comboBoxTaules";
            comboBoxTaules.Size = new Size(133, 23);
            comboBoxTaules.TabIndex = 10;
            comboBoxTaules.SelectedIndexChanged += comboBoxTaules_SelectedIndexChanged;
            // 
            // dataGridViewTaula1
            // 
            dataGridViewTaula1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaula1.Location = new Point(48, 428);
            dataGridViewTaula1.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTaula1.Name = "dataGridViewTaula1";
            dataGridViewTaula1.ReadOnly = true;
            dataGridViewTaula1.RowHeadersWidth = 51;
            dataGridViewTaula1.RowTemplate.Height = 29;
            dataGridViewTaula1.Size = new Size(253, 267);
            dataGridViewTaula1.TabIndex = 11;
            // 
            // dataGridViewTaula3
            // 
            dataGridViewTaula3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaula3.Location = new Point(307, 428);
            dataGridViewTaula3.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTaula3.Name = "dataGridViewTaula3";
            dataGridViewTaula3.ReadOnly = true;
            dataGridViewTaula3.RowHeadersWidth = 51;
            dataGridViewTaula3.RowTemplate.Height = 29;
            dataGridViewTaula3.Size = new Size(258, 267);
            dataGridViewTaula3.TabIndex = 12;
            // 
            // panelDadesResultats
            // 
            panelDadesResultats.Controls.Add(textBoxParticipacioTaula);
            panelDadesResultats.Controls.Add(textBoxVotsEscrotats);
            panelDadesResultats.Controls.Add(labelParticipacioTaula);
            panelDadesResultats.Controls.Add(textBoxPercentEscrotat);
            panelDadesResultats.Controls.Add(textBoxVotsTotals);
            panelDadesResultats.Controls.Add(textBoxVotsNuls);
            panelDadesResultats.Controls.Add(textBoxVBlan);
            panelDadesResultats.Controls.Add(labelVotsEscrotats);
            panelDadesResultats.Controls.Add(labelPercentEscotat);
            panelDadesResultats.Controls.Add(labelVotsTotals);
            panelDadesResultats.Controls.Add(labelVotsN);
            panelDadesResultats.Controls.Add(labelVotsB);
            panelDadesResultats.Location = new Point(571, 428);
            panelDadesResultats.Name = "panelDadesResultats";
            panelDadesResultats.Size = new Size(255, 276);
            panelDadesResultats.TabIndex = 13;
            // 
            // textBoxParticipacioTaula
            // 
            textBoxParticipacioTaula.BackColor = SystemColors.Control;
            textBoxParticipacioTaula.BorderStyle = BorderStyle.None;
            textBoxParticipacioTaula.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxParticipacioTaula.Location = new Point(127, 218);
            textBoxParticipacioTaula.Name = "textBoxParticipacioTaula";
            textBoxParticipacioTaula.ReadOnly = true;
            textBoxParticipacioTaula.Size = new Size(100, 20);
            textBoxParticipacioTaula.TabIndex = 19;
            // 
            // textBoxVotsEscrotats
            // 
            textBoxVotsEscrotats.BackColor = SystemColors.Control;
            textBoxVotsEscrotats.BorderStyle = BorderStyle.None;
            textBoxVotsEscrotats.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxVotsEscrotats.Location = new Point(127, 183);
            textBoxVotsEscrotats.Name = "textBoxVotsEscrotats";
            textBoxVotsEscrotats.ReadOnly = true;
            textBoxVotsEscrotats.Size = new Size(100, 20);
            textBoxVotsEscrotats.TabIndex = 17;
            // 
            // labelParticipacioTaula
            // 
            labelParticipacioTaula.AutoSize = true;
            labelParticipacioTaula.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelParticipacioTaula.Location = new Point(13, 221);
            labelParticipacioTaula.Name = "labelParticipacioTaula";
            labelParticipacioTaula.Size = new Size(82, 17);
            labelParticipacioTaula.TabIndex = 18;
            labelParticipacioTaula.Text = "Participació :";
            // 
            // textBoxPercentEscrotat
            // 
            textBoxPercentEscrotat.BackColor = SystemColors.Control;
            textBoxPercentEscrotat.BorderStyle = BorderStyle.None;
            textBoxPercentEscrotat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPercentEscrotat.Location = new Point(127, 143);
            textBoxPercentEscrotat.Name = "textBoxPercentEscrotat";
            textBoxPercentEscrotat.Size = new Size(100, 20);
            textBoxPercentEscrotat.TabIndex = 16;
            // 
            // textBoxVotsTotals
            // 
            textBoxVotsTotals.BackColor = SystemColors.Control;
            textBoxVotsTotals.BorderStyle = BorderStyle.None;
            textBoxVotsTotals.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxVotsTotals.Location = new Point(127, 103);
            textBoxVotsTotals.Name = "textBoxVotsTotals";
            textBoxVotsTotals.ReadOnly = true;
            textBoxVotsTotals.Size = new Size(100, 20);
            textBoxVotsTotals.TabIndex = 15;
            // 
            // textBoxVotsNuls
            // 
            textBoxVotsNuls.BackColor = SystemColors.Control;
            textBoxVotsNuls.BorderStyle = BorderStyle.None;
            textBoxVotsNuls.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxVotsNuls.Location = new Point(127, 64);
            textBoxVotsNuls.Name = "textBoxVotsNuls";
            textBoxVotsNuls.ReadOnly = true;
            textBoxVotsNuls.Size = new Size(100, 20);
            textBoxVotsNuls.TabIndex = 15;
            // 
            // textBoxVBlan
            // 
            textBoxVBlan.BackColor = SystemColors.Control;
            textBoxVBlan.BorderStyle = BorderStyle.None;
            textBoxVBlan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxVBlan.Location = new Point(127, 23);
            textBoxVBlan.Name = "textBoxVBlan";
            textBoxVBlan.ReadOnly = true;
            textBoxVBlan.Size = new Size(100, 20);
            textBoxVBlan.TabIndex = 14;
            // 
            // labelVotsEscrotats
            // 
            labelVotsEscrotats.AutoSize = true;
            labelVotsEscrotats.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelVotsEscrotats.Location = new Point(13, 186);
            labelVotsEscrotats.Name = "labelVotsEscrotats";
            labelVotsEscrotats.Size = new Size(97, 17);
            labelVotsEscrotats.TabIndex = 14;
            labelVotsEscrotats.Text = "Vots Escrotats :";
            // 
            // labelPercentEscotat
            // 
            labelPercentEscotat.AutoSize = true;
            labelPercentEscotat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPercentEscotat.Location = new Point(13, 146);
            labelPercentEscotat.Name = "labelPercentEscotat";
            labelPercentEscotat.Size = new Size(62, 17);
            labelPercentEscotat.TabIndex = 14;
            labelPercentEscotat.Text = "Escrotat :";
            // 
            // labelVotsTotals
            // 
            labelVotsTotals.AutoSize = true;
            labelVotsTotals.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelVotsTotals.Location = new Point(13, 106);
            labelVotsTotals.Name = "labelVotsTotals";
            labelVotsTotals.Size = new Size(112, 17);
            labelVotsTotals.TabIndex = 14;
            labelVotsTotals.Text = "Vots Totals Taula :";
            // 
            // labelVotsN
            // 
            labelVotsN.AutoSize = true;
            labelVotsN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelVotsN.Location = new Point(13, 67);
            labelVotsN.Name = "labelVotsN";
            labelVotsN.Size = new Size(70, 17);
            labelVotsN.TabIndex = 1;
            labelVotsN.Text = "Vots Nuls :";
            // 
            // labelVotsB
            // 
            labelVotsB.AutoSize = true;
            labelVotsB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelVotsB.Location = new Point(13, 26);
            labelVotsB.Name = "labelVotsB";
            labelVotsB.Size = new Size(80, 17);
            labelVotsB.TabIndex = 0;
            labelVotsB.Text = "Vots Blancs :";
            // 
            // FormDiaEleccions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 695);
            Controls.Add(panelDadesResultats);
            Controls.Add(dataGridViewTaula3);
            Controls.Add(dataGridViewTaula1);
            Controls.Add(comboBoxTaules);
            Controls.Add(textBoxParticipacio);
            Controls.Add(labelParticipacio);
            Controls.Add(label1);
            Controls.Add(textBoxNumRegidors);
            Controls.Add(labelTaulesMunicipi);
            Controls.Add(labelListRegidors);
            Controls.Add(comboBoxMunicipisDiaE);
            Controls.Add(dataGridViewRegidors);
            Controls.Add(dataGridViewEscons);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDiaEleccions";
            Text = "FormDiaEleccions";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEscons).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegidors).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaula1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaula3).EndInit();
            panelDadesResultats.ResumeLayout(false);
            panelDadesResultats.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEscons;
        private DataGridView dataGridViewRegidors;
        private ComboBox comboBoxMunicipisDiaE;
        private Label labelListRegidors;
        private Label labelTaulesMunicipi;
        private TextBox textBoxNumRegidors;
        private Label label1;
        private Label labelParticipacio;
        private TextBox textBoxParticipacio;
        private ComboBox comboBoxTaules;
        private DataGridView dataGridViewTaula1;
        private DataGridView dataGridViewTaula3;
        private Panel panelDadesResultats;
        private Label labelVotsN;
        private Label labelVotsB;
        private Label labelVotsTotals;
        private TextBox textBoxVotsTotals;
        private TextBox textBoxVotsNuls;
        private TextBox textBoxVBlan;
        private Label labelVotsEscrotats;
        private Label labelPercentEscotat;
        private TextBox textBoxVotsEscrotats;
        private TextBox textBoxPercentEscrotat;
        private TextBox textBoxParticipacioTaula;
        private Label labelParticipacioTaula;
    }
}