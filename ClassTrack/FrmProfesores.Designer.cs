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
            btnAgregar = new Button();
            cbArea = new ComboBox();
            txtDespacho = new TextBox();
            txtNombre = new TextBox();
            dgvProfesores = new DataGridView();
            lblTitulo = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            SuspendLayout();
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(60, 143);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(129, 15);
            lblArea.TabIndex = 26;
            lblArea.Text = "Área de Conocimiento:\n";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(60, 95);
            lblCedula.Margin = new Padding(2, 0, 2, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(59, 15);
            lblCedula.TabIndex = 25;
            lblCedula.Text = "Despacho";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(60, 58);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(60, 227);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 20);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(60, 160);
            cbArea.Margin = new Padding(2);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(129, 23);
            cbArea.TabIndex = 18;
            // 
            // txtDespacho
            // 
            txtDespacho.Location = new Point(60, 110);
            txtDespacho.Margin = new Padding(2);
            txtDespacho.Name = "txtDespacho";
            txtDespacho.Size = new Size(129, 23);
            txtDespacho.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(60, 74);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 16;
            // 
            // dgvProfesores
            // 
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesores.Location = new Point(246, 35);
            dgvProfesores.Margin = new Padding(2);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.RowHeadersWidth = 62;
            dgvProfesores.Size = new Size(255, 166);
            dgvProfesores.TabIndex = 15;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(60, 23);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(90, 21);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Profesores";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(396, 227);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 20);
            btnCancelar.TabIndex = 54;
            btnCancelar.Text = "Volver a menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FrmProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnCancelar);
            Controls.Add(lblArea);
            Controls.Add(lblCedula);
            Controls.Add(lblNombre);
            Controls.Add(btnAgregar);
            Controls.Add(cbArea);
            Controls.Add(txtDespacho);
            Controls.Add(txtNombre);
            Controls.Add(dgvProfesores);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "FrmProfesores";
            Text = "FrmProfesores";
            Load += FrmProfesores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblArea;
        private Label lblCedula;
        private Label lblNombre;
        private Button btnAgregar;
        private ComboBox cbArea;
        private TextBox txtDespacho;
        private TextBox txtNombre;
        private DataGridView dgvProfesores;
        private Label lblTitulo;
        private Button btnCancelar;
    }
}