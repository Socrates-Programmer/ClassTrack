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
    public partial class FrmDocencia : Form
    {
        private DocenciaRepository repository;
        private ProfesoresRepository profesoresRepository;
        private AsignaturasRepository asignaturasRepository;
        public FrmDocencia()
        {
            InitializeComponent();
            repository = new DocenciaRepository();
            profesoresRepository = new ProfesoresRepository();
            asignaturasRepository = new AsignaturasRepository();
        }

        private async void FrmDocencia_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            dgvDocencia.DataBindings.Clear();
            //cbDepartamento.Items.Clear();
            var data = await repository.GetAllAsync();
            var listProfesores = await profesoresRepository.GetAllAsync();
            var listAsignaturas = await asignaturasRepository.GetAllAsync();


            cbAsignatura.DataSource = listAsignaturas;
            cbAsignatura.DisplayMember = "Nombre";   // Lo que se muestra
            cbAsignatura.ValueMember = "Id";         // Valor asociado

            cbProfe.DataSource = listProfesores;
            cbProfe.DisplayMember = "Nombre";   // Lo que se muestra
            cbProfe.ValueMember = "Id";         // Valor asociado

            dgvDocencia.DataSource = data;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbProfe.SelectedItem == null || cbAsignatura.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un profesor y una asignatura.");
                return;
            }

            var entidad = new Docencia()
            {
                ProfesorID = (int)cbProfe.SelectedValue,
                AsignaturaID = (int)cbAsignatura.SelectedValue
            };

            try
            {
                await repository.InsertAsync(entidad);
                MessageBox.Show("Docencia agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            await CargarDatos();
        }
    }
}
