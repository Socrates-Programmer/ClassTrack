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
    public partial class FrmProfesores : Form
    {
        public FrmProfesores()
        {
            InitializeComponent();
            // TODO: Llenar dgvProfesores con datos desde la base de datos
            // TODO: Llenar cbArea con las áreas disponibles
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            cbArea.SelectedIndex = -1;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // TODO: Obtener profesor seleccionado del DataGridView
            // y cargar datos en los campos para editar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // TODO: Confirmar y eliminar profesor seleccionado
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar campos y selección del DataGridView
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void FrmProfesores_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            menu menuForm = new menu();
            menuForm.Show();
        }
    }
}
