namespace ClassTrack
{
    partial class FrmTitulaciones
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
            btnGuardar = new Button();
            lblNivel = new Label();
            lblNombre = new Label();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            cbNivel = new ComboBox();
            txtNombre = new TextBox();
            dgvTitulaciones = new DataGridView();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTitulaciones).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(212, 378);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(85, 186);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(148, 25);
            lblNivel.TabIndex = 39;
            lblNivel.Text = "Nivel Académico:\n";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(85, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(205, 25);
            lblNombre.TabIndex = 37;
            lblNombre.Text = "Nombre de la Titulación:\n";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(604, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(470, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(339, 378);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 34;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(85, 378);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbNivel
            // 
            cbNivel.FormattingEnabled = true;
            cbNivel.Location = new Point(85, 214);
            cbNivel.Name = "cbNivel";
            cbNivel.Size = new Size(182, 33);
            cbNivel.TabIndex = 32;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 31);
            txtNombre.TabIndex = 30;
            // 
            // dgvTitulaciones
            // 
            dgvTitulaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitulaciones.Location = new Point(352, 59);
            dgvTitulaciones.Name = "dgvTitulaciones";
            dgvTitulaciones.RowHeadersWidth = 62;
            dgvTitulaciones.Size = new Size(364, 276);
            dgvTitulaciones.TabIndex = 29;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(85, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(152, 32);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Titulaciones";
            // 
            // FrmTitulaciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(lblNivel);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(cbNivel);
            Controls.Add(txtNombre);
            Controls.Add(dgvTitulaciones);
            Controls.Add(lblTitulo);
            Name = "FrmTitulaciones";
            Text = "FrmTitulaciones";
            ((System.ComponentModel.ISupportInitialize)dgvTitulaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label lblNivel;
        private Label lblNombre;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private ComboBox cbNivel;
        private TextBox txtNombre;
        private DataGridView dgvTitulaciones;
        private Label lblTitulo;
    }
}