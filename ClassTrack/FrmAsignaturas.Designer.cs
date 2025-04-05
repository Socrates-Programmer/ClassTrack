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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(237, 34);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(255, 166);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 73);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 109);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(50, 147);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(50, 184);
            comboBox2.Margin = new Padding(2, 2, 2, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(50, 226);
            btnAgregar.Margin = new Padding(2, 2, 2, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 20);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(174, 226);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 20);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(293, 226);
            btnEliminar.Margin = new Padding(2, 2, 2, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 20);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(414, 226);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 20);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Volver al menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            // FrmAsignaturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmAsignaturas";
            Text = "FrmAsignaturas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
