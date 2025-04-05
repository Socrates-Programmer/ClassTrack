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

        private async void LoadTitulaciones()
        {
            var titulaciones = await TitulacionRepository.GetAllAsync();
            dgvTitulaciones.DataSource = null;
            dgvTitulaciones.DataSource = titulaciones;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || cbNivel.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            string nivel = cbNivel.SelectedItem.ToString();

            var entidad = new Titulacion()
            {
                Nombre = txtNombre.Text
            };

            TitulacionRepository.InsertAsync(entidad);
            LoadTitulaciones();  // Actualizar el DataGridView
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
