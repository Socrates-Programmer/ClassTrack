namespace ClassTrack
{
    partial class FrmAreasConocimiento
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
            label4 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnAgregar = new Button();
            cbDepartamento = new ComboBox();
            txtNombre = new TextBox();
            dgvAreaConocimiento = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAreaConocimiento).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 111);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 26;
            label4.Text = "Departamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 24;
            label2.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(366, 227);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 20);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Volver a menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(34, 227);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 20);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbDepartamento
            // 
            cbDepartamento.FormattingEnabled = true;
            cbDepartamento.Location = new Point(34, 128);
            cbDepartamento.Margin = new Padding(2);
            cbDepartamento.Name = "cbDepartamento";
            cbDepartamento.Size = new Size(129, 23);
            cbDepartamento.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 74);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 16;
            // 
            // dgvAreaConocimiento
            // 
            dgvAreaConocimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAreaConocimiento.Location = new Point(221, 35);
            dgvAreaConocimiento.Margin = new Padding(2);
            dgvAreaConocimiento.Name = "dgvAreaConocimiento";
            dgvAreaConocimiento.RowHeadersWidth = 62;
            dgvAreaConocimiento.Size = new Size(255, 166);
            dgvAreaConocimiento.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 21);
            label1.TabIndex = 14;
            label1.Text = "Area de Conocimiento";
            label1.Click += label1_Click;
            // 
            // FrmAreasConocimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 280);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cbDepartamento);
            Controls.Add(txtNombre);
            Controls.Add(dgvAreaConocimiento);
            Controls.Add(label1);
            Name = "FrmAreasConocimiento";
            Text = "FrmAreasConocimiento";
            Load += FrmAreasConocimiento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAreaConocimiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label2;
        private Button btnCancelar;
        private Button btnAgregar;
        private ComboBox comboBox2;
        private ComboBox cbDepartamento;
        private TextBox txtNombre;
        private DataGridView dgvAreaConocimiento;
        private Label label1;
    }
}