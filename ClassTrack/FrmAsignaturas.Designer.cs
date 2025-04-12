namespace ClassTrack
{
    partial class FrmAsignaturas
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
            label1 = new Label();
            dgvAsignatura = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            cbTitulacion = new ComboBox();
            cbArea = new ComboBox();
            btnAgregar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAsignatura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Asignaturas";
            // 
            // dgvAsignatura
            // 
            dgvAsignatura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignatura.Location = new Point(237, 34);
            dgvAsignatura.Margin = new Padding(2);
            dgvAsignatura.Name = "dgvAsignatura";
            dgvAsignatura.RowHeadersWidth = 62;
            dgvAsignatura.Size = new Size(255, 166);
            dgvAsignatura.TabIndex = 1;
            dgvAsignatura.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 73);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 109);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 3;
            // 
            // cbTitulacion
            // 
            cbTitulacion.FormattingEnabled = true;
            cbTitulacion.Location = new Point(50, 147);
            cbTitulacion.Margin = new Padding(2);
            cbTitulacion.Name = "cbTitulacion";
            cbTitulacion.Size = new Size(129, 23);
            cbTitulacion.TabIndex = 4;
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(50, 184);
            cbArea.Margin = new Padding(2);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(129, 23);
            cbArea.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(50, 226);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 20);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 56);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 11;
            label3.Text = "Codigo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 130);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 12;
            label4.Text = "Titulación Asociada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 169);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 13;
            label5.Text = "Area de Conocimiento:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(402, 226);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 20);
            btnCancelar.TabIndex = 54;
            btnCancelar.Text = "Volver a menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FrmAsignaturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(cbArea);
            Controls.Add(cbTitulacion);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dgvAsignatura);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FrmAsignaturas";
            Text = "FrmAsignaturas";
            Load += FrmAsignaturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsignatura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvAsignatura;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox cbTitulacion;
        private ComboBox cbArea;
        private Button btnAgregar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCancelar;
    }
}
