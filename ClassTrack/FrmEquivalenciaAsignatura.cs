using ClassTrack.Domain.Entities;
using ClassTrack.Domain.Enums;
using ClassTrack.Persistence.Repositories;

namespace ClassTrack
{
    public partial class FrmEquivalenciaAsignatura : Form
    {
        private readonly EquivalenciaAsignaturaRepository _equivalenciaAsignaturaRepository;
        private readonly AsignaturasRepository _asignaturasRepository;
        public FrmEquivalenciaAsignatura()
        {
            InitializeComponent();
            _equivalenciaAsignaturaRepository = new EquivalenciaAsignaturaRepository();
            _asignaturasRepository = new AsignaturasRepository();
        }

        private async void FrmEquivalenciaAsignatura_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            dgvEquivalente.DataBindings.Clear();
            var data = await _equivalenciaAsignaturaRepository.GetAllAsync();
            var listAsignatura = await _asignaturasRepository.GetAllAsync();
            var listAsignatura2 = await _asignaturasRepository.GetAllAsync();

            //  Asignatura 1
            cbAsignatura1.DataSource = listAsignatura;
            cbAsignatura1.DisplayMember = "Nombre";
            cbAsignatura1.ValueMember = "Id";

            //  Asignatura 2
            cbAsignatura2.DataSource = listAsignatura2;
            cbAsignatura2.DisplayMember = "Nombre";
            cbAsignatura2.ValueMember = "Id";

            dgvEquivalente.DataSource = data;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtNombre.Text))
            //{
            //    MessageBox.Show("Campo nombre vacio");
            //    return;
            //}

            var entidad = new EquivalenciaAsignatura()
            {
                AsignaturaID1 = (int)cbAsignatura1.SelectedValue,
                AsignaturaID2 = (int)cbAsignatura2.SelectedValue
            };

            if (await _equivalenciaAsignaturaRepository.InsertAsync(entidad))
            {
                MessageBox.Show("Creado");
            }
            else
            {
                MessageBox.Show("No se puedo crear");
                return;
            }

            //txtNombre.Text = "";
            //txtNombre.Focus();
            await CargarDatos();
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
