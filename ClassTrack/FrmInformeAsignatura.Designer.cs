namespace ClassTrack
{
    partial class FrmInformeAsignatura
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
            cbAsignatura = new ComboBox();
            lblTitulo = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Location = new Point(285, 204);
            btnExportarPDF.Margin = new Padding(2);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(180, 32);
            btnExportarPDF.TabIndex = 45;
            btnExportarPDF.Text = "Exportar";
            btnExportarPDF.UseVisualStyleBackColor = true;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(39, 67);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(67, 15);
            lblArea.TabIndex = 44;
            lblArea.Text = "Asignatura:";
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.Location = new Point(39, 204);
            btnGenerarInforme.Margin = new Padding(2);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(180, 32);
            btnGenerarInforme.TabIndex = 43;
            btnGenerarInforme.Text = "Generar";
            btnGenerarInforme.UseVisualStyleBackColor = true;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // cbAsignatura
            // 
            cbAsignatura.FormattingEnabled = true;
            cbAsignatura.Location = new Point(39, 84);
            cbAsignatura.Margin = new Padding(2);
            cbAsignatura.Name = "cbAsignatura";
            cbAsignatura.Size = new Size(426, 23);
            cbAsignatura.TabIndex = 42;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(171, 34);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(188, 21);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Informes de Asignatura";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(199, 246);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 20);
            btnCancelar.TabIndex = 54;
            btnCancelar.Text = "Volver a menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmInformeAsignatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 277);
            Controls.Add(btnCancelar);
            Controls.Add(btnExportarPDF);
            Controls.Add(lblArea);
            Controls.Add(btnGenerarInforme);
            Controls.Add(cbAsignatura);
            Controls.Add(lblTitulo);
            Name = "FrmInformeAsignatura";
            Text = "FrmInformeAsignatura";
            Load += FrmInformeAsignatura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExportarPDF;
        private Label lblArea;
        private Button btnGenerarInforme;
        private ComboBox cbAsignatura;
        private Label lblTitulo;
        private Button btnCancelar;
    }
}