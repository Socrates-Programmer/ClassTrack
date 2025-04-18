﻿using System;
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

        private async Task LoadTitulaciones()
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

            await LoadTitulaciones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private async void FrmTitulaciones_Load(object sender, EventArgs e)
        {
            await LoadTitulaciones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Mostrar el formulario de menú
            menu Menua = new menu();

            Menua.Show();
        }
    }
}
