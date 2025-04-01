namespace strangerthingsDB
{
    partial class FrmInicio
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnMostrar = new Button();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txbNombre = new TextBox();
            txbEdad = new TextBox();
            txbIURL = new TextBox();
            txbTaparece = new TextBox();
            txbID = new TextBox();
            label10 = new Label();
            txbRol = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(12, 12);
            dgDatos.Name = "dgDatos";
            dgDatos.Size = new Size(759, 188);
            dgDatos.TabIndex = 0;
            // 
            // cmbStranger
            // 
            cmbStranger.FormattingEnabled = true;
            cmbStranger.Location = new Point(655, 216);
            cmbStranger.Name = "cmbStranger";
            cmbStranger.Size = new Size(133, 23);
            cmbStranger.TabIndex = 1;
            cmbStranger.SelectedIndexChanged += cmbStranger_SelectedIndexChanged;
            // 
            // ImageBox
            // 
            ImageBox.Location = new Point(578, 263);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(210, 175);
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageBox.TabIndex = 2;
            ImageBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 203);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 203);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 203);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 206);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(479, 263);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += button1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(479, 306);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(479, 350);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(479, 403);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 240);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 11;
            label5.Text = "IdPersonaje";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 271);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 12;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 306);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 13;
            label7.Text = "Edad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 371);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 14;
            label8.Text = "TeporadaAparece";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 407);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 15;
            label9.Text = "ImagenURL";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(89, 271);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 16;
            // 
            // txbEdad
            // 
            txbEdad.Location = new Point(71, 306);
            txbEdad.Name = "txbEdad";
            txbEdad.Size = new Size(100, 23);
            txbEdad.TabIndex = 17;
            // 
            // txbIURL
            // 
            txbIURL.Location = new Point(106, 407);
            txbIURL.Name = "txbIURL";
            txbIURL.Size = new Size(100, 23);
            txbIURL.TabIndex = 18;
            // 
            // txbTaparece
            // 
            txbTaparece.Location = new Point(136, 371);
            txbTaparece.Name = "txbTaparece";
            txbTaparece.Size = new Size(100, 23);
            txbTaparece.TabIndex = 19;
            // 
            // txbID
            // 
            txbID.Location = new Point(106, 240);
            txbID.Name = "txbID";
            txbID.Size = new Size(100, 23);
            txbID.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 345);
            label10.Name = "label10";
            label10.Size = new Size(24, 15);
            label10.TabIndex = 21;
            label10.Text = "Rol";
            // 
            // txbRol
            // 
            txbRol.Location = new Point(71, 342);
            txbRol.Name = "txbRol";
            txbRol.Size = new Size(100, 23);
            txbRol.TabIndex = 22;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbRol);
            Controls.Add(label10);
            Controls.Add(txbID);
            Controls.Add(txbTaparece);
            Controls.Add(txbIURL);
            Controls.Add(txbEdad);
            Controls.Add(txbNombre);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(btnMostrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ImageBox);
            Controls.Add(cmbStranger);
            Controls.Add(dgDatos);
            Name = "FrmInicio";
            Text = "Stranger things";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDatos;
        private ComboBox cmbStranger;
        private PictureBox ImageBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnMostrar;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txbNombre;
        private TextBox txbEdad;
        private TextBox txbIURL;
        private TextBox txbTaparece;
        private TextBox txbID;
        private Label label10;
        private TextBox txbRol;
    }
}
