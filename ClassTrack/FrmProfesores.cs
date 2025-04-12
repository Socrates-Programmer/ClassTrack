using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Repositories;
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
        private readonly AreaConocimientoRepository _areaConocimientoRepository;
        private readonly ProfesoresRepository _profesoresRepository;

        public FrmProfesores()
        {
            InitializeComponent();
            _areaConocimientoRepository = new AreaConocimientoRepository();
            _profesoresRepository = new ProfesoresRepository();

            // TODO: Llenar dgvProfesores con datos desde la base de datos
            // TODO: Llenar cbArea con las áreas disponibles
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Campo nombre vacio");
                return;
            }

            var entidad = new Profesor()
            {
                Nombre = txtNombre.Text,
                AreaConocimientoId = (int)cbArea.SelectedValue,
                Despacho = txtDespacho.Text,
            };

            if (await _profesoresRepository.InsertAsync(entidad))
            {
                MessageBox.Show("Profesor creado");
            }
            else
            {
                MessageBox.Show("Profesor no se puedo crear");
                return;
            }

            txtNombre.Text = "";
            txtDespacho.Text = "";
            txtNombre.Focus();
            await CargarDatos();
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

        private async void FrmProfesores_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }


        private async Task CargarDatos()
        {
            dgvProfesores.DataBindings.Clear();
            //cbDepartamento.Items.Clear();
            var data = await _profesoresRepository.GetAllAsync();
            var listArea = await _areaConocimientoRepository.GetAllAsync();


            cbArea.DataSource = listArea;
            cbArea.DisplayMember = "Nombre";   // Lo que se muestra
            cbArea.ValueMember = "Id";         // Valor asociado

            dgvProfesores.DataSource = data;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            menu Menua = new menu();

            Menua.Show();
        }
    }
}
