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
            cbProfesores = new ComboBox();
            lblTitulo = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Location = new Point(306, 191);
            btnExportarPDF.Margin = new Padding(2);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(180, 32);
            btnExportarPDF.TabIndex = 40;
            btnExportarPDF.Text = "Exportar";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(60, 54);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(65, 15);
            lblArea.TabIndex = 39;
            lblArea.Text = "Profesores:";
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.Location = new Point(60, 191);
            btnGenerarInforme.Margin = new Padding(2);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(180, 32);
            btnGenerarInforme.TabIndex = 33;
            btnGenerarInforme.Text = "Generar";
            btnGenerarInforme.UseVisualStyleBackColor = true;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // cbProfesores
            // 
            cbProfesores.FormattingEnabled = true;
            cbProfesores.Location = new Point(60, 71);
            cbProfesores.Margin = new Padding(2);
            cbProfesores.Name = "cbProfesores";
            cbProfesores.Size = new Size(426, 23);
            cbProfesores.TabIndex = 32;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(192, 21);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 21);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Informes de Profesores";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(222, 239);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 20);
            btnCancelar.TabIndex = 54;
            btnCancelar.Text = "Volver a menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnCancelar);
            Controls.Add(btnExportarPDF);
            Controls.Add(lblArea);
            Controls.Add(btnGenerarInforme);
            Controls.Add(cbProfesores);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "FrmInformes";
            Text = "FrmInformes";
            Load += FrmInformes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExportarPDF;
        private Label lblArea;
        private Button btnGenerarInforme;
        private ComboBox cbProfesores;
        private Label lblTitulo;
        private Button btnCancelar;
    }
}