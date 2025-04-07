namespace ClassTrack.Informes
{
    partial class FrmInformeProfesor
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
            h = new Label();
            lblProfesor = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblAreaConocimiento = new Label();
            lblDepartamento = new Label();
            lblDespacho = new Label();
            label5 = new Label();
            lbAsignatura = new ListBox();
            lbHorario = new ListBox();
            SuspendLayout();
            // 
            // h
            // 
            h.AutoSize = true;
            h.Location = new Point(12, 21);
            h.Name = "h";
            h.Size = new Size(150, 15);
            h.TabIndex = 0;
            h.Text = "INFORME POR PROFESOR: ";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(159, 22);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(242, 15);
            lblProfesor.TabIndex = 1;
            lblProfesor.Text = "***********************************************";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 2;
            label2.Text = "AREA DE CONOCIMIENTO: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 3;
            label1.Text = "DEPARTAMENTO: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "DESPACHO: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(204, 15);
            label4.TabIndex = 5;
            label4.Text = "ASIGNATURAS QUE IMPARTE CURSO:";
            // 
            // lblAreaConocimiento
            // 
            lblAreaConocimiento.AutoSize = true;
            lblAreaConocimiento.Location = new Point(159, 65);
            lblAreaConocimiento.Name = "lblAreaConocimiento";
            lblAreaConocimiento.Size = new Size(167, 15);
            lblAreaConocimiento.TabIndex = 6;
            lblAreaConocimiento.Text = "********************************";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(159, 89);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(167, 15);
            lblDepartamento.TabIndex = 7;
            lblDepartamento.Text = "********************************";
            // 
            // lblDespacho
            // 
            lblDespacho.AutoSize = true;
            lblDespacho.Location = new Point(159, 113);
            lblDespacho.Name = "lblDespacho";
            lblDespacho.Size = new Size(167, 15);
            lblDespacho.TabIndex = 8;
            lblDespacho.Text = "********************************";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 138);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 9;
            label5.Text = "HORARIO DE CONSULTAS: ";
            // 
            // lbAsignatura
            // 
            lbAsignatura.FormattingEnabled = true;
            lbAsignatura.ItemHeight = 15;
            lbAsignatura.Location = new Point(18, 163);
            lbAsignatura.Name = "lbAsignatura";
            lbAsignatura.Size = new Size(198, 154);
            lbAsignatura.TabIndex = 10;
            // 
            // lbHorario
            // 
            lbHorario.FormattingEnabled = true;
            lbHorario.ItemHeight = 15;
            lbHorario.Location = new Point(345, 163);
            lbHorario.Name = "lbHorario";
            lbHorario.Size = new Size(198, 154);
            lbHorario.TabIndex = 11;
            // 
            // FrmInformeProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 325);
            Controls.Add(lbHorario);
            Controls.Add(lbAsignatura);
            Controls.Add(label5);
            Controls.Add(lblDespacho);
            Controls.Add(lblDepartamento);
            Controls.Add(lblAreaConocimiento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblProfesor);
            Controls.Add(h);
            Name = "FrmInformeProfesor";
            Text = "FrmInformeProfesor";
            Load += FrmInformeProfesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label h;
        private Label lblProfesor;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblAreaConocimiento;
        private Label lblDepartamento;
        private Label lblDespacho;
        private Label label5;
        private ListBox lbAsignatura;
        private ListBox lbHorario;
    }
}