using ClassTrack.Domain.Entities;
using ClassTrack.Domain.Enums;
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
    public partial class FrmGrupos : Form
    {
        private readonly GruposRepository _gruposRepository;
        private readonly AsignaturasRepository _asignaturasRepository;
        public FrmGrupos()
        {
            InitializeComponent();
            _gruposRepository = new GruposRepository();
            _asignaturasRepository = new AsignaturasRepository();
        }

        private async void FrmGrupos_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            dgvGrupo.DataBindings.Clear();
            var data = await _gruposRepository.GetAllAsync();
            var listAsignatura = await _asignaturasRepository.GetAllAsync();

            //Titular
            cbTipo.DataSource = Enum.GetValues(typeof(TipoGrupo));


            //Area de conocimiento
            cbAsignatura.DataSource = listAsignatura;
            cbAsignatura.DisplayMember = "Nombre";
            cbAsignatura.ValueMember = "Id";

            dgvGrupo.DataSource = data;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(txtNombre.Text))
            //{
            //    MessageBox.Show("Campo nombre vacio");
            //    return;
            //}

            var entidad = new Grupos()
            {
                AsignaturaID = (int)cbAsignatura.SelectedValue,
                Tipo = (TipoGrupo)cbTipo.SelectedItem,
                Cantidad = int.Parse(txtCantidad.Text)
            };

            if (await _gruposRepository.InsertAsync(entidad))
            {
                MessageBox.Show("Grupo creado");
            }
            else
            {
                MessageBox.Show("Grupo no se puedo crear");
                return;
            }

            await CargarDatos();
        }
    }
}
