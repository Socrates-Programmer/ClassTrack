namespace ClassTrack
{
    partial class FrmInformes
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
            btnExportarPDF = new Button();
            lblArea = new Label();
            btnGenerarInforme = new Button();
            cbFiltroTitulacion = new ComboBox();
            lblTitulo = new Label();
            dgvInforme = new DataGridView();
            lblMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).BeginInit();
            SuspendLayout();
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Location = new Point(183, 195);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(112, 34);
            btnExportarPDF.TabIndex = 40;
            btnExportarPDF.Text = "Exportar";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(85, 90);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(193, 25);
            lblArea.TabIndex = 39;
            lblArea.Text = "Área de Conocimiento:\n";
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.Location = new Point(56, 195);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(112, 34);
            btnGenerarInforme.TabIndex = 33;
            btnGenerarInforme.Text = "Generar";
            btnGenerarInforme.UseVisualStyleBackColor = true;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // cbFiltroTitulacion
            // 
            cbFiltroTitulacion.FormattingEnabled = true;
            cbFiltroTitulacion.Location = new Point(85, 118);
            cbFiltroTitulacion.Name = "cbFiltroTitulacion";
            cbFiltroTitulacion.Size = new Size(182, 33);
            cbFiltroTitulacion.TabIndex = 32;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(85, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(117, 32);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Informes";
            // 
            // dgvInforme
            // 
            dgvInforme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInforme.Location = new Point(322, 54);
            dgvInforme.Name = "dgvInforme";
            dgvInforme.RowHeadersWidth = 62;
            dgvInforme.Size = new Size(426, 341);
            dgvInforme.TabIndex = 29;
            dgvInforme.CellContentClick += dgvProfesores_CellContentClick;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(152, 298);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(77, 25);
            lblMensaje.TabIndex = 41;
            lblMensaje.Text = "Mensaje";
            // 
            // FrmInformes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(btnExportarPDF);
            Controls.Add(lblArea);
            Controls.Add(btnGenerarInforme);
            Controls.Add(cbFiltroTitulacion);
            Controls.Add(dgvInforme);
            Controls.Add(lblTitulo);
            Name = "FrmInformes";
            Text = "FrmInformes";
            ((System.ComponentModel.ISupportInitialize)dgvInforme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExportarPDF;
        private Label lblArea;
        private Button btnGenerarInforme;
        private ComboBox cbFiltroTitulacion;
        private Label lblTitulo;
        private DataGridView dgvInforme;
        private Label lblMensaje;
    }
}