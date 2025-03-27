namespace strangerthingsDB
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
            dgDatos = new DataGridView();
            cmbStranger = new ComboBox();
            ImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(12, 28);
            dgDatos.Name = "dgDatos";
            dgDatos.Size = new Size(758, 193);
            dgDatos.TabIndex = 0;
            // 
            // cmbStranger
            // 
            cmbStranger.FormattingEnabled = true;
            cmbStranger.Location = new Point(637, 254);
            cmbStranger.Name = "cmbStranger";
            cmbStranger.Size = new Size(133, 23);
            cmbStranger.TabIndex = 1;
            // 
            // ImageBox
            // 
            ImageBox.Location = new Point(387, 254);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(210, 175);
            ImageBox.TabIndex = 2;
            ImageBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ImageBox);
            Controls.Add(cmbStranger);
            Controls.Add(dgDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgDatos;
        private ComboBox cmbStranger;
        private PictureBox ImageBox;
    }
}
