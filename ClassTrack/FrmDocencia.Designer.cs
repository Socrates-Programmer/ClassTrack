namespace ClassTrack
{
    partial class FrmDocencia
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
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvDocencia = new DataGridView();
            lblTitulo = new Label();
            cbProfe = new ComboBox();
            lblProfe = new Label();
            lblAsignatura = new Label();
            cbAsignatura = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDocencia).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(423, 227);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 20);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(309, 227);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 20);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(186, 227);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 20);
            btnEditar.TabIndex = 34;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(60, 227);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 20);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDocencia
            // 
            dgvDocencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocencia.Location = new Point(246, 35);
            dgvDocencia.Margin = new Padding(2);
            dgvDocencia.Name = "dgvDocencia";
            dgvDocencia.RowHeadersWidth = 62;
            dgvDocencia.Size = new Size(255, 166);
            dgvDocencia.TabIndex = 29;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(60, 23);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(81, 21);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Docencia";
            // 
            // cbProfe
            // 
            cbProfe.FormattingEnabled = true;
            cbProfe.Location = new Point(53, 78);
            cbProfe.Margin = new Padding(2);
            cbProfe.Name = "cbProfe";
            cbProfe.Size = new Size(129, 23);
            cbProfe.TabIndex = 32;
            // 
            // lblProfe
            // 
            lblProfe.AutoSize = true;
            lblProfe.Location = new Point(53, 61);
            lblProfe.Margin = new Padding(2, 0, 2, 0);
            lblProfe.Name = "lblProfe";
            lblProfe.Size = new Size(65, 15);
            lblProfe.TabIndex = 39;
            lblProfe.Text = "Profesores:";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(53, 116);
            lblAsignatura.Margin = new Padding(2, 0, 2, 0);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(72, 15);
            lblAsignatura.TabIndex = 42;
            lblAsignatura.Text = "Asignaturas:";
            // 
            // cbAsignatura
            // 
            cbAsignatura.FormattingEnabled = true;
            cbAsignatura.Location = new Point(53, 133);
            cbAsignatura.Margin = new Padding(2);
            cbAsignatura.Name = "cbAsignatura";
            cbAsignatura.Size = new Size(129, 23);
            cbAsignatura.TabIndex = 41;
            // 
            // FrmDocencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lblAsignatura);
            Controls.Add(cbAsignatura);
            Controls.Add(lblProfe);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(cbProfe);
            Controls.Add(dgvDocencia);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "FrmDocencia";
            Text = "FrmDocencia";
            Load += FrmDocencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private DataGridView dgvDocencia;
        private Label lblTitulo;
        private ComboBox cbProfe;
        private Label lblProfe;
        private Label lblAsignatura;
        private ComboBox cbAsignatura;
    }
}