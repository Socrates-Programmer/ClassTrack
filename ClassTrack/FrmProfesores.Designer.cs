namespace ClassTrack
{
    partial class FrmProfesores
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
            lblArea = new Label();
            lblCedula = new Label();
            lblNombre = new Label();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            cbArea = new ComboBox();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            dgvProfesores = new DataGridView();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            SuspendLayout();
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(85, 239);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(193, 25);
            lblArea.TabIndex = 26;
            lblArea.Text = "Área de Conocimiento:\n";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(85, 158);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(70, 25);
            lblCedula.TabIndex = 25;
            lblCedula.Text = "Cédula:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(85, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(604, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(431, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(262, 378);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(85, 378);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(85, 267);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(182, 33);
            cbArea.TabIndex = 18;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(85, 183);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(182, 31);
            txtCedula.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 31);
            txtNombre.TabIndex = 16;
            // 
            // dgvProfesores
            // 
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesores.Location = new Point(352, 59);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.RowHeadersWidth = 62;
            dgvProfesores.Size = new Size(364, 276);
            dgvProfesores.TabIndex = 15;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(85, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(136, 32);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Profesores";
            // 
            // FrmProfesores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblArea);
            Controls.Add(lblCedula);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(cbArea);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(dgvProfesores);
            Controls.Add(lblTitulo);
            Name = "FrmProfesores";
            Text = "FrmProfesores";
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblArea;
        private Label lblCedula;
        private Label lblNombre;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private ComboBox cbArea;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private DataGridView dgvProfesores;
        private Label lblTitulo;
    }
}