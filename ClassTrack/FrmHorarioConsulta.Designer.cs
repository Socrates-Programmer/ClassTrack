namespace ClassTrack
{
    partial class FrmHorarioConsulta
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
            btnAgregar = new Button();
            cbProfesor = new ComboBox();
            dgvHorarioConsulta = new DataGridView();
            lblTitulo = new Label();
            label1 = new Label();
            cbDias = new ComboBox();
            dTPHorarioInicio = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dTPHorarioFin = new DateTimePicker();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHorarioConsulta).BeginInit();
            SuspendLayout();
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(35, 74);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(51, 15);
            lblArea.TabIndex = 39;
            lblArea.Text = "Profesor";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 313);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 20);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbProfesor
            // 
            cbProfesor.FormattingEnabled = true;
            cbProfesor.Location = new Point(35, 91);
            cbProfesor.Margin = new Padding(2);
            cbProfesor.Name = "cbProfesor";
            cbProfesor.Size = new Size(129, 23);
            cbProfesor.TabIndex = 32;
            // 
            // dgvHorarioConsulta
            // 
            dgvHorarioConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorarioConsulta.Location = new Point(221, 43);
            dgvHorarioConsulta.Margin = new Padding(2);
            dgvHorarioConsulta.Name = "dgvHorarioConsulta";
            dgvHorarioConsulta.RowHeadersWidth = 62;
            dgvHorarioConsulta.Size = new Size(255, 166);
            dgvHorarioConsulta.TabIndex = 29;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(35, 31);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(143, 21);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Horarios profesor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 127);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 42;
            label1.Text = "Dias";
            label1.Click += label1_Click;
            // 
            // cbDias
            // 
            cbDias.FormattingEnabled = true;
            cbDias.Location = new Point(35, 144);
            cbDias.Margin = new Padding(2);
            cbDias.Name = "cbDias";
            cbDias.Size = new Size(129, 23);
            cbDias.TabIndex = 41;
            // 
            // dTPHorarioInicio
            // 
            dTPHorarioInicio.Format = DateTimePickerFormat.Time;
            dTPHorarioInicio.Location = new Point(2, 204);
            dTPHorarioInicio.Name = "dTPHorarioInicio";
            dTPHorarioInicio.ShowUpDown = true;
            dTPHorarioInicio.Size = new Size(200, 23);
            dTPHorarioInicio.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 186);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 44;
            label2.Text = "Horario de Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 239);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 46;
            label3.Text = "Horario de Final";
            // 
            // dTPHorarioFin
            // 
            dTPHorarioFin.Format = DateTimePickerFormat.Time;
            dTPHorarioFin.Location = new Point(2, 257);
            dTPHorarioFin.Name = "dTPHorarioFin";
            dTPHorarioFin.ShowUpDown = true;
            dTPHorarioFin.Size = new Size(200, 23);
            dTPHorarioFin.TabIndex = 45;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(371, 313);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 20);
            btnCancelar.TabIndex = 54;
            btnCancelar.Text = "Volver a menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmHorarioConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 370);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(dTPHorarioFin);
            Controls.Add(label2);
            Controls.Add(dTPHorarioInicio);
            Controls.Add(label1);
            Controls.Add(cbDias);
            Controls.Add(lblArea);
            Controls.Add(btnAgregar);
            Controls.Add(cbProfesor);
            Controls.Add(dgvHorarioConsulta);
            Controls.Add(lblTitulo);
            Name = "FrmHorarioConsulta";
            Text = "FrmHorarioConsulta";
            Load += FrmHorarioConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHorarioConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblArea;
        private Button btnAgregar;
        private ComboBox cbProfesor;
        private DataGridView dgvHorarioConsulta;
        private Label lblTitulo;
        private Label label1;
        private ComboBox cbDias;
        private DateTimePicker dTPHorarioInicio;
        private Label label2;
        private Label label3;
        private DateTimePicker dTPHorarioFin;
        private Button btnCancelar;
    }
}