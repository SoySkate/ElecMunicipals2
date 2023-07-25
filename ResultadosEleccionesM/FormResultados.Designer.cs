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
            dataGridViewResultats = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultats).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResultats
            // 
            dataGridViewResultats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultats.Location = new Point(120, 67);
            dataGridViewResultats.Name = "dataGridViewResultats";
            dataGridViewResultats.RowTemplate.Height = 25;
            dataGridViewResultats.Size = new Size(597, 302);
            dataGridViewResultats.TabIndex = 0;
            // 
            // FormResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewResultats);
            Name = "FormResultados";
            Text = "FormResultados";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewResultats;
    }
}