namespace ClassTrack
{
    partial class FrmGrupos
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
            cbTipo = new ComboBox();
            btnGuardar = new Button();
            lblArea = new Label();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            cbAsignatura = new ComboBox();
            dgvGrupo = new DataGridView();
            lblTitulo = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvGrupo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 115);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 57;
            label1.Text = "Tipo";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(51, 132);
            cbTipo.Margin = new Padding(2);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(129, 23);
            cbTipo.TabIndex = 56;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(132, 252);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 20);
            btnGuardar.TabIndex = 55;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(51, 62);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(64, 15);
            lblArea.TabIndex = 54;
            lblArea.Text = "Asignatura";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(407, 252);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 20);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(313, 252);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 20);
            btnEliminar.TabIndex = 52;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(221, 252);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 20);
            btnEditar.TabIndex = 51;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(44, 252);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 20);
            btnAgregar.TabIndex = 50;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbAsignatura
            // 
            cbAsignatura.FormattingEnabled = true;
            cbAsignatura.Location = new Point(51, 79);
            cbAsignatura.Margin = new Padding(2);
            cbAsignatura.Name = "cbAsignatura";
            cbAsignatura.Size = new Size(129, 23);
            cbAsignatura.TabIndex = 49;
            // 
            // dgvGrupo
            // 
            dgvGrupo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupo.Location = new Point(237, 31);
            dgvGrupo.Margin = new Padding(2);
            dgvGrupo.Name = "dgvGrupo";
            dgvGrupo.RowHeadersWidth = 62;
            dgvGrupo.Size = new Size(255, 166);
            dgvGrupo.TabIndex = 48;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(51, 19);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(64, 21);
            lblTitulo.TabIndex = 47;
            lblTitulo.Text = "Grupos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 182);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 58;
            label2.Text = "Cantidad de hora";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(51, 200);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(129, 23);
            txtCantidad.TabIndex = 59;
            // 
            // FrmGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 295);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbTipo);
            Controls.Add(btnGuardar);
            Controls.Add(lblArea);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(cbAsignatura);
            Controls.Add(dgvGrupo);
            Controls.Add(lblTitulo);
            Name = "FrmGrupos";
            Text = "FrmGrupos";
            Load += FrmGrupos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrupo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cbTipo;
        private Button btnGuardar;
        private Label lblArea;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private ComboBox cbAsignatura;
        private DataGridView dgvGrupo;
        private Label lblTitulo;
        private Label label2;
        private TextBox txtCantidad;
    }
}