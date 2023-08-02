namespace ResultadosEleccionesM.ViewsResultats
{
    partial class FormVotsTotals
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
            panel1 = new Panel();
            buttonOK = new Button();
            textBoxVotsTotals = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonOK);
            panel1.Controls.Add(textBoxVotsTotals);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(128, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 261);
            panel1.TabIndex = 0;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(182, 163);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(54, 29);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // textBoxVotsTotals
            // 
            textBoxVotsTotals.Location = new Point(149, 112);
            textBoxVotsTotals.Name = "textBoxVotsTotals";
            textBoxVotsTotals.Size = new Size(125, 27);
            textBoxVotsTotals.TabIndex = 1;
            textBoxVotsTotals.TextChanged += textBoxVotsTotals_TextChanged;
            textBoxVotsTotals.KeyPress += textBoxVotsTotals_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(103, 56);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 0;
            label1.Text = "Introdueix els Vots Totals";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormVotsTotals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(688, 399);
            Controls.Add(panel1);
            Name = "FormVotsTotals";
            Text = "FormVotsTotals";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonOK;
        private TextBox textBoxVotsTotals;
        private Label label1;
    }
}