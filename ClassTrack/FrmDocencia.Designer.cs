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
            btnCancelar.Location = new Point(604, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 33);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(441, 379);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 33);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(266, 379);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 33);
            btnEditar.TabIndex = 34;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(86, 379);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 33);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDocencia
            // 
            dgvDocencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocencia.Location = new Point(351, 59);
            dgvDocencia.Name = "dgvDocencia";
            dgvDocencia.RowHeadersWidth = 62;
            dgvDocencia.Size = new Size(364, 277);
            dgvDocencia.TabIndex = 29;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(86, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(119, 32);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Docencia";
            // 
            // cbProfe
            // 
            cbProfe.FormattingEnabled = true;
            cbProfe.Location = new Point(76, 130);
            cbProfe.Name = "cbProfe";
            cbProfe.Size = new Size(183, 33);
            cbProfe.TabIndex = 32;
            // 
            // lblProfe
            // 
            lblProfe.AutoSize = true;
            lblProfe.Location = new Point(76, 101);
            lblProfe.Name = "lblProfe";
            lblProfe.Size = new Size(100, 25);
            lblProfe.TabIndex = 39;
            lblProfe.Text = "Profesores:";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(76, 193);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(109, 25);
            lblAsignatura.TabIndex = 42;
            lblAsignatura.Text = "Asignaturas:";
            // 
            // cbAsignatura
            // 
            cbAsignatura.FormattingEnabled = true;
            cbAsignatura.Location = new Point(76, 222);
            cbAsignatura.Name = "cbAsignatura";
            cbAsignatura.Size = new Size(183, 33);
            cbAsignatura.TabIndex = 41;
            // 
            // FrmDocencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FrmDocencia";
            Text = "FrmDocencia";
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