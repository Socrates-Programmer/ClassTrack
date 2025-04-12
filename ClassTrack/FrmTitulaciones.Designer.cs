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
            lblNivel = new Label();
            lblNombre = new Label();
            btnAgregar = new Button();
            cbNivel = new ComboBox();
            txtNombre = new TextBox();
            dgvTitulaciones = new DataGridView();
            lblTitulo = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTitulaciones).BeginInit();
            SuspendLayout();
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(60, 112);
            lblNivel.Margin = new Padding(2, 0, 2, 0);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(100, 15);
            lblNivel.TabIndex = 39;
            lblNivel.Text = "Nivel Académico:\n";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(60, 58);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(137, 15);
            lblNombre.TabIndex = 37;
            lblNombre.Text = "Nombre de la Titulación:\n";
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
            // cbNivel
            // 
            cbNivel.FormattingEnabled = true;
            cbNivel.Location = new Point(60, 128);
            cbNivel.Margin = new Padding(2);
            cbNivel.Name = "cbNivel";
            cbNivel.Size = new Size(129, 23);
            cbNivel.TabIndex = 32;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(60, 74);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 30;
            // 
            // dgvTitulaciones
            // 
            dgvTitulaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitulaciones.Location = new Point(246, 35);
            dgvTitulaciones.Margin = new Padding(2);
            dgvTitulaciones.Name = "dgvTitulaciones";
            dgvTitulaciones.RowHeadersWidth = 62;
            dgvTitulaciones.Size = new Size(255, 166);
            dgvTitulaciones.TabIndex = 29;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(60, 23);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(103, 21);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Titulaciones";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(396, 239);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 20);
            btnCancelar.TabIndex = 54;
            btnCancelar.Text = "Volver a menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmTitulaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnCancelar);
            Controls.Add(lblNivel);
            Controls.Add(lblNombre);
            Controls.Add(btnAgregar);
            Controls.Add(cbNivel);
            Controls.Add(txtNombre);
            Controls.Add(dgvTitulaciones);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "FrmTitulaciones";
            Text = "FrmTitulaciones";
            Load += FrmTitulaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTitulaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNivel;
        private Label lblNombre;
        private Button btnAgregar;
        private ComboBox cbNivel;
        private TextBox txtNombre;
        private DataGridView dgvTitulaciones;
        private Label lblTitulo;
        private Button btnCancelar;
    }
}