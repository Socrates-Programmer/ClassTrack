using ClassTrack.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTrack
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmAreasConocimiento areas = new FrmAreasConocimiento();

            areas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmAsignaturas asignatura = new FrmAsignaturas();

            asignatura.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmDepartamentos departamento = new FrmDepartamentos();

            departamento.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmInformes informes = new FrmInformes();

            informes.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmProfesores profesores = new FrmProfesores();

            profesores.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmTitulaciones titulaciones = new FrmTitulaciones();

            titulaciones.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmDocencia Docencia = new FrmDocencia();

            Docencia.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmEquivalenciaAsignatura EquivalenciaAsignatura = new FrmEquivalenciaAsignatura();

            EquivalenciaAsignatura.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmGrupos Grupos = new FrmGrupos();

            Grupos.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmHorarioConsulta Consulta = new FrmHorarioConsulta();

            Consulta.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmIncompatibilidadAsignatura compatibilidadAsignatura = new FrmIncompatibilidadAsignatura();

            compatibilidadAsignatura.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmInformeAsignatura Asignatura = new FrmInformeAsignatura();

            Asignatura.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            FrmInformeAsignatura Asignatura = new FrmInformeAsignatura();

            Asignatura.Show();
        }
    }
}