namespace ClassTrack
{
    partial class FrmIncompatibilidadAsignatura
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
            label1 = new Label();
            cbAsignatura2 = new ComboBox();
            btnGuardar = new Button();
            lblArea = new Label();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            cbAsignatura1 = new ComboBox();
            dgvEquivalente = new DataGridView();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEquivalente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 114);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 68;
            label1.Text = "Asignatura 2";
            // 
            // cbAsignatura2
            // 
            cbAsignatura2.FormattingEnabled = true;
            cbAsignatura2.Location = new Point(18, 131);
            cbAsignatura2.Margin = new Padding(2);
            cbAsignatura2.Name = "cbAsignatura2";
            cbAsignatura2.Size = new Size(208, 23);
            cbAsignatura2.TabIndex = 67;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(121, 211);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 20);
            btnGuardar.TabIndex = 66;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(18, 61);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(73, 15);
            lblArea.TabIndex = 65;
            lblArea.Text = "Asignatura 1";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(396, 211);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 20);
            btnCancelar.TabIndex = 64;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(302, 211);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 20);
            btnEliminar.TabIndex = 63;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(210, 211);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 20);
            btnEditar.TabIndex = 62;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(33, 211);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 20);
            btnAgregar.TabIndex = 61;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbAsignatura1
            // 
            cbAsignatura1.FormattingEnabled = true;
            cbAsignatura1.Location = new Point(18, 78);
            cbAsignatura1.Margin = new Padding(2);
            cbAsignatura1.Name = "cbAsignatura1";
            cbAsignatura1.Size = new Size(208, 23);
            cbAsignatura1.TabIndex = 60;
            // 
            // dgvEquivalente
            // 
            dgvEquivalente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquivalente.Location = new Point(246, 24);
            dgvEquivalente.Margin = new Padding(2);
            dgvEquivalente.Name = "dgvEquivalente";
            dgvEquivalente.RowHeadersWidth = 62;
            dgvEquivalente.Size = new Size(255, 166);
            dgvEquivalente.TabIndex = 59;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(18, 24);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(199, 21);
            lblTitulo.TabIndex = 58;
            lblTitulo.Text = "Asignatura Incompatible";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // FrmIncompatibilidadAsignatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 264);
            Controls.Add(label1);
            Controls.Add(cbAsignatura2);
            Controls.Add(btnGuardar);
            Controls.Add(lblArea);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(cbAsignatura1);
            Controls.Add(dgvEquivalente);
            Controls.Add(lblTitulo);
            Name = "FrmIncompatibilidadAsignatura";
            Text = "FrmIncompatibilidadAsignatura";
            Load += FrmIncompatibilidadAsignatura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquivalente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbAsignatura2;
        private Button btnGuardar;
        private Label lblArea;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private ComboBox cbAsignatura1;
        private DataGridView dgvEquivalente;
        private Label lblTitulo;
    }
}