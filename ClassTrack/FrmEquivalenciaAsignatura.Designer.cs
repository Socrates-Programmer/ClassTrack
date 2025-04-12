namespace ClassTrack
{
    partial class FrmEquivalenciaAsignatura
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
            lblArea = new Label();
            btnCancelar = new Button();
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
            label1.Location = new Point(11, 124);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 57;
            label1.Text = "Asignatura 2";
            // 
            // cbAsignatura2
            // 
            cbAsignatura2.FormattingEnabled = true;
            cbAsignatura2.Location = new Point(11, 141);
            cbAsignatura2.Margin = new Padding(2);
            cbAsignatura2.Name = "cbAsignatura2";
            cbAsignatura2.Size = new Size(208, 23);
            cbAsignatura2.TabIndex = 56;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(11, 71);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(73, 15);
            lblArea.TabIndex = 54;
            lblArea.Text = "Asignatura 1";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(389, 221);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 20);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Volver a menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(26, 221);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 20);
            btnAgregar.TabIndex = 50;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbAsignatura1
            // 
            cbAsignatura1.FormattingEnabled = true;
            cbAsignatura1.Location = new Point(11, 88);
            cbAsignatura1.Margin = new Padding(2);
            cbAsignatura1.Name = "cbAsignatura1";
            cbAsignatura1.Size = new Size(208, 23);
            cbAsignatura1.TabIndex = 49;
            // 
            // dgvEquivalente
            // 
            dgvEquivalente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquivalente.Location = new Point(239, 34);
            dgvEquivalente.Margin = new Padding(2);
            dgvEquivalente.Name = "dgvEquivalente";
            dgvEquivalente.RowHeadersWidth = 62;
            dgvEquivalente.Size = new Size(255, 166);
            dgvEquivalente.TabIndex = 48;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(11, 34);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(188, 21);
            lblTitulo.TabIndex = 47;
            lblTitulo.Text = "Asignatura Equivalente";
            // 
            // FrmEquivalenciaAsignatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 280);
            Controls.Add(label1);
            Controls.Add(cbAsignatura2);
            Controls.Add(lblArea);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cbAsignatura1);
            Controls.Add(dgvEquivalente);
            Controls.Add(lblTitulo);
            Name = "FrmEquivalenciaAsignatura";
            Text = "FrmEquivalenciaAsignatura";
            Load += FrmEquivalenciaAsignatura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquivalente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbAsignatura2;
        private Label lblArea;
        private Button btnCancelar;
        private Button btnAgregar;
        private ComboBox cbAsignatura1;
        private DataGridView dgvEquivalente;
        private Label lblTitulo;
    }
}