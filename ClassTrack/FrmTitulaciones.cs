using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Repositories;

namespace ClassTrack
{
    public partial class FrmTitulaciones : Form
    {
        private TitulacionRepository TitulacionRepository;
        public FrmTitulaciones()
        {
            InitializeComponent();
            TitulacionRepository = new TitulacionRepository();
        }

        private  async Task LoadTitulaciones()
        {
            var titulaciones = await TitulacionRepository.GetAllAsync();
            dgvTitulaciones.DataSource = null;
            dgvTitulaciones.DataSource = titulaciones;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

           // string nivel = cbNivel.SelectedItem.ToString();

            var entidad = new Titulacion()
            {
                Nombre = txtNombre.Text
            };

            await TitulacionRepository.InsertAsync(entidad);
<<<<<<< HEAD
            LoadTitulaciones();  // Actualizar el DataGridView
=======
            await LoadTitulaciones();  // Actualizar el DataGridView
>>>>>>> 08031860b334ab19c6906e5d19ffcb76c88ab093
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private async void FrmTitulaciones_Load(object sender, EventArgs e)
        {
            await LoadTitulaciones();
        }
    }
}
