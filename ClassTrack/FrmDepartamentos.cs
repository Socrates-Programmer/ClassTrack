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
    public partial class FrmDepartamentos : Form
    {
        public DepartamentoRepository _departamentoRepository;
        public FrmDepartamentos()
        {
            InitializeComponent();
            _departamentoRepository = new DepartamentoRepository();

        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Campo nombre vacio");
                return;
            }

            var entidad = new Departamento()
            {
                Nombre = txtNombre.Text
            };

            if (await _departamentoRepository.InsertAsync(entidad))
            {
                MessageBox.Show("Departamento creado");
            }
            else
            {
                MessageBox.Show("Departamento no se puedo crear");
                return;
            }

            txtNombre.Text = "";
            txtNombre.Focus();
            await CargarDatos();
        }

        private async void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }


        private async Task CargarDatos()
        {
            dgvDepartamentos.DataBindings.Clear();
            var data = await _departamentoRepository.GetAllAsync();

            dgvDepartamentos.DataSource = data;
        }
    }
}
